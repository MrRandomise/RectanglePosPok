namespace DrawJson
{
    public class PanelsObject
    {
        private const int maxPanel = 8;
        public int activePanelCount = -1;
        public List<Panel> PlayerPanel = new List<Panel>();
        public List<ObjectRectangle> objRectangle = new List<ObjectRectangle>();
        public List<Players> Players = new List<Players>();

        public void AddPanel(Panel mainPanel)
        {
            for (int i = 1; i < maxPanel; i++)
            {
                Panel panel = new Panel();
                panel = CloneObject.Clone(PlayerPanel[0]);
                panel.Name = "Player" + (i + 1).ToString();
                panel.Location = new Point(PlayerPanel[0].Location.X, PlayerPanel[0].Height * i + 100);
                mainPanel.Controls.Add(panel);
                for (int j = 0; j < PlayerPanel[0].Controls.Count; j++)
                {
                    Control cnt = PlayerPanel[0].Controls[j];
                    TextBox textField = cnt as TextBox;
                    Label labelField = cnt as Label;
                    Button button = cnt as Button;
                    if (textField != null)
                    {
                        var txt = new TextBox();
                        txt = CloneObject.Clone(textField);
                        panel.Controls.Add(txt);
                    }
                    if (labelField != null)
                    {
                        var label = new Label();
                        label = CloneObject.Clone(labelField);
                        panel.Controls.Add(label);
                    }
                    if (button != null)
                    {
                        var btn = new Button();
                        btn = CloneObject.Clone(button);
                        panel.Controls.Add(btn);
                    }
                }
                panel.Visible = false;
                PlayerPanel.Add(panel);
            }
        }

        public void GetAllTextFieldPlayer(Panel panel, Action updatePic, Image image)
        {
            int j = 0;
            TextBox posX = null;
            TextBox posY = null;
            TextBox width = null;
            TextBox heigth = null;
            TextBox name = null;
            Button button = null;
            bool firstIter = true;
            int k = 0;
            var players = new Players();
            players.Name = (Players.Count + 1).ToString();
            for (int i = panel.Controls.Count - 1; i >= 0; i--)
            {
                Control cnt = panel.Controls[i];
                TextBox tb = cnt as TextBox;
                Button btn = cnt as Button;

                if (tb != null && tb.Tag != "NotIterration")
                {
                    j++;
                    if (j == 1)
                    {
                        if (tb.Text == "0" || tb.Text == "")
                        {
                            tb.Text = (image.Width / 2).ToString();
                        }
                        posX = tb;
                        posX.TextChanged += (s, e) =>
                        {
                            ChangePos(s, e, updatePic);
                        };
                    }
                    if (j == 2)
                    {
                        if (tb.Text == "0" || tb.Text == "")
                        {
                            tb.Text = (image.Height / 2).ToString();
                        }
                        posY = tb;
                        posY.TextChanged += (s, e) =>
                        {
                            ChangePos(s, e, updatePic);
                        };
                    }
                    if (j == 3)
                    {
                        width = tb;
                        width.TextChanged += (s, e) =>
                        {
                            ChangeSize(s, e, updatePic);
                        };
                    }
                    if (firstIter && j == 4)
                    {
                        heigth = tb;
                        heigth.TextChanged += (s, e) =>
                        {
                            ChangeSize(s, e, updatePic);
                        };
                        firstIter = false;
                        name = new TextBox();
                        j = 0;
                    }
                    if (!firstIter && j == 4)
                    {
                        heigth = tb;
                        heigth.TextChanged += (s, e) =>
                        {
                            ChangeSize(s, e, updatePic);
                        };
                    }
                    if (!firstIter && j == 5)
                    {
                        name = tb;
                        j = 0;
                    }
                }

                if (posX != null && posY != null && width != null && heigth != null && name != null)
                {
                    k++;
                    var data = new ObjectRectangle(posX, posY, width, heigth, i, name);
                    var player = new Player(posX, posY, width, heigth, name);
                    objRectangle.Add(data);
                    
                    if(k == 1)
                    {
                        players.PositionPlayer = player;
                    }
                    if (k == 2)
                    {
                        players.PositionNickName = player;
                    }
                    if (k == 3)
                    {
                        players.PositionBlinds = player;
                    }
                    if (k == 4)
                    {
                        players.PositionCard1 = player;
                    }
                    if (k == 5)
                    {
                        players.PositionCard2 = player;
                    }
                    if (k == 6)
                    {
                        players.PositionBet = player;
                    }
                    if (k == 7)
                    {
                        players.PositionDealer = player;
                        Players.Add(players);
                    }
                    posX = null;
                    posY = null;
                    width = null;
                    heigth = null;
                    button = null;
                    name = null;
                }

                if (btn != null)
                {
                    button = btn;
                    button.Click += (s, e) =>
                    {
                        ClickDeletePlayer(activePanelCount, panel, updatePic);
                    };
                }
            }
        }

        private void ChangeSize(object sender, EventArgs e, Action updatePic)
        {
            TextBox tb = sender as TextBox;
            if (tb.Text.Length <= 1 || tb.Text == "" || tb.Text == " ")
            {
                tb.Text = "0";
            }
            foreach (var rec in objRectangle)
            {
                rec.ReSize();
            }
            updatePic();
        }

        private void ClickDeletePlayer(int index, Panel panel, Action updatePic)
        {
            if (activePanelCount > -1)
            {
                activePanelCount--;
                panel.Visible = false;
                try
                {
                    index += 1;
                    objRectangle.RemoveRange(index * 7 - 7, 7);
                    Players.RemoveAt(index);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                updatePic();
            }
        }

        private void ChangePos(object sender, EventArgs e, Action updatePic)
        {
            TextBox tb = sender as TextBox;
            if (tb.Text.Length <= 1 || tb.Text == "" || tb.Text == " ")
            {
                tb.Text = "0";
            }
            foreach (var rec in objRectangle)
            {
                rec.RePosition();
            }
            updatePic();
        }

        public void ShowPanel(Action updatePic, Image image)
        {
            if (activePanelCount < maxPanel)
            {
                activePanelCount++;
                PlayerPanel[activePanelCount].Visible = true;
                GetAllTextFieldPlayer(PlayerPanel[activePanelCount], updatePic, image);
            }
        }
    }
}
