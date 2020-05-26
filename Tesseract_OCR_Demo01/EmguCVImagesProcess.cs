using Emgu.CV;
using Emgu.CV.Util;
using Emgu.CV.Structure;


using System;

namespace Tesseract_OCR_Demo01
{
    public class EmguCVImagesProcess
    {
        Image<Bgr, Byte> source;

        //Reading image from file
        Emgu.CV.Image<Bgr, Byte> sourceHigh = new Emgu.CV.Image<Bgr, byte>(FilesDirectory.myDni);

        //Image<Gray, Byte> imgGray = sourceHigh.Convert<Gray, byte>();
        // Image<Gray, Byte> imgGray = sourceHigh.Convert<Gray, byte>().ThresholdBinary(new Gray(50), new Gray(2));

        Image<Bgr, Byte> sourceLow = new Image<Bgr, byte>(FilesDirectory.myDniLow);
        // CvInvoke.FindContours(sourceHigh);

        

    }
}