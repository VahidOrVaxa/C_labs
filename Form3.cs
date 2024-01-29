using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter
{
    public partial class Form3 : Form
    {
        Form1 form;
        public Form3(Form1 form)
        {
            this.form = form;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;

            label2.Text = "Метр в секунду: " + Convert.ToString(Math.Round(Convert.ToDouble(text) / 3.6, 4));
            label3.Text = "Морской узел: " + Convert.ToString(Math.Round(Convert.ToDouble(text) / 1.852, 4));
            label4.Text = "Миля в час: " + Convert.ToString(Math.Round(Convert.ToDouble(text) / 1.609, 4));
            label5.Text = "Фут в секунду: " + Convert.ToString(Math.Round(Convert.ToDouble(text) / 1.098, 4));

            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                button2_Click(sender, e);
            }
            else if ((e.KeyChar == 13) && textBox1.Text.Length > 0)
            {
                button1_Click(sender, e);
            }
            else if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
