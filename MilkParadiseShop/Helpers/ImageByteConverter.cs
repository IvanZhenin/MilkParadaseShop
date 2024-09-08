#nullable disable
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using Microsoft.Win32;
using System.Windows;

namespace MilkParadiseShop.Helpers
{
    public static class ImageByteConverter
    {
        public static ImageSource ByteConvertToImageSource(byte[] data)
        {
            BitmapImage bitmapImage = new BitmapImage();
            using (MemoryStream memoryStream = new MemoryStream(data))
            {
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = memoryStream;
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.EndInit();
            }
            return bitmapImage;
        }
        public static byte[] ImageConvertToByte(BitmapImage image)
        {
            if (image == null)
                return null;

            byte[] data;
            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(image));
            using (MemoryStream ms = new MemoryStream())
            {
                encoder.Save(ms);
                data = ms.ToArray();
            }
            return data;
        }
        public static BitmapImage GetNewBitmapImage()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files | *.jpg; *.jpeg; *.png; *.bmp | All Files | *.*";

            try
            {
                if (openFileDialog.ShowDialog() == true)
                {
                    string selectedImagePath = openFileDialog.FileName;
                    BitmapImage bitmapImage = new BitmapImage(new Uri(selectedImagePath));
                    return bitmapImage;
                }
            }
            catch (System.NotSupportedException)
            {
                MessageBox.Show("Выбран неподходящий тип файла", "Ошибка");
            }

            return null;
        }
    }
}
