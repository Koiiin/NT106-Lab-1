using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab1_bai1;
using Bai_2;
using Bai_3;
using Lab1_bai4;
using Lab1_bai5;

namespace Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lab1_bai1.Form1 form1 = new Lab1_bai1.Form1();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Bai_3.output form3 = new Bai_3.output();
            form3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lab1_bai4.Form1 form4 = new Lab1_bai4.Form1();
            form4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Lab1_bai5.Form1 form5 = new Lab1_bai5.Form1();
            form5.Show();
        }

    }
}