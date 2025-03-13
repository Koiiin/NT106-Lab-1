using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_bai1
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = Int32.Parse(textBox1.Text);
                int num2 = Int32.Parse(textBox2.Text);
                long sum = (long)num1 + (long)num2;
                textBox3.Text = sum.ToString();
            }
            catch
            {
                MessageBox.Show("Input integer please");
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = Int32.Parse(textBox1.Text);
                int num2 = Int32.Parse(textBox2.Text);
                long sub = (long)num1 - (long)num2;
                textBox3.Text = sub.ToString();
            }
            catch
            {
                MessageBox.Show("Input integer please");
            }
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = Int32.Parse(textBox1.Text);
                long mul = num1;
                int num2 = Int32.Parse(textBox2.Text);
                mul *= num2;
                textBox3.Text = mul.ToString();
            }
            catch
            {
                MessageBox.Show("Input integer please");
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = Int32.Parse(textBox1.Text);
                int num2 = Int32.Parse(textBox2.Text);
                if (num2 == 0)
                {
                    MessageBox.Show("Cannot divide by zero");
                }
                else
                {
                    double div = (double)num1 / (double)num2;
                    textBox3.Text = div.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Input integer please");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
