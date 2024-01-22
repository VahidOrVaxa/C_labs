using System.Media;

namespace Водный_мир
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"..\..\..\image\shark.jpg");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"..\..\..\image\foreli.jpg");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"..\..\..\image\karas.jpg");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"..\..\..\image\osiminog.jpg");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"..\..\..\image\lobster.jpeg");
            SoundPlayer Player = new SoundPlayer(@"..\..\..\image\lobster.wav");
            Player.Play();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"..\..\..\image\scat.jpg");
        }

        private void label7_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"..\..\..\image\meduza.jpg");
        }

        private void label8_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"..\..\..\image\som.jpg");
        }

        private void label9_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"..\..\..\image\koni.jpg");
        }

        private void label10_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"..\..\..\image\kalmar.jpeg");
        }

        private void label11_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"..\..\..\image\kit.jpeg");
        }

        private void label12_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"..\..\..\image\delphin.jpg");
        }

        private void label13_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"..\..\..\image\kosatka.jpeg");
        }

        private void label15_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"..\..\..\image\seal.jpg");
        }

        private void label16_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
