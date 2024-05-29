using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace notfiy.Helpers
{
    class Image
    {
        static string apiUrl = "https://dc-img-tranceiver.neiaozora.my.id/";

        public static async Task<string> ?UploadImage(string imageUrl)
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
                HttpResponseMessage response = await client.PostAsync(apiUrl, formData);

                // Periksa apakah unggahan berhasil
                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
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

        public static async Task DownloadImage(string imageUrl, string targetFileOutput)
        {
            using (HttpClient client = new HttpClient())
            {
                // Unduh data gambar
                byte[] imageData = await client.GetByteArrayAsync(imageUrl);

                // Simpan gambar ke file
                File.WriteAllBytes(targetFileOutput, imageData);
            }
        }
    }
}
