using System;
using System.IO;
using System.Net.Http;
using Newtonsoft.Json;

namespace notfiy.Helpers
{
    internal class Image
    {
        static string apiUrl = "https://dc-img-tranceiver.neiaozora.my.id/";

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

        public static string UploadImage(string imageUrl)
        {
            using (HttpClient client = new HttpClient())
            using (var formData = new MultipartFormDataContent())
            {
                // Baca file gambar
                byte[] imageBytes = File.ReadAllBytes(imageUrl);
                var imageContent = new ByteArrayContent(imageBytes);

                // Tambahkan konten gambar ke form data
                formData.Add(imageContent, "source", Path.GetFileName(imageUrl));

                // Kirim permintaan POST
                HttpResponseMessage response = client.PostAsync(apiUrl, formData).Result;

                // Periksa apakah unggahan berhasil
                if (response.IsSuccessStatusCode)
                {
                    string responseContent = response.Content.ReadAsStringAsync().Result;
                    dynamic responseData = JsonConvert.DeserializeObject(responseContent);
                    string uploadedImageUrl = responseData["image-link"];
                    return uploadedImageUrl;
                }
                else
                {
                    Console.WriteLine("Gagal mengunggah gambar. Kode status: " + response.StatusCode);
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
