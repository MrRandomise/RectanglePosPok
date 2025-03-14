using Newtonsoft.Json;
using System.Drawing;

namespace DrawJson
{
    public partial class Form1 : Form
    {
        private DrawAndMoveRec Draw;
        private Image image;
        private ResizeImage Resize;
        private List<ObjectRectangle> rectangles = new List<ObjectRectangle>();
        private ObjectRectangle rectangle;
        private bool activeDraw = false;
        private DirectoryInfo screenDir;
        private FileInfo[] screen;
        private int pictureIndex = -1;
        private WorkFromFile workFile;
        private int layer = 999;
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            Draw = new DrawAndMoveRec();
            Resize = new ResizeImage();
            workFile = new WorkFromFile();
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            screenDir = new DirectoryInfo(@"C:\Users\Dmitry\Desktop\DataSet\Table");
            screen = screenDir.GetFiles("*.png", SearchOption.AllDirectories);
            NextPicture(1);
            pictureBox1.Refresh();
        }

        private void AddPlayerRectangles_MouseClick(object sender, MouseEventArgs e)
        {
            var rec = new ObjectRectangle(image.Width / 2, image.Height / 2, 50, 50, layer);
            layer--;
            rectangles.Add(rec);
            UpdatePicture();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            var offset = new Point(e.X, e.Y);
            int layer = 99999999;
            foreach (var rec in rectangles)
            {
                if (rec.Click(offset, layer))
                {
                    rectangle = rec;
                    layer = rectangle.Layer;
                    rectangle.Active = true;
                    activeDraw = true;
                }
            }
            if(rectangle != null)
            {
                UpdatePicture();
                UpdatePos();
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (activeDraw)
            {
                rectangle.Move(e.X, e.Y);
                Preview();
                UpdatePicture();
                UpdatePos();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (activeDraw)
            {
                activeDraw = false;
                rectangle.Active = false;
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
                var img = Resize.ResizeBitmap(Image.FromFile(screen[pictureIndex].FullName), 970, 700);
                pictureBox1.Image = img;
                image = pictureBox1.Image;
                UpdatePicture();
            }
        }

        private void UpdatePos()
        {
            textBox1.Text = rectangle.PosX.ToString();
            textBox2.Text = rectangle.PosY.ToString();
            textBox3.Text = rectangle.Width.ToString();
            textBox4.Text = rectangle.Heigth.ToString();
            textBox9.Text = rectangle.Name;
        }

        private void UpdatePicture()
        {
            pictureBox1.Image = Draw.RePaintRectangle(image, rectangles);
            pictureBox1.Refresh();
        }

        private void SaveSetting_Click(object sender, EventArgs e)
        {
            //var objectInfo = new ObjectInfo(MaxPlayers.Text, screen[pictureIndex].FullName);

            //var data = new JsonData(objectInfo, panelsObject.Players);

            string jsonString = JsonConvert.SerializeObject(rectangles);
            workFile.SaveToFile(@"C:\Users\Dmitry\Desktop\DataSet\", jsonString, MaxPlayers.Text);
        }

        private void MaxPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            rectangles.Clear();
            rectangle = null;
            var file = @"C:\Users\Dmitry\Desktop\DataSet\" + MaxPlayers.Text + "Max.json";
            if (File.Exists(file))
            {
                rectangles = workFile.LoadFromFile(file);
                layer = rectangles[rectangles.Count - 1].Layer;
                UpdatePicture();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (rectangle != null)
            {
                rectangle.Width = int.Parse(textBox3.Text);
                rectangle.ReSize();
                UpdatePicture();
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (rectangle != null)
            {
                rectangle.Heigth = int.Parse(textBox4.Text);
                rectangle.ReSize();
                UpdatePicture();
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (rectangle != null)
            {
                rectangle.Name = textBox9.Text;
            }
        }

        private void DeletePlayer_Click(object sender, EventArgs e)
        {
            rectangles.Remove(rectangle);
            rectangle = null;
            UpdatePicture();
        }
    }
}
