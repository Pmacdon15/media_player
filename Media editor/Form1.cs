using NAudio.Wave;
using System.CodeDom.Compiler;
using System.Media;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Media_editor
{
    public partial class Form1 : Form
    {
        Image img;
        SoundPlayer player;
        string Path;

        private WaveStream Audio1;
        private WaveStream Audio2;
        private WaveOut AudioOut1;
        private WaveOut AudioOut2;
        private string AudioPath1;
        private string AudioPath2;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox_Main_Click(object sender, EventArgs e)
        {
            Image temp = pictureBox_Main.Image;
            temp.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox_Main.Image = temp;
        }

        private void button_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                img = Image.FromFile(dialog.FileName);
                pictureBox_Main.Image = img;
            }
        }

        private void button_Apply_Click(object sender, EventArgs e)
        {
            Image temp = pictureBox_Main.Image;
            Bitmap bmp = new Bitmap(temp);
            string action = comboBox1.Text;
            int oRed, oGreen, oBlue;
            int eRed, eGreen, eBlue;

            if (action == "Black and White")
            {
                for (int i = 0; i < bmp.Width; i++)
                {
                    for (int j = 0; j < bmp.Height; j++)
                    {
                        Color color = bmp.GetPixel(i, j);
                        oRed = color.R;
                        oGreen = color.G;
                        oBlue = color.B;

                        eRed = Convert.ToInt32(0.3 * oRed + 0.7 * oGreen + 0.2 * oBlue);
                        eGreen = Convert.ToInt32(0.3 * oRed + 0.7 * oGreen + 0.2 * oBlue);
                        eBlue = Convert.ToInt32(0.3 * oRed + 0.7 * oGreen + 0.2 * oBlue);

                        if (eRed > 255) eRed = 255;
                        if (eGreen > 255) eGreen = 255;
                        if (eBlue > 255) eBlue = 255;

                        color = Color.FromArgb(eRed, eGreen, eBlue);
                        bmp.SetPixel(i, j, color);
                    }
                }
                pictureBox_Main.Image = bmp;
            }
            if (action == "Sepia")
            {
                for (int i = 0; i < bmp.Width; i++)
                {
                    for (int j = 0; j < bmp.Height; j++)
                    {
                        Color color = bmp.GetPixel(i, j);
                        oRed = color.R;
                        oGreen = color.G;
                        oBlue = color.B;

                        eRed = Convert.ToInt32(0.393 * oRed + 0.769 * oGreen + 0.189 * oBlue);
                        eGreen = Convert.ToInt32(0.349 * oRed + 0.686 * oGreen + 0.168 * oBlue);
                        eBlue = Convert.ToInt32(0.272 * oRed + 0.534 * oGreen + 0.131 * oBlue);

                        if (eRed > 255) eRed = 255;
                        if (eGreen > 255) eGreen = 255;
                        if (eBlue > 255) eBlue = 255;

                        color = Color.FromArgb(eRed, eGreen, eBlue);
                        bmp.SetPixel(i, j, color);
                    }
                }
                pictureBox_Main.Image = bmp;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_Open_Media_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Media Files|*.mp3;*.mp4;*.avi;*.mkv;*.mov";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = dialog.FileName;
                axWindowsMediaPlayer1.URL = filePath;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

      

        private void button_Play_Click(object sender, EventArgs e)
        {

            player = new SoundPlayer(Path);
            player.Play();
        }


        private void button_Load_Sound_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Sound Files|*.mp3;*.wav;*.ogg;*.flac";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                AudioPath1 = dialog.FileName;
                Path = AudioPath1; // Assign the path for the play button
                if (AudioPath1.EndsWith(".wav"))
                {
                    Audio1 = new WaveFileReader(AudioPath1);
                }
            }
        }

        private void button_Load_Sound2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Sound Files|*.mp3;*.wav;*.ogg;*.flac";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                AudioPath2 = dialog.FileName;
                if (AudioPath2.EndsWith(".wav"))
                {
                    Audio2 = new WaveFileReader(AudioPath2);
                }
            }
        }

        private void button_Play_both_Click(object sender, EventArgs e)
        {
            try
            {
                AudioOut1 = new WaveOut();
                AudioOut1.Init(Audio1);
                AudioOut2 = new WaveOut();
                AudioOut2.Init(Audio2);

                AudioOut1.Play();
                AudioOut2.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error playing sounds: " + ex.Message);
            }
        }
    }
}

