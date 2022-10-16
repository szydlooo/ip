using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (numericUpDown1.Value <= 255 && numericUpDown2.Value <= 255 && numericUpDown3.Value <= 255 && numericUpDown4.Value <= 255)
            {
                status.Text = "poprawne";
                status.Visible = true;
            }
            else
                status.Text = "nie poprawne";
                status.Visible = true;
            if (numericUpDown1.Value <= 126)
            {
                label2.Text = "Klasa A";
                label2.Visible = true;
            }
            else if (numericUpDown1.Value < 192)
            {
                label2.Text = "Klasa B";
                label2.Visible = true;
            }
            else if (numericUpDown1.Value < 224)
            {
                label2.Text = "Klasa C";
                label2.Visible = true;
            }
            else if (numericUpDown1.Value < 240)
            {
                label2.Text = "Klasa D";
                label2.Visible = true;
            }
            else if (numericUpDown1.Value < 256)
            {
                label2.Text = "Klasa E";
                label2.Visible = true;
            }
        }





            private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
