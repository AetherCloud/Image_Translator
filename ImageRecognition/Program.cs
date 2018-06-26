using Google.Apis.Auth.OAuth2;
using Google.Cloud.Vision.V1;
using System;

namespace ImageRecognition
{
    class Program
    {
        static void runner(string filePath)
        {
            // Load an image from a local file.
            var image = Image.FromFile(filePath);
            var client = ImageAnnotatorClient.Create();
            var response = client.DetectText(image);
            foreach (var annotation in response)
            {
                if (annotation.Description != null)
                    Console.WriteLine(annotation.Description);
            }
        }

   


        static void Main(string[] args)
        {
            var credential = GoogleCredential.FromFile("C:\\Users\\frede\\Desktop\\Private projects\\ImageRecognition\\My First Project-873f16711d42.json");
            // Instantiates a client
            
            //var client = ImageAnnotatorClient.Create(credential);
            // Load the image file into memory
            var image = Image.FromFile("wakeupcat.jpg");
            // Performs label detection on the image file
            var response = client.DetectLabels(image);
            foreach (var annotation in response)
            {
                if (annotation.Description != null)
                    Console.WriteLine(annotation.Description);
            }
            string value = Environment.GetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS");
            runner("C:\\Users\\frede\\source\\repos\\ImageRecognition\\Resources\\TextTests.png");
        }
    }
}
