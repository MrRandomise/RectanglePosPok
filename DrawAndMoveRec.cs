namespace DrawJson
{
    public class DrawAndMoveRec
    {
        public Bitmap RePaintRectangle(Image image, List<ObjectRectangle> rectangles)
        {
            // Создаем новый Bitmap для отрисовки
            var bitmapWithRectangle = new Bitmap(image.Width, image.Height);
            // Рисуем изображение
            using (Graphics g = Graphics.FromImage(bitmapWithRectangle))
            {
                // Рисуем исходное изображение
                g.DrawImage(image, 0, 0);
                // Рисуем прямоугольник
                using (Pen pen = new Pen(Color.Green, 3))
                {

                    foreach (var rect in rectangles)
                    {
                        if (rect.Active)
                        {
                            g.DrawRectangle(new Pen(Color.Red, 3), rect.Rectangle);
                        }
                        else
                        {
                            g.DrawRectangle(pen, rect.Rectangle);
                        }
                    }
                }
            }
            return bitmapWithRectangle;
        }
    }
}
