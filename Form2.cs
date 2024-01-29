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
    public partial class Form2 : Form
    {
        Form1 form;
        public Form2(Form1 form)
        {
            this.form = form;
            InitializeComponent();
        }

        //private void Form2_Load(object sender, EventArgs e)
        //{

        //}



        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;

            label2.Text = "Американский фунт: " + Convert.ToString(Math.Round(Convert.ToDouble(text) / 0.45359237, 4));
            label3.Text = "Русский фунт: " + Convert.ToString(Math.Round(Convert.ToDouble(text) / 0.409120375, 4));
            label4.Text = "Русский пуд: " + Convert.ToString(Math.Round(Convert.ToDouble(text) / 16.3804815, 4));

            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
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
