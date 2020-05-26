
using System;
using Tesseract;



namespace ClassLibrary
{
    public class Tesseract
    {
        private readonly string _imagen;
        
        public Tesseract(string image)
        {
            _imagen = image;
        }

        public string tesseractProcess()
        {
            string outPage = string.Empty;

            try
            {
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

                // Idioma Multi-Idioma
                //  using (var engine = new TesseractEngine(System.IO.Path.Combine(@"~/tessdata"), "spa", EngineMode.Default))
                //{
                //    // have to load Pix via a bitmap since Pix doesn't support loading a stream.
                //    using (var image = new System.Drawing.Bitmap(_imagen))
                //    {                       
                //        using (var pix = PixConverter.ToPix(image))
                //        {
                //            using (var page = engine.Process(pix))
                //            {
                //                outPage = page.GetText();
                //            }
                //        }
                //    }
                //}
            }
            catch (Exception ex)
            {
                // Error Retrun
                Console.WriteLine("Error Inesperado: " + ex.Message);
                Console.WriteLine("Detalles: ");
                Console.WriteLine(ex.ToString());

                outPage = string.Empty;
            }
            return outPage;
        }
    }
}
