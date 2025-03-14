namespace DrawJson
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel5 = new Panel();
            Prev = new Button();
            SaveJson = new Button();
            Next = new Button();
            SaveSetting = new Button();
            LeftTopPanel = new Panel();
            Player1 = new Panel();
            DeletePlayer = new Button();
            textBox9 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label33 = new Label();
            label21 = new Label();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            ImageSize = new Label();
            AddPlayerRectangles = new Button();
            MaxPlayers = new ComboBox();
            drawAndMoveRecBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            LeftTopPanel.SuspendLayout();
            Player1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)drawAndMoveRecBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(508, -1);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.Yes;
            panel1.Size = new Size(974, 986);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(361, 756);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(266, 209);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(974, 750);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(LeftTopPanel);
            panel2.Location = new Point(0, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(508, 986);
            panel2.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(Prev);
            panel5.Controls.Add(SaveJson);
            panel5.Controls.Add(Next);
            panel5.Controls.Add(SaveSetting);
            panel5.Location = new Point(6, 881);
            panel5.Name = "panel5";
            panel5.Size = new Size(496, 103);
            panel5.TabIndex = 3;
            // 
            // Prev
            // 
            Prev.Enabled = false;
            Prev.Location = new Point(335, 16);
            Prev.Name = "Prev";
            Prev.Size = new Size(158, 37);
            Prev.TabIndex = 3;
            Prev.Text = "Prev";
            Prev.UseVisualStyleBackColor = true;
            Prev.Click += Prev_Click;
            // 
            // SaveJson
            // 
            SaveJson.Location = new Point(171, 59);
            SaveJson.Name = "SaveJson";
            SaveJson.Size = new Size(158, 37);
            SaveJson.TabIndex = 2;
            SaveJson.Text = "SaveJson";
            SaveJson.UseVisualStyleBackColor = true;
            // 
            // Next
            // 
            Next.Location = new Point(335, 59);
            Next.Name = "Next";
            Next.Size = new Size(158, 37);
            Next.TabIndex = 1;
            Next.Text = "Next";
            Next.UseVisualStyleBackColor = true;
            Next.Click += Next_Click;
            // 
            // SaveSetting
            // 
            SaveSetting.Location = new Point(8, 59);
            SaveSetting.Name = "SaveSetting";
            SaveSetting.Size = new Size(158, 37);
            SaveSetting.TabIndex = 0;
            SaveSetting.Text = "SaveSetting";
            SaveSetting.UseVisualStyleBackColor = true;
            SaveSetting.Click += SaveSetting_Click;
            // 
            // LeftTopPanel
            // 
            LeftTopPanel.AutoScroll = true;
            LeftTopPanel.Controls.Add(Player1);
            LeftTopPanel.Controls.Add(ImageSize);
            LeftTopPanel.Controls.Add(AddPlayerRectangles);
            LeftTopPanel.Controls.Add(MaxPlayers);
            LeftTopPanel.Location = new Point(3, 3);
            LeftTopPanel.Name = "LeftTopPanel";
            LeftTopPanel.Size = new Size(502, 861);
            LeftTopPanel.TabIndex = 2;
            // 
            // Player1
            // 
            Player1.Controls.Add(DeletePlayer);
            Player1.Controls.Add(textBox9);
            Player1.Controls.Add(textBox4);
            Player1.Controls.Add(textBox3);
            Player1.Controls.Add(textBox2);
            Player1.Controls.Add(textBox1);
            Player1.Controls.Add(label33);
            Player1.Controls.Add(label21);
            Player1.Controls.Add(label5);
            Player1.Controls.Add(label2);
            Player1.Controls.Add(label1);
            Player1.Location = new Point(3, 123);
            Player1.Name = "Player1";
            Player1.Size = new Size(493, 241);
            Player1.TabIndex = 6;
            Player1.Tag = "Itteration";
            // 
            // DeletePlayer
            // 
            DeletePlayer.Location = new Point(77, 146);
            DeletePlayer.Name = "DeletePlayer";
            DeletePlayer.Size = new Size(317, 32);
            DeletePlayer.TabIndex = 170;
            DeletePlayer.Text = "DeletePlayer";
            DeletePlayer.UseVisualStyleBackColor = true;
            DeletePlayer.Click += DeletePlayer_Click;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(77, 99);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(317, 23);
            textBox9.TabIndex = 144;
            textBox9.Tag = "";
            textBox9.TextChanged += textBox9_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(355, 55);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(39, 23);
            textBox4.TabIndex = 139;
            textBox4.Text = "50";
            textBox4.TextChanged += textBox4_TextChanged;
            textBox4.KeyPress += textBox4_KeyPress;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(301, 55);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(39, 23);
            textBox3.TabIndex = 138;
            textBox3.Text = "50";
            textBox3.TextChanged += textBox3_TextChanged;
            textBox3.KeyPress += textBox3_KeyPress;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(189, 55);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(101, 23);
            textBox2.TabIndex = 137;
            textBox2.Tag = "Itteration";
            textBox2.Text = "0";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(77, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(101, 23);
            textBox1.TabIndex = 136;
            textBox1.Tag = "Itteration";
            textBox1.Text = "0";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(355, 38);
            label33.Name = "label33";
            label33.Size = new Size(43, 15);
            label33.TabIndex = 123;
            label33.Tag = "NotIterration";
            label33.Text = "Heigth";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(301, 37);
            label21.Name = "label21";
            label21.Size = new Size(39, 15);
            label21.TabIndex = 109;
            label21.Tag = "NotIterration";
            label21.Text = "Width";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(77, 81);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 77;
            label5.Text = "Label";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(189, 37);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 71;
            label2.Tag = "NotIterration";
            label2.Text = "Pos Y";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 37);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 70;
            label1.Tag = "NotIterration";
            label1.Text = "Pos X";
            // 
            // ImageSize
            // 
            ImageSize.AutoSize = true;
            ImageSize.Location = new Point(193, 54);
            ImageSize.Name = "ImageSize";
            ImageSize.Size = new Size(63, 15);
            ImageSize.TabIndex = 5;
            ImageSize.Text = "ImageSize:";
            // 
            // AddPlayerRectangles
            // 
            AddPlayerRectangles.Location = new Point(9, 85);
            AddPlayerRectangles.Name = "AddPlayerRectangles";
            AddPlayerRectangles.Size = new Size(448, 23);
            AddPlayerRectangles.TabIndex = 4;
            AddPlayerRectangles.Text = "AddPlayerRectangles";
            AddPlayerRectangles.UseVisualStyleBackColor = true;
            AddPlayerRectangles.MouseClick += AddPlayerRectangles_MouseClick;
            // 
            // MaxPlayers
            // 
            MaxPlayers.BackColor = Color.WhiteSmoke;
            MaxPlayers.DisplayMember = "1";
            MaxPlayers.DropDownStyle = ComboBoxStyle.DropDownList;
            MaxPlayers.FormattingEnabled = true;
            MaxPlayers.Items.AddRange(new object[] { "2", "3", "5", "8", "9" });
            MaxPlayers.Location = new Point(9, 12);
            MaxPlayers.Name = "MaxPlayers";
            MaxPlayers.Size = new Size(448, 23);
            MaxPlayers.TabIndex = 3;
            MaxPlayers.ValueMember = "1";
            MaxPlayers.SelectedIndexChanged += MaxPlayers_SelectedIndexChanged;
            // 
            // drawAndMoveRecBindingSource
            // 
            drawAndMoveRecBindingSource.DataSource = typeof(DrawAndMoveRec);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1480, 988);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Shown += Form1_Shown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            LeftTopPanel.ResumeLayout(false);
            LeftTopPanel.PerformLayout();
            Player1.ResumeLayout(false);
            Player1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)drawAndMoveRecBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel LeftTopPanel;
        private ComboBox MaxPlayers;
        private Panel panel5;
        private Button SaveJson;
        private Button Next;
        private Button SaveSetting;
        private Label ImageSize;
        private Button AddPlayerRectangles;
        private BindingSource drawAndMoveRecBindingSource;
        private Panel Player1;
        private Label label33;
        private Label label21;
        private Label label5;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox9;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button Prev;
        private Button DeletePlayer;
    }
}
