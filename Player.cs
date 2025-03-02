namespace DrawJson
{
    public class Player
    {
        public int PosX;
        public int PosY;
        public int Width;
        public int Heigth;
        public string Value;

        public Player(TextBox posX, TextBox posY, TextBox width, TextBox heigth, TextBox name)
        {
            PosX = int.Parse(posX.Text);
            PosY = int.Parse(posY.Text);
            Width = int.Parse(width.Text);
            Heigth = int.Parse(heigth.Text);
            Value = name.Text;
        }
    }
}
