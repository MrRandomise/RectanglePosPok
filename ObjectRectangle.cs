namespace DrawJson
{
    public class ObjectRectangle
    {
        public TextBox PosX;
        public TextBox PosY;
        public TextBox Width;
        public TextBox Heigth;
        public TextBox Name;
        public bool Active = false;
        public Rectangle Rectangle;
        public int Layer;

        public ObjectRectangle(TextBox posX, TextBox posY, TextBox width, TextBox heigth, int layer, TextBox name)
        {
            Layer = layer;
            PosX = posX;
            PosY = posY;
            Width = width;
            Heigth = heigth;
            Name = name;
            Rectangle = new Rectangle(int.Parse(PosX.Text) - int.Parse(Width.Text) / 2, int.Parse(PosY.Text) - int.Parse(Heigth.Text) / 2, int.Parse(Width.Text), int.Parse(Heigth.Text));
        }

        public bool Click(Point point, int layer)
        {
            var X = int.Parse(PosX.Text) - int.Parse(Width.Text) / 2;
            var X1 = int.Parse(PosX.Text) + int.Parse(Width.Text) / 2;
            var Y = int.Parse(PosY.Text) - int.Parse(Heigth.Text) / 2;
            var Y1 = int.Parse(PosY.Text) + int.Parse(Heigth.Text) / 2;
            var active = false;
            if (point.X >= X && point.X <= X1 && point.Y >= Y && point.Y <= Y1)
            {
                if(layer > Layer)
                {
                    active = true;
                }
            }
            return active;
        }

        public void ReSize()
        {
            Rectangle.Width = int.Parse(Width.Text); 
            Rectangle.Height = int.Parse(Heigth.Text);
        }
        public void RePosition()
        {
            Rectangle.X = int.Parse(PosX.Text) - int.Parse(Width.Text) / 2;
            Rectangle.Y = int.Parse(PosY.Text) - int.Parse(Heigth.Text) / 2;
        }

        public void Move(int x, int y)
        {
            PosX.Text = x.ToString();
            PosY.Text = y.ToString();
            Rectangle.X = x - int.Parse(Width.Text) / 2;
            Rectangle.Y = y - int.Parse(Heigth.Text) / 2;
        }
    }
}
