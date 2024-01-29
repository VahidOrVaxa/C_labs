namespace Converter
{
    public partial class Form1 : Form
    {
        Point moveStart; // точка для перемещения

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.Aquamarine;
            Button button1 = new Button
            {
                Location = new Point
                {
                    X = this.Width / 2,
                    Y = this.Height / 2
                }
            };
            button1.Text = "Закрыть";
            button1.Click += button1_Click;
            this.Controls.Add(button1); // добавляем кнопку на форму
            this.Load += Form1_Load;
            this.MouseDown += Form1_MouseDown;
            this.MouseMove += Form1_MouseMove;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
            // создаем эллипс с высотой и шириной формы
            myPath.AddEllipse(0, 0, this.Width, this.Height);
            // создаем с помощью элипса ту область формы, которую мы хотим видеть
            Region myRegion = new Region(myPath);
            // устанавливаем видимую область
            this.Region = myRegion;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            // если нажата левая кнопка мыши
            if (e.Button == MouseButtons.Left)
            {
                moveStart = new Point(e.X, e.Y);
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            // если нажата левая кнопка мыши
            if ((e.Button & MouseButtons.Left) != 0)
            {
                // получаем новую точку положения формы
                Point deltaPos = new Point(e.X - moveStart.X, e.Y - moveStart.Y);
                // устанавливаем положение формы
                this.Location = new Point(this.Location.X + deltaPos.X,
                  this.Location.Y + deltaPos.Y);
            }
        }

        private void weightButton_Click(object sender, EventArgs e)
        {
            Form2 weightForm = new Form2(this);
            weightForm.Show();
            Hide();
        }

        private void speedButton_Click(object sender, EventArgs e)
        {
            Form3 speedForm = new Form3(this);
            speedForm.Show();
            Hide();
        }

        private void valueButton_Click(object sender, EventArgs e)
        {
            Form4 valueForm = new Form4(this);
            valueForm.Show();
            Hide();
        }
    }
}
