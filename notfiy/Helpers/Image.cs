using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace notfiy.Helpers
{
    class Image
    {
        static string apiKey = "6d207e02198a847aa98d0a2a901485a5";
        static string apiUrl = "https://freeimage.host/api/1/upload";

        public static async Task<string> UploadImage(string imageUrl)
        {
            using (HttpClient client = new HttpClient())
            using (var formData = new MultipartFormDataContent())
            {
                // Add API key and action
                formData.Add(new StringContent(apiKey), "key");
                formData.Add(new StringContent("upload"), "action");

                // Read the image file
                byte[] imageBytes = File.ReadAllBytes(imageUrl);
                var imageContent = new ByteArrayContent(imageBytes);

                // Add image content to the form data
                formData.Add(imageContent, "source", Path.GetFileName(imageUrl));

                // Send POST request
                HttpResponseMessage response = await client.PostAsync(apiUrl, formData);

                // Check if upload was successful
                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    dynamic responseData = JsonConvert.DeserializeObject(responseContent);
                    string uploadedImageUrl = responseData.image.url;
                    return uploadedImageUrl;
                }
                else
                {
                    Console.WriteLine("Failed to upload image. Status code: " + response.StatusCode);
                    return null;
                }
            }
        }

        public static async Task DownloadImage(string imageUrl, string targetFileOutput)
        {
            using (HttpClient client = new HttpClient())
            {
                // Download image data
                byte[] imageData = await client.GetByteArrayAsync(imageUrl);

                // Save image to file
                File.WriteAllBytes(targetFileOutput, imageData);
            }
        }
    }
}
