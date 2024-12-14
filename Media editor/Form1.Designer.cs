namespace Media_editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox_Main = new PictureBox();
            button_Open = new Button();
            comboBox1 = new ComboBox();
            button_Apply = new Button();
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            button_Open_Media = new Button();
            button_Load_Sound1 = new Button();
            button_Play = new Button();
            button_Play_both = new Button();
            button_Load_Sound2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Main).BeginInit();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_Main
            // 
            pictureBox_Main.Image = (Image)resources.GetObject("pictureBox_Main.Image");
            pictureBox_Main.Location = new Point(16, 184);
            pictureBox_Main.Name = "pictureBox_Main";
            pictureBox_Main.Size = new Size(305, 218);
            pictureBox_Main.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Main.TabIndex = 0;
            pictureBox_Main.TabStop = false;
            pictureBox_Main.Click += pictureBox_Main_Click;
            // 
            // button_Open
            // 
            button_Open.Location = new Point(16, 112);
            button_Open.Name = "button_Open";
            button_Open.Size = new Size(145, 42);
            button_Open.TabIndex = 1;
            button_Open.Text = "Open Photo";
            button_Open.UseVisualStyleBackColor = true;
            button_Open.Click += button_Open_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Black and White", "Sepia" });
            comboBox1.Location = new Point(16, 56);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(212, 38);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button_Apply
            // 
            button_Apply.Location = new Point(247, 56);
            button_Apply.Name = "button_Apply";
            button_Apply.Size = new Size(131, 40);
            button_Apply.TabIndex = 3;
            button_Apply.Text = "Apply";
            button_Apply.UseVisualStyleBackColor = true;
            button_Apply.Click += button_Apply_Click;
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(369, 184);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(387, 218);
            axWindowsMediaPlayer1.TabIndex = 4;
            // 
            // button_Open_Media
            // 
            button_Open_Media.Location = new Point(394, 13);
            button_Open_Media.Name = "button_Open_Media";
            button_Open_Media.Size = new Size(139, 38);
            button_Open_Media.TabIndex = 5;
            button_Open_Media.Text = "Open Media";
            button_Open_Media.UseVisualStyleBackColor = true;
            button_Open_Media.Click += button_Open_Media_Click;
            // 
            // button_Load_Sound1
            // 
            button_Load_Sound1.Location = new Point(394, 73);
            button_Load_Sound1.Name = "button_Load_Sound1";
            button_Load_Sound1.Size = new Size(139, 40);
            button_Load_Sound1.TabIndex = 6;
            button_Load_Sound1.Text = "Load Sound 1";
            button_Load_Sound1.UseVisualStyleBackColor = true;
            button_Load_Sound1.Click += button_Load_Sound_Click;
            // 
            // button_Play
            // 
            button_Play.Location = new Point(555, 73);
            button_Play.Name = "button_Play";
            button_Play.Size = new Size(139, 36);
            button_Play.TabIndex = 7;
            button_Play.Text = "Play Sound";
            button_Play.UseVisualStyleBackColor = true;
            button_Play.Click += button_Play_Click;
            // 
            // button_Play_both
            // 
            button_Play_both.Location = new Point(555, 127);
            button_Play_both.Name = "button_Play_both";
            button_Play_both.Size = new Size(139, 38);
            button_Play_both.TabIndex = 8;
            button_Play_both.Text = "Play Both";
            button_Play_both.UseVisualStyleBackColor = true;
            button_Play_both.Click += button_Play_both_Click;
            // 
            // button_Load_Sound2
            // 
            button_Load_Sound2.Location = new Point(394, 127);
            button_Load_Sound2.Name = "button_Load_Sound2";
            button_Load_Sound2.Size = new Size(139, 38);
            button_Load_Sound2.TabIndex = 9;
            button_Load_Sound2.Text = "Load Sound 2";
            button_Load_Sound2.UseVisualStyleBackColor = true;
            button_Load_Sound2.Click += button_Load_Sound2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_Load_Sound2);
            Controls.Add(button_Play_both);
            Controls.Add(button_Play);
            Controls.Add(button_Load_Sound1);
            Controls.Add(button_Open_Media);
            Controls.Add(axWindowsMediaPlayer1);
            Controls.Add(button_Apply);
            Controls.Add(comboBox1);
            Controls.Add(button_Open);
            Controls.Add(pictureBox_Main);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox_Main).EndInit();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox_Main;
        private Button button_Open;
        private ComboBox comboBox1;
        private Button button_Apply;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private Button button_Open_Media;
        private Button button_Load_Sound1;
        private Button button_Play;
        private Button button_Play_both;
        private Button button_Load_Sound2;
    }
}
