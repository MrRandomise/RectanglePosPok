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
            textBox34 = new TextBox();
            textBox33 = new TextBox();
            textBox32 = new TextBox();
            textBox31 = new TextBox();
            textBox30 = new TextBox();
            textBox29 = new TextBox();
            textBox28 = new TextBox();
            textBox27 = new TextBox();
            textBox26 = new TextBox();
            textBox25 = new TextBox();
            textBox24 = new TextBox();
            textBox23 = new TextBox();
            textBox22 = new TextBox();
            textBox21 = new TextBox();
            textBox20 = new TextBox();
            textBox19 = new TextBox();
            textBox18 = new TextBox();
            textBox17 = new TextBox();
            textBox16 = new TextBox();
            textBox15 = new TextBox();
            textBox14 = new TextBox();
            textBox13 = new TextBox();
            textBox12 = new TextBox();
            textBox11 = new TextBox();
            textBox10 = new TextBox();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label34 = new Label();
            label28 = new Label();
            label29 = new Label();
            label30 = new Label();
            label31 = new Label();
            label32 = new Label();
            label33 = new Label();
            label27 = new Label();
            label26 = new Label();
            label25 = new Label();
            label24 = new Label();
            label23 = new Label();
            label22 = new Label();
            label21 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
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
            Player1.Controls.Add(textBox34);
            Player1.Controls.Add(textBox33);
            Player1.Controls.Add(textBox32);
            Player1.Controls.Add(textBox31);
            Player1.Controls.Add(textBox30);
            Player1.Controls.Add(textBox29);
            Player1.Controls.Add(textBox28);
            Player1.Controls.Add(textBox27);
            Player1.Controls.Add(textBox26);
            Player1.Controls.Add(textBox25);
            Player1.Controls.Add(textBox24);
            Player1.Controls.Add(textBox23);
            Player1.Controls.Add(textBox22);
            Player1.Controls.Add(textBox21);
            Player1.Controls.Add(textBox20);
            Player1.Controls.Add(textBox19);
            Player1.Controls.Add(textBox18);
            Player1.Controls.Add(textBox17);
            Player1.Controls.Add(textBox16);
            Player1.Controls.Add(textBox15);
            Player1.Controls.Add(textBox14);
            Player1.Controls.Add(textBox13);
            Player1.Controls.Add(textBox12);
            Player1.Controls.Add(textBox11);
            Player1.Controls.Add(textBox10);
            Player1.Controls.Add(textBox9);
            Player1.Controls.Add(textBox8);
            Player1.Controls.Add(textBox7);
            Player1.Controls.Add(textBox6);
            Player1.Controls.Add(textBox5);
            Player1.Controls.Add(textBox4);
            Player1.Controls.Add(textBox3);
            Player1.Controls.Add(textBox2);
            Player1.Controls.Add(textBox1);
            Player1.Controls.Add(label34);
            Player1.Controls.Add(label28);
            Player1.Controls.Add(label29);
            Player1.Controls.Add(label30);
            Player1.Controls.Add(label31);
            Player1.Controls.Add(label32);
            Player1.Controls.Add(label33);
            Player1.Controls.Add(label27);
            Player1.Controls.Add(label26);
            Player1.Controls.Add(label25);
            Player1.Controls.Add(label24);
            Player1.Controls.Add(label23);
            Player1.Controls.Add(label22);
            Player1.Controls.Add(label21);
            Player1.Controls.Add(label18);
            Player1.Controls.Add(label19);
            Player1.Controls.Add(label20);
            Player1.Controls.Add(label15);
            Player1.Controls.Add(label16);
            Player1.Controls.Add(label17);
            Player1.Controls.Add(label12);
            Player1.Controls.Add(label13);
            Player1.Controls.Add(label14);
            Player1.Controls.Add(label9);
            Player1.Controls.Add(label10);
            Player1.Controls.Add(label11);
            Player1.Controls.Add(label6);
            Player1.Controls.Add(label7);
            Player1.Controls.Add(label8);
            Player1.Controls.Add(label5);
            Player1.Controls.Add(label3);
            Player1.Controls.Add(label4);
            Player1.Controls.Add(label2);
            Player1.Controls.Add(label1);
            Player1.Location = new Point(3, 123);
            Player1.Name = "Player1";
            Player1.Size = new Size(454, 666);
            Player1.TabIndex = 6;
            Player1.Tag = "Itteration";
            // 
            // DeletePlayer
            // 
            DeletePlayer.Location = new Point(77, 621);
            DeletePlayer.Name = "DeletePlayer";
            DeletePlayer.Size = new Size(317, 32);
            DeletePlayer.TabIndex = 170;
            DeletePlayer.Text = "DeletePlayer";
            DeletePlayer.UseVisualStyleBackColor = true;
            // 
            // textBox34
            // 
            textBox34.Location = new Point(77, 582);
            textBox34.Name = "textBox34";
            textBox34.Size = new Size(317, 23);
            textBox34.TabIndex = 169;
            textBox34.Tag = "";
            // 
            // textBox33
            // 
            textBox33.Location = new Point(355, 539);
            textBox33.Name = "textBox33";
            textBox33.Size = new Size(39, 23);
            textBox33.TabIndex = 168;
            textBox33.Text = "50";
            // 
            // textBox32
            // 
            textBox32.Location = new Point(301, 538);
            textBox32.Name = "textBox32";
            textBox32.Size = new Size(39, 23);
            textBox32.TabIndex = 167;
            textBox32.Text = "50";
            // 
            // textBox31
            // 
            textBox31.Location = new Point(190, 538);
            textBox31.Name = "textBox31";
            textBox31.Size = new Size(101, 23);
            textBox31.TabIndex = 166;
            textBox31.Tag = "Itteration";
            textBox31.Text = "0";
            // 
            // textBox30
            // 
            textBox30.Location = new Point(77, 538);
            textBox30.Name = "textBox30";
            textBox30.Size = new Size(101, 23);
            textBox30.TabIndex = 165;
            textBox30.Tag = "Itteration";
            textBox30.Text = "0";
            // 
            // textBox29
            // 
            textBox29.Location = new Point(77, 495);
            textBox29.Name = "textBox29";
            textBox29.Size = new Size(317, 23);
            textBox29.TabIndex = 164;
            textBox29.Tag = "";
            // 
            // textBox28
            // 
            textBox28.Location = new Point(355, 450);
            textBox28.Name = "textBox28";
            textBox28.Size = new Size(39, 23);
            textBox28.TabIndex = 163;
            textBox28.Text = "20";
            // 
            // textBox27
            // 
            textBox27.Location = new Point(301, 450);
            textBox27.Name = "textBox27";
            textBox27.Size = new Size(39, 23);
            textBox27.TabIndex = 162;
            textBox27.Text = "60";
            // 
            // textBox26
            // 
            textBox26.Location = new Point(189, 450);
            textBox26.Name = "textBox26";
            textBox26.Size = new Size(101, 23);
            textBox26.TabIndex = 161;
            textBox26.Tag = "Itteration";
            textBox26.Text = "0";
            // 
            // textBox25
            // 
            textBox25.Location = new Point(77, 450);
            textBox25.Name = "textBox25";
            textBox25.Size = new Size(101, 23);
            textBox25.TabIndex = 160;
            textBox25.Tag = "Itteration";
            textBox25.Text = "0";
            // 
            // textBox24
            // 
            textBox24.Location = new Point(77, 406);
            textBox24.Name = "textBox24";
            textBox24.Size = new Size(317, 23);
            textBox24.TabIndex = 159;
            textBox24.Tag = "";
            // 
            // textBox23
            // 
            textBox23.Location = new Point(355, 362);
            textBox23.Name = "textBox23";
            textBox23.Size = new Size(39, 23);
            textBox23.TabIndex = 158;
            textBox23.Text = "90";
            // 
            // textBox22
            // 
            textBox22.Location = new Point(301, 362);
            textBox22.Name = "textBox22";
            textBox22.Size = new Size(39, 23);
            textBox22.TabIndex = 157;
            textBox22.Text = "70";
            // 
            // textBox21
            // 
            textBox21.Location = new Point(189, 362);
            textBox21.Name = "textBox21";
            textBox21.Size = new Size(101, 23);
            textBox21.TabIndex = 156;
            textBox21.Tag = "Itteration";
            textBox21.Text = "0";
            // 
            // textBox20
            // 
            textBox20.Location = new Point(77, 362);
            textBox20.Name = "textBox20";
            textBox20.Size = new Size(101, 23);
            textBox20.TabIndex = 155;
            textBox20.Tag = "Itteration";
            textBox20.Text = "0";
            // 
            // textBox19
            // 
            textBox19.Location = new Point(77, 318);
            textBox19.Name = "textBox19";
            textBox19.Size = new Size(317, 23);
            textBox19.TabIndex = 154;
            textBox19.Tag = "";
            // 
            // textBox18
            // 
            textBox18.Location = new Point(355, 273);
            textBox18.Name = "textBox18";
            textBox18.Size = new Size(39, 23);
            textBox18.TabIndex = 153;
            textBox18.Text = "90";
            // 
            // textBox17
            // 
            textBox17.Location = new Point(301, 273);
            textBox17.Name = "textBox17";
            textBox17.Size = new Size(39, 23);
            textBox17.TabIndex = 152;
            textBox17.Text = "70";
            // 
            // textBox16
            // 
            textBox16.Location = new Point(189, 274);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(101, 23);
            textBox16.TabIndex = 151;
            textBox16.Tag = "Itteration";
            textBox16.Text = "0";
            // 
            // textBox15
            // 
            textBox15.Location = new Point(77, 274);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(101, 23);
            textBox15.TabIndex = 150;
            textBox15.Tag = "Itteration";
            textBox15.Text = "0";
            // 
            // textBox14
            // 
            textBox14.Location = new Point(77, 230);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(317, 23);
            textBox14.TabIndex = 149;
            textBox14.Tag = "";
            // 
            // textBox13
            // 
            textBox13.Location = new Point(355, 186);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(39, 23);
            textBox13.TabIndex = 148;
            textBox13.Text = "50";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(301, 186);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(39, 23);
            textBox12.TabIndex = 147;
            textBox12.Text = "100";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(189, 186);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(101, 23);
            textBox11.TabIndex = 146;
            textBox11.Tag = "Itteration";
            textBox11.Text = "0";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(77, 186);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(101, 23);
            textBox10.TabIndex = 145;
            textBox10.Tag = "Itteration";
            textBox10.Text = "0";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(77, 142);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(317, 23);
            textBox9.TabIndex = 144;
            textBox9.Tag = "";
            textBox9.Text = "123";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(355, 98);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(39, 23);
            textBox8.TabIndex = 143;
            textBox8.Text = "50";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(301, 98);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(39, 23);
            textBox7.TabIndex = 142;
            textBox7.Text = "100";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(189, 98);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(101, 23);
            textBox6.TabIndex = 141;
            textBox6.Tag = "Itteration";
            textBox6.Text = "0";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(77, 98);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(101, 23);
            textBox5.TabIndex = 140;
            textBox5.Tag = "Itteration";
            textBox5.Text = "0";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(355, 55);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(39, 23);
            textBox4.TabIndex = 139;
            textBox4.Text = "200";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(301, 55);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(39, 23);
            textBox3.TabIndex = 138;
            textBox3.Text = "400";
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
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(355, 79);
            label34.Name = "label34";
            label34.Size = new Size(43, 15);
            label34.TabIndex = 135;
            label34.Tag = "NotIterration";
            label34.Text = "Heigth";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(355, 521);
            label28.Name = "label28";
            label28.Size = new Size(43, 15);
            label28.TabIndex = 134;
            label28.Tag = "NotIterration";
            label28.Text = "Heigth";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(355, 432);
            label29.Name = "label29";
            label29.Size = new Size(43, 15);
            label29.TabIndex = 132;
            label29.Tag = "NotIterration";
            label29.Text = "Heigth";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(355, 344);
            label30.Name = "label30";
            label30.Size = new Size(43, 15);
            label30.TabIndex = 130;
            label30.Tag = "NotIterration";
            label30.Text = "Heigth";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(355, 256);
            label31.Name = "label31";
            label31.Size = new Size(43, 15);
            label31.TabIndex = 128;
            label31.Tag = "NotIterration";
            label31.Text = "Heigth";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(355, 169);
            label32.Name = "label32";
            label32.Size = new Size(43, 15);
            label32.TabIndex = 126;
            label32.Tag = "NotIterration";
            label32.Text = "Heigth";
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
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(301, 520);
            label27.Name = "label27";
            label27.Size = new Size(39, 15);
            label27.TabIndex = 121;
            label27.Tag = "NotIterration";
            label27.Text = "Width";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(301, 431);
            label26.Name = "label26";
            label26.Size = new Size(39, 15);
            label26.TabIndex = 119;
            label26.Tag = "NotIterration";
            label26.Text = "Width";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(301, 343);
            label25.Name = "label25";
            label25.Size = new Size(39, 15);
            label25.TabIndex = 117;
            label25.Tag = "NotIterration";
            label25.Text = "Width";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(301, 255);
            label24.Name = "label24";
            label24.Size = new Size(39, 15);
            label24.TabIndex = 115;
            label24.Tag = "NotIterration";
            label24.Text = "Width";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(301, 168);
            label23.Name = "label23";
            label23.Size = new Size(39, 15);
            label23.TabIndex = 113;
            label23.Tag = "NotIterration";
            label23.Text = "Width";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(301, 79);
            label22.Name = "label22";
            label22.Size = new Size(39, 15);
            label22.TabIndex = 111;
            label22.Tag = "NotIterration";
            label22.Text = "Width";
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
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(73, 564);
            label18.Name = "label18";
            label18.Size = new Size(75, 15);
            label18.TabIndex = 107;
            label18.Text = "Player Dealer";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(189, 520);
            label19.Name = "label19";
            label19.Size = new Size(107, 15);
            label19.TabIndex = 105;
            label19.Tag = "NotIterration";
            label19.Text = "Pos Player Dealer Y";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(77, 520);
            label20.Name = "label20";
            label20.Size = new Size(107, 15);
            label20.TabIndex = 104;
            label20.Tag = "NotIterration";
            label20.Text = "Pos Player Dealer X";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(73, 476);
            label15.Name = "label15";
            label15.Size = new Size(59, 15);
            label15.TabIndex = 101;
            label15.Text = "Player Bet";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(189, 432);
            label16.Name = "label16";
            label16.Size = new Size(91, 15);
            label16.TabIndex = 99;
            label16.Tag = "NotIterration";
            label16.Text = "Pos Player Bet Y";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(77, 432);
            label17.Name = "label17";
            label17.Size = new Size(91, 15);
            label17.TabIndex = 98;
            label17.Tag = "NotIterration";
            label17.Text = "Pos Player Bet X";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(73, 388);
            label12.Name = "label12";
            label12.Size = new Size(41, 15);
            label12.TabIndex = 95;
            label12.Text = "Card 2";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(189, 344);
            label13.Name = "label13";
            label13.Size = new Size(105, 15);
            label13.TabIndex = 93;
            label13.Tag = "NotIterration";
            label13.Text = "Pos Player Card2 Y";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(77, 344);
            label14.Name = "label14";
            label14.Size = new Size(105, 15);
            label14.TabIndex = 92;
            label14.Tag = "NotIterration";
            label14.Text = "Pos Player Card2 X";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(73, 300);
            label9.Name = "label9";
            label9.Size = new Size(41, 15);
            label9.TabIndex = 89;
            label9.Text = "Card 1";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(189, 256);
            label10.Name = "label10";
            label10.Size = new Size(105, 15);
            label10.TabIndex = 87;
            label10.Tag = "NotIterration";
            label10.Text = "Pos Player Card1 Y";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(77, 256);
            label11.Name = "label11";
            label11.Size = new Size(105, 15);
            label11.TabIndex = 86;
            label11.Tag = "NotIterration";
            label11.Text = "Pos Player Card1 X";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(73, 212);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 83;
            label6.Text = "Player Blind";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(189, 168);
            label7.Name = "label7";
            label7.Size = new Size(101, 15);
            label7.TabIndex = 81;
            label7.Tag = "NotIterration";
            label7.Text = "Pos Player Blind Y";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(77, 168);
            label8.Name = "label8";
            label8.Size = new Size(101, 15);
            label8.TabIndex = 80;
            label8.Tag = "NotIterration";
            label8.Text = "Pos Player Blind X";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(73, 124);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 77;
            label5.Text = "Player Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(189, 80);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 75;
            label3.Tag = "NotIterration";
            label3.Text = "Pos Player Name Y";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 80);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 74;
            label4.Tag = "NotIterration";
            label4.Text = "Pos Player Name X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(189, 37);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 71;
            label2.Tag = "NotIterration";
            label2.Text = "Pos Player Y";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 37);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 70;
            label1.Tag = "NotIterration";
            label1.Text = "Pos Player X";
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
        private Label label34;
        private Label label28;
        private Label label29;
        private Label label30;
        private Label label31;
        private Label label32;
        private Label label33;
        private Label label27;
        private Label label26;
        private Label label25;
        private Label label24;
        private Label label23;
        private Label label22;
        private Label label21;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label5;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox34;
        private TextBox textBox33;
        private TextBox textBox32;
        private TextBox textBox31;
        private TextBox textBox30;
        private TextBox textBox29;
        private TextBox textBox28;
        private TextBox textBox27;
        private TextBox textBox26;
        private TextBox textBox25;
        private TextBox textBox24;
        private TextBox textBox23;
        private TextBox textBox22;
        private TextBox textBox21;
        private TextBox textBox20;
        private TextBox textBox19;
        private TextBox textBox18;
        private TextBox textBox17;
        private TextBox textBox16;
        private TextBox textBox15;
        private TextBox textBox14;
        private TextBox textBox13;
        private TextBox textBox12;
        private TextBox textBox11;
        private TextBox textBox10;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button DeletePlayer;
        private Button Prev;
    }
}
