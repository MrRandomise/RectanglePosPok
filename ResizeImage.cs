using System.Drawing.Imaging;

namespace DrawJson
{
    internal class ResizeImage
    {
        public void ResizeBitmap(string File, int width, int height)
        {
            Bitmap bmp = new Bitmap(File);
            Bitmap bitmap = new Bitmap(width, height);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.DrawImage(bmp, 0, 0, width, height);
            }
            //bitmap.Save(File, ImageFormat.Jpeg);
        }
    }
}
