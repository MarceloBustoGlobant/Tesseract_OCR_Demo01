using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Tesseract_OCR_Demo01
{
	public class MemoryImage
    {
		// Install-Package System.Drawing.Common

		//public string ImageToBase64(dynamic image, dynamic format)
		public string ImageToBase64(string img, dynamic format)
		{

			Image image = Image.FromFile(img);

			using (MemoryStream ms = new MemoryStream())
			{
				// Convert Image to byte[]
				//image.Save(ms, image.RawFormat);

				image.Save(ms, format);
				byte[] imageBytes = ms.ToArray();

				// Convert byte[] to Base64 String
				string base64String = Convert.ToBase64String(imageBytes);
				return base64String;
			}
		}

		/// base64 To Image
		public Image Base64ToImage(string base64String)
		{
			// Convert Base64 String to byte[]

			try
			{
				byte[] imageBytes = Convert.FromBase64String(base64String);

				using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
				{

					// Convert byte[] to Image
					ms.Write(imageBytes, 0, imageBytes.Length);
					Image image = Image.FromStream(ms, true);

					image.Save(FilesDirectory.OutputDirectory + "demo.jpeg", ImageFormat.Jpeg);
					// return FilesDirectory.NewName;

					return image;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error Inesperado: " + ex.Message);
				Console.WriteLine("Detalles: ");
				Console.WriteLine(ex.ToString());
				throw;
			}


		}

	}
}
