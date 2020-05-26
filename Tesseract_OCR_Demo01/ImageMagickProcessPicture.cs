using ImageMagick;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tesseract_OCR_Demo01
{
    public  class ImageMagickProcessPicture
    {
        private readonly string _imagen;
        public ImageMagickProcessPicture(string image)
        {
           _imagen = image;
        }
    
        /// <summary>
        /// Normalice mgn.. there si to change the name
        /// Convert the image to B&W to get more contrast
        /// </summary>
        /// <returns></returns>
        public string ImageMagickthreshold()
        {
            // make TRY
            var _percentage = (Percentage)55;

            using (IMagickImage image = new MagickImage(_imagen))
            {

                image.Threshold(_percentage);

                //var startColor = MagickColor.FromRgb(60, 110, 150);
                //var stopColor = MagickColor.FromRgb(70, 120, 170);
                //image.ColorThreshold(startColor, stopColor);

                // To create de new image 
                // To use FilesDirectory class  <======
                image.Write(FilesDirectory.OutputDirectory + "Threshold.jpg");

                // return string with name; ponele....
                return FilesDirectory.OutputDirectory + "Threshold.jpg";
            }
        }

        public string ImageMagickBlackWhite()
        {

            using (IMagickImage image = new MagickImage(_imagen))
            {
                image.ColorSpace = ColorSpace.Gray;
                image.Write(FilesDirectory.OutputDirectory + "colorGray.jpg");

                return FilesDirectory.OutputDirectory + "colorGray.jpg";
            }
        }

        public string ImageInfo(string imagen)
        {
            using (IMagickImage image = new MagickImage(imagen))
            {
                return string.Format($"Image Info -> Density: {image.Density.ToString()}, Height: {image.Height.ToString() }, Width: {image.Width.ToString()}");
            }
        }
    }
}
