using ClassLibrary;
using NUnit.Framework;
using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace TesseractNTests
{
    [TestFixture]
    public class Tests
    {
        private const string _RootDirectory = @"..\..\..\..\..\Tesseract_OCR_Demo01\TesseractNTests\";
        private const string _FilesDirectoryImages = _RootDirectory + @"Images\";
        private const string TestImagePath = _FilesDirectoryImages + "phototest.tif";


        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void getDatosWithImage_tesseract_mayoracero()
        {
            //A
            string img = string.Empty;
            var tProces = new ClassLibrary.Tesseract(TestImagePath);

            //A
            string result = tProces.tesseractProcess();


            //A
            Assert.IsTrue(result.Length > 0);

        }

        [Test]
        public void getDatosWithOutImage_tesseract_ErrorEmptyResult()
        {
            //A
            string img = string.Empty;
            string TestImagePath = _FilesDirectoryImages + "phototest.XxX"; // Sin imagen

            var tProces = new ClassLibrary.Tesseract(TestImagePath);

            //A
            string result = tProces.tesseractProcess();


            //A
            Assert.IsTrue(result.Length <= 0);
        }

        /// <summary>
        /// Armar catch para captura de error
        /// </summary>

        [Test]
        public void getStringImage_Base64_ReturnMayorZero()
        {
            //A
            string result = string.Empty;
            var tProces = new Base64();

            //A
            result = tProces.ImageToBase64(TestImagePath, ImageFormat.Jpeg);

            //A
            Assert.IsTrue(result.Length > 0);
            //Assert.AreSame(result, @"^[a-zA-Z0-9\+/]*={0,3}$");
        }


        [Test]
        public void getStringNullImage_Base64_ReturnError()
        {
            //A
            string result = string.Empty;
            var tProces = new Base64();

            //A
            result = tProces.ImageToBase64(TestImagePath, ImageFormat.Jpeg);

            //A
            Assert.AreNotEqual(result.GetType(), typeof(Bitmap));

        }

        [Test]
        public void sendString_Base64_ReturnImage()
        {
            //A
            Image result;
            var tProces = new Base64();
            string imgBase64 = tProces.ImageToBase64(TestImagePath, ImageFormat.Jpeg);

            //A
            result = tProces.Base64ToImage(imgBase64, 0);   // ver el tema de ImageFormat.Jpeg

            //A
            Assert.AreEqual(result.GetType(), typeof(Bitmap));

        }
    }
}