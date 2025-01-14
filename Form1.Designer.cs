namespace PoScSe
{
    partial class MainForm
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
            SaveDirField = new TextBox();
            SaveDirLabel = new Label();
            NumButton = new RadioButton();
            DateButton = new RadioButton();
            SaveConfig = new Button();
            SuspendLayout();
            // 
            // SaveDirField
            // 
            SaveDirField.Location = new Point(14, 45);
            SaveDirField.Name = "SaveDirField";
            SaveDirField.Size = new Size(438, 23);
            SaveDirField.TabIndex = 0;
            SaveDirField.Text = "C:\\Users\\Dmitry\\Desktop\\DataSet\\Table";
            SaveDirField.TextChanged += SaveDirField_TextChanged;
            // 
            // SaveDirLabel
            // 
            SaveDirLabel.AutoSize = true;
            SaveDirLabel.Location = new Point(15, 24);
            SaveDirLabel.Name = "SaveDirLabel";
            SaveDirLabel.Size = new Size(101, 15);
            SaveDirLabel.TabIndex = 1;
            SaveDirLabel.Text = "Путь сохранения";
            // 
            // NumButton
            // 
            NumButton.AutoSize = true;
            NumButton.BackgroundImageLayout = ImageLayout.None;
            NumButton.Location = new Point(123, 105);
            NumButton.Name = "NumButton";
            NumButton.Size = new Size(88, 19);
            NumButton.TabIndex = 2;
            NumButton.TabStop = true;
            NumButton.Text = "Нумерация";
            NumButton.UseVisualStyleBackColor = true;
            NumButton.MouseCaptureChanged += NumButton_MouseCaptureChanged;
            // 
            // DateButton
            // 
            DateButton.AutoSize = true;
            DateButton.Location = new Point(238, 105);
            DateButton.Name = "DateButton";
            DateButton.Size = new Size(120, 19);
            DateButton.TabIndex = 3;
            DateButton.TabStop = true;
            DateButton.Text = "Название по дате";
            DateButton.UseVisualStyleBackColor = true;
            DateButton.MouseCaptureChanged += DateButton_MouseCaptureChanged;
            // 
            // SaveConfig
            // 
            SaveConfig.Location = new Point(87, 153);
            SaveConfig.Name = "SaveConfig";
            SaveConfig.Size = new Size(280, 38);
            SaveConfig.TabIndex = 4;
            SaveConfig.Text = "Сохранить";
            SaveConfig.UseVisualStyleBackColor = true;
            SaveConfig.Click += SaveConfig_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 195);
            Controls.Add(SaveConfig);
            Controls.Add(DateButton);
            Controls.Add(NumButton);
            Controls.Add(SaveDirLabel);
            Controls.Add(SaveDirField);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Poker Screen Saver";
            FormClosed += MainForm_FormClosed;
            Load += MainForm_Load;
            Resize += MainForm_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label SaveDirLabel;
        private RadioButton NumButton;
        private RadioButton DateButton;
        public TextBox SaveDirField;
        private Button SaveConfig;
    }
}
