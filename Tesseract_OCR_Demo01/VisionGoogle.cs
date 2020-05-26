using Google.Cloud.Vision.V1;
using System;


namespace Tesseract_OCR_Demo01
{
    class VisionGoogle
    {
        /// <summary>
        /// Google Cloud Vision.
        /// Install-Package Google.Cloud.Vision.V1 -Pre
        /// gratuito si se hacen menos de 1000 OCR por mes
        /// </summary>
        public void VisionGoogleOCRProcess()
        {
            // Load an image from a local file.
            var image = Image.FromFile(FilesDirectory.myDni);
            var client = ImageAnnotatorClient.Create();
            var response = client.DetectText(image);


            foreach (var annotation in response)
            {
                if (annotation.Description != null)
                    Console.WriteLine(annotation.Description);
            }

        }
    }
}
