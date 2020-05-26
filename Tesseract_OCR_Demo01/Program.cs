using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace Tesseract_OCR_Demo01
{
    class Program
    {
        static void Main(string[] args)
        {

            string outPage = string.Empty;
            string imgBase64 = string.Empty;

            string imgThresold = string.Empty;
            string imgBN = string.Empty;

            Image BaseToimage;

            Console.WriteLine();

            var visionGoogle = new VisionGoogle();
            visionGoogle.VisionGoogleOCRProcess();


            #region BASE64

            // Response Image Base 64 - metodo para convertir en imagen y post-procesar
            var b64 = new MemoryImage();
            imgBase64 = b64.ImageToBase64(FilesDirectory.myDni, ImageFormat.Jpeg);

            // Crear imagen to string 
            BaseToimage = b64.Base64ToImage(imgBase64);

#endregion

#region IMAGEPROCESS

            var ingProcess = new ImageMagickProcessPicture(FilesDirectory.myDni);

            imgThresold = ingProcess.ImageMagickthreshold();
            imgBN = ingProcess.ImageMagickBlackWhite();

#endregion

#region OCR

            var tesseractDemo = new tesseract_pagochat(FilesDirectory.rootDirectory, FilesDirectory.ColorGrey);
            outPage  = tesseractDemo.tesseractProcess();

#endregion
            
            Console.WriteLine(ingProcess.ImageInfo(FilesDirectory.ColorGrey));
            Console.WriteLine(outPage);
            Console.ReadKey();
        }
    }
}
