using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;


namespace notfiy.Helpers
{
    internal class Image
    {
        static string apiUrl = "https://dc-img-tranceiver.neiaozora.my.id/tranceiver";

        public static bool IsImageFile(string filePath)
        {
            string[] imageExtensions = { ".jpg", ".jpeg", ".png", ".gif", ".bmp", ".tiff", ".ico" };
            string fileExtension = Path.GetExtension(filePath).ToLower();

            foreach (string extension in imageExtensions)
            {
                if (fileExtension == extension)
                {
                    return true;
                }
            }

            return false;
        }

        public static string? UploadImage(string filePath)
        {
            FileInfo fileInfo = new FileInfo(filePath);

            // Check if file size is less than or equal to 64KB (64 * 1024 bytes)
            if (fileInfo.Length > 64 * 1024)
            {
                MessageBoxHelper.ShowErrorMessageBox("Batas File Gambar melebihi 64KB.");
                return null;
            }

            using (HttpClient client = new HttpClient())
            using (var formData = new MultipartFormDataContent())
            {
                // Baca file gambar
                byte[] imageBytes = File.ReadAllBytes(filePath);
                var imageContent = new ByteArrayContent(imageBytes);
                string fileName = Path.GetFileName(filePath);
                imageContent.Headers.ContentType = MediaTypeHeaderValue.Parse("image/" + Path.GetExtension(fileName).TrimStart('.'));


                // Tambahkan konten gambar ke form data

                formData.Add(imageContent, "source", fileName);

                // Kirim permintaan POST
                HttpResponseMessage response = client.PostAsync(apiUrl, formData).Result;
                File.WriteAllText("dump.txt", ObjectDumper.Dump(response));

                // Periksa apakah unggahan berhasil
                if (response.IsSuccessStatusCode)
                {
                    string responseContent = response.Content.ReadAsStringAsync().Result;
                    dynamic responseData = JsonConvert.DeserializeObject(responseContent);
                    string jsonString = JsonConvert.SerializeObject(responseData, Formatting.Indented);

                    // Write the JSON string to a file
                    File.WriteAllText("result.json", jsonString);
                    string uploadedImageUrl = responseData["image-url"] != null ? responseData["image-url"].ToString() : null;

                    return uploadedImageUrl;
                }
                else
                {
                    MessageBoxHelper.ShowErrorMessageBox("Gagal mengunggah gambar. Kode status: " + response.StatusCode);
                    return null;
                }
            }
        }

      public static bool DownloadImage(string imageUrl, string targetFileOutput)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Unduh data gambar
                    byte[] imageData = client.GetByteArrayAsync(imageUrl).Result;

                    // Simpan gambar ke file
                    File.WriteAllBytes(targetFileOutput, imageData);
                }
                return true; // Return true jika download dan save sukses
            }
            catch (Exception)
            {
                return false; // Return false if jika terdapat pengecualian
            }
        }
    }
}
