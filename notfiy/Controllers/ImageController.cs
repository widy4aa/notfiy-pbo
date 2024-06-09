using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Security.Policy;
using notfiy.Helpers;


namespace notfiy.Controllers
{
    class ImageController
    {
        private readonly string dataFolder = "data"; // Tentukan jalur folder data
        private readonly string integrityFile; // file integritas

        public ImageController()
        {
            integrityFile = Path.Combine(dataFolder, "integrity.csv"); // Inisialisasi jalur file integritas

            // Periksa apakah folder "data" sudah ada, buat jika belum
            if (!Directory.Exists(dataFolder))
            {
                Directory.CreateDirectory(dataFolder);
            }
        }

        // Metode ini mengambil gambar berdasarkan ID catatan. Jika gambarnya sudah ada
        // diunduh dan integritasnya diverifikasi, ia mengembalikan path file lokal.
        // Jika tidak, ia akan mengunduh gambar, dan menyimpan atau menimpa hash yang ada di integrity.csv.
        public string? GetImage(int idNote, string imageUrl)
        {
            // Tentukan jalur file gambar
            string imageFilePath = Path.Combine(dataFolder, $"{idNote}.jpg");

            // Muat data integritas jika file ada
            Dictionary<int, string> integrityData = new Dictionary<int, string>();
            if (File.Exists(integrityFile))
            {
                // Membaca file csv
                foreach (var line in File.ReadLines(integrityFile))
                {
                    var parts = line.Split(',');
                    // Jika panjangg parts 2 dan jika parse int dari parts[0] berhasil,
                    // akan membuat variable yg berisi noteId yg tersimpan di integrity.csv 
                    if (parts.Length == 2 && int.TryParse(parts[0], out int noteId))
                    {
                        // menimpa var integrityData dari Key noteId dengan nilai parts[2] (berisi hash)
                        integrityData[noteId] = parts[1];
                    }
                }
            }

            // Periksa apakah file gambar ada dan integritasnya terjaga
            if (File.Exists(imageFilePath) && integrityData.TryGetValue(idNote, out string savedHash))
            {
                string currentHash = ComputeFileHash(imageFilePath);
                if (currentHash == savedHash)
                {
                    return imageFilePath; // Kembalikan gambar yang sudah ada jika hash cocok
                }
            }

            // Unduh gambar
            bool downloadSuccess = Helpers.Image.DownloadImage(imageUrl, imageFilePath);
            if (!downloadSuccess)
            {
                MessageBoxHelper.ShowErrorMessageBox($"Gagal mengunduh gambar untuk ID Catatan: {idNote}");
                return null;
            }

            // Hitung hash SHA256 dari gambar yang diunduh
            string sha256Hash = ComputeFileHash(imageFilePath);

            // Tulis ke file integritas (timpa atau tambahkan entri baru)
            integrityData[idNote] = sha256Hash;
            using (StreamWriter sw = new StreamWriter(integrityFile, false))
            {
                foreach (var entry in integrityData)
                {
                    sw.WriteLine($"{entry.Key},{entry.Value}");
                }
            }

            return imageFilePath;
        }

        // Digunakan untuk mendapatkan URL dari image yg di upload
        public string? ProcessImage(string? imageFileName)
        {
            if (string.IsNullOrEmpty(imageFileName))
            {
                MessageBoxHelper.ShowErrorMessageBox($"Target File string kosong'{imageFileName}' Tidak Ada!");
                return null;
            }

            if (!File.Exists(imageFileName))
            {
                MessageBoxHelper.ShowErrorMessageBox($"Target File '{imageFileName}' Tidak Ada!");
                return null;
            }

            if (!Helpers.Image.IsImageFile(imageFileName))
            {
                MessageBoxHelper.ShowErrorMessageBox($"Target File '{imageFileName}' Bukan Gambar!");
                return null;
            }

            string? imageUrl = Helpers.Image.UploadImage(imageFileName);
            if (string.IsNullOrEmpty(imageUrl))
            {
                MessageBoxHelper.ShowErrorMessageBox($"Result Failed!");
            }
            MessageBoxHelper.ShowInfoMessageBox(imageUrl);
            return imageUrl;
        }

        private string ComputeFileHash(string filePath)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                using (FileStream fs = File.OpenRead(filePath))
                {
                    byte[] hashBytes = sha256.ComputeHash(fs);
                    return BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant();
                }
            }
        }
    }
}
