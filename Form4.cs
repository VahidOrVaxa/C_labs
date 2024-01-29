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
    public partial class Form4 : Form
    {
        Form1 form;
        public Form4(Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;

            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;

            label2.Text = "USD: " + Convert.ToString(Math.Round(Convert.ToDouble(text) / 17.2360, 4));
            label3.Text = "EUR: " + Convert.ToString(Math.Round(Convert.ToDouble(text) / 20.9444, 4));
            label4.Text = "UAH: " + Convert.ToString(Math.Round(Convert.ToDouble(text) / 0.6147, 4));
            label5.Text = "RON: " + Convert.ToString(Math.Round(Convert.ToDouble(text) / 4.2994, 4));
            label6.Text = "RUB: " + Convert.ToString(Math.Round(Convert.ToDouble(text) / 0.2326, 4));
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
