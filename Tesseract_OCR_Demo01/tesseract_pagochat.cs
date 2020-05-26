using System;
using Tesseract;
using ImageMagick;
using System.IO;

namespace Tesseract_OCR_Demo01
{
    public class tesseract_pagochat
    {

        private string Image { get; set; }
        private string Path { get; set; }

        private readonly string _imagen;
        public tesseract_pagochat(string path, string image)
        {
            Image = image;
            Path = path;

            _imagen = image;
        }

        /// <summary>
        /// Read a picture and normalice (convert to B&W) the image before to read it
        /// </summary>
        /// <returns></returns>
        public string tesseractProcess()
        {
            string outPage = string.Empty;

            // Return new pic B&W
            //string newImage = tesseractNormalicedProcess() ?? _imagen;

            try
            {
                //using (var engine = new TesseractEngine(@"./tessdata", "spa_old", EngineMode.Default))
                using (var engine = new TesseractEngine(@"./tessdata", "spa", EngineMode.Default))
                {
                    //Pix.LoadFromMemory probar para wtp...
                    using (var img = Pix.LoadFromFile(_imagen))
                    {
                        using (var page = engine.Process(img))
                        {
                            outPage = page.GetText();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Inesperado: " + ex.Message);
                Console.WriteLine("Detalles: ");
                Console.WriteLine(ex.ToString());

                outPage = string.Empty;
            }
            return outPage;
        }

 

    }
}
