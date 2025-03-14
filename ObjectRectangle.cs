
namespace DrawJson
{
    public class ObjectRectangle
    {
        public int PosX;
        public int PosY;
        public int Width;
        public int Heigth;
        public string Name;
        public bool Active = false;
        public Rectangle Rectangle;
        public int Layer;

        public ObjectRectangle(int posX, int posY, int width, int heigth, int layer)
        {
            Layer = layer;
            PosX = posX;
            PosY = posY;
            Width = width;
            Heigth = heigth;
            NewRectangle();
        }

        public bool Click(Point point, int layer)
        {
            var X = PosX - Width / 2;
            var X1 = PosX + Width / 2;
            var Y = PosY - Heigth / 2;
            var Y1 = PosY + Heigth / 2;
            var active = false;
            if (point.X >= X && point.X <= X1 && point.Y >= Y && point.Y <= Y1)
            {
                if (layer > Layer)
                {
                    active = true;
                }
            }
            return active;
        }

        public void ReSize()
        {
            Rectangle.Width = Width; 
            Rectangle.Height = Heigth;
        }

        public void RePosition()
        {
            Rectangle.X = PosX;
            Rectangle.Y = PosY;

            //Rectangle.X = PosX - Width / 2;
            //Rectangle.Y = PosY - Heigth / 2;
        }

        public void Move(int x, int y)
        {
            PosX = x;
            PosY = y;
            Rectangle.X = x;
            Rectangle.Y = y;
        }

        public void NewRectangle()
        {
            Rectangle = new Rectangle(PosX, PosY, Width, Heigth);
        }
    }
}
