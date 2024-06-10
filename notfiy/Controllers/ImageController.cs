using notfiy.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;

namespace notfiy.Controllers
{
    class ImageController
    {
        private readonly string dataFolder = "data";
        private readonly string integrityFile;

        public ImageController()
        {
            // Inisialisasi jalur file integritas
            integrityFile = Path.Combine(dataFolder, "integrity.csv");

            // Periksa dan buat folder "data" jika belum ada
            if (!Directory.Exists(dataFolder))
            {
                Directory.CreateDirectory(dataFolder);
            }
        }

        // Metod ini mengambil gambar berdasarkan ID catatan. Jika gambarnya sudah ada di lokal dan terunduh
        // dan integritasnya keaslian file terjaga, ia mengembalikan path file gambar lokal.
        // Jika tidak, ia akan mengunduh gambar, dan menyimpan atau menimpa hash yang ada di integrity.csv.
        public string? ProcessImage(int idNote, string imageUrl)
        {
            // Tentukan jalur file gambar
            string imageFilePath = Path.Combine(dataFolder, $"{idNote}.jpg");

            // Muat data integritas jika file ada
            Dictionary<int, string> integrityData = LoadIntegrityData();

            // Periksa apakah file gambar ada dan integritasnya terjaga
            if (File.Exists(imageFilePath) && integrityData.TryGetValue(idNote, out string savedHash))
            {
                string currentHash = ComputeFileHash(imageFilePath);
                // JIka hash yang tersimpan di .csv dan hash dari gambar lokal sama
                if (currentHash == savedHash)
                {
                    return imageFilePath;
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
            SaveIntegrityData(integrityData);

            return imageFilePath;
        }

        // Memuat data integritas dari file CSV
        private Dictionary<int, string> LoadIntegrityData()
        {
            var integrityData = new Dictionary<int, string>();
            if (File.Exists(integrityFile))
            {
                foreach (var line in File.ReadLines(integrityFile))
                {
                    var parts = line.Split(',');
                    if (parts.Length == 2 && int.TryParse(parts[0], out int noteId))
                    {
                        integrityData[noteId] = parts[1];
                    }
                }
            }
            return integrityData;
        }

        // Menyimpan data integritas ke file CSV
        private void SaveIntegrityData(Dictionary<int, string> integrityData)
        {
            using (StreamWriter sw = new StreamWriter(integrityFile, false))
            {
                foreach (var entry in integrityData)
                {
                    sw.WriteLine($"{entry.Key},{entry.Value}");
                }
            }
        }

        // Menghitung hash SHA256 dari file
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


        // Digunakan untuk mendapatkan URL dari image yg di upload
        public string? UploadImage(string? imageFileName)
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

            return imageUrl;
        }

    }
}
