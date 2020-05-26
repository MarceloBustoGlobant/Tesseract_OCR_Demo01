﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tesseract_OCR_Demo01
{
    public static class FilesDirectory
    {

        private const string _RootDirectory = @"..\..\..\..\..\Tesseract_OCR_Demo01\Tesseract_OCR_Demo01\";
        private const string _FilesDirectoryImages = _RootDirectory + @"Images\";
        private const string _ScriptsDirectory = _RootDirectory + @"Scripts\";

        //data:image/jpeg;base64,
        
        ////doc
        //string imgTxtEng = "phototest.tif";
        //string imgTxtSpa = "spa.jpg";

        //// No PDF's
        //string imgSpaPdf = "textoSpaDemo1.pdf";

        ////formatos
        //string imgSpaDNIjpg = "dni-2.jpg";
        //string imgSpaDNIpng = "dni-1.png";
        //string imgSpaDNIjpegWTP_UP = "myDNI_up.jpeg";
        //string imgSpaDNIjpegWTP = "myDNI_.jpeg";
  
        
        public static string rootDirectory 
        { 
            get
            {
                return _RootDirectory;
            }
        }
        public static string OutputDirectory
        {
            get
            {
                return _RootDirectory + @"Output\";
            }
        }

        public static string ImageDirectory
        {
            get
            {
                return _FilesDirectoryImages + @"Images\";
            }
        }

        /// <summary>
        ///  2170x1556
        ///  96 dpi
        /// </summary>
        public static string myDniLow
        {
            get
            {
                return _FilesDirectoryImages + "dni-low.jpeg";
            }
        }

        /// <summary>
        ///  2170x1556
        ///  96 dpi
        /// </summary>
        public static string DemoBase64
        {
            get
            {               
                return _FilesDirectoryImages + "demo.jpeg";
            }
        }

        /// <summary>
        ///  4000x2250
        ///  ?? dpi
        /// </summary>
        public static string myDni
        {
            get
            {
                return _FilesDirectoryImages + "myDNI_.jpeg";
            }
        }

        public static string ColorGrey
        {
            get
            {
                return _FilesDirectoryImages + "colorGray.jpg";
            }
        }

        public static string Threshold
        {
            get
            {
                return _FilesDirectoryImages + "Threshold.jpg";
            }
        }

        // Return string de mi doc hard code
        public static string myDniBase64
        {
            get
            {
                return dniBase64;
            }
        }

    }
}