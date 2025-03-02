using Newtonsoft.Json;


namespace DrawJson
{
    public partial class Form1 : Form
    {
        private DrawAndMoveRec Draw;
        private Image image;
        private ResizeImage Resize;
        private ObjectRectangle rectangle;
        private bool activeDraw = false;
        private DirectoryInfo screenDir;
        private FileInfo[] screen;
        private int pictureIndex = -1;
        private PanelsObject panelsObject;
        private WorkFromFile workFile;

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            Draw = new DrawAndMoveRec();
            Resize = new ResizeImage();
            panelsObject = new PanelsObject();
            workFile = new WorkFromFile();
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            panelsObject.PlayerPanel.Add(Player1);
            panelsObject.AddPanel(LeftTopPanel);
            Player1.Visible = false;
            screenDir = new DirectoryInfo(@"C:\Users\dmitr\Desktop\Poker\Data\");
            screen = screenDir.GetFiles("*.png", SearchOption.AllDirectories);
            NextPicture(1);
            pictureBox1.Refresh();
        }

        private void AddPlayerRectangles_MouseClick(object sender, MouseEventArgs e)
        {
            panelsObject.ShowPanel(UpdatePicture, pictureBox1.Image);
            UpdatePicture();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            var offset = new Point(e.X, e.Y);
            int layer = 99999999;
            foreach (var rec in panelsObject.objRectangle)
            {
                if (rec.Click(offset, layer))
                {
                    rectangle = rec;
                    layer = rectangle.Layer;
                }
            }
            if (rectangle != null)
            {
                rectangle.Active = true;
                activeDraw = true;
                UpdatePicture();
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (activeDraw)
            {
                rectangle.Move(e.X, e.Y);
                Preview();
                UpdatePicture();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (activeDraw)
            {
                activeDraw = false;
                rectangle.Active = false;
                rectangle = null;
                UpdatePicture();
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            NextPicture(1);
            if (pictureIndex == screen.Length)
            {
                Next.Enabled = false;
            }
            else
            {
                Next.Enabled = true;
            }
            Prev.Enabled = true;
            pictureBox1.Refresh();
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            NextPicture(-1);
            if (pictureIndex == 0)
            {
                Prev.Enabled = false;
            }
            else
            {
                Prev.Enabled = true;
            }
            Next.Enabled = true;
        }

        private void Preview()
        {
            using (Bitmap bmp = new Bitmap(pictureBox1.Image))
            {
                try
                {
                    var newImg = bmp.Clone(
                rectangle.Rectangle,
                bmp.PixelFormat);
                    pictureBox2.Image = newImg;
                }
                catch { }
            }
        }

        private void NextPicture(int index)
        {
            pictureIndex += index;
            if (pictureIndex <= screen.Length && pictureIndex >= 0)
            {
                Resize.ResizeBitmap(screen[pictureIndex].FullName, 970, 700);
                pictureBox1.Image = Image.FromFile(screen[pictureIndex].FullName);
                image = pictureBox1.Image;
                UpdatePicture();
            }
        }

        private void UpdatePicture()
        {
            pictureBox1.Image = Draw.RePaintRectangle(image, panelsObject.objRectangle);
            pictureBox1.Refresh();
        }

        private void SaveSetting_Click(object sender, EventArgs e)
        {
            var objectInfo = new ObjectInfo(MaxPlayers.Text, screen[pictureIndex].FullName);

            var data = new JsonData(objectInfo, panelsObject.Players);

           string jsonString = JsonConvert.SerializeObject(data);
           workFile.SaveToFile(@"C:\Users\dmitr\Desktop\Poker\config.json", jsonString);
        }
    }
}
