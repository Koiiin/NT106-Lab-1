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
        private Lab1_bai1.Form1 form_bai_1;
        private Bai_2.Form1 form_bai_2;
        private Bai_3.output form_bai_3;
        private Lab1_bai4.Form1 form_bai_4;
        private Lab1_bai5.Form1 form_bai_5;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem form1 đã được mở chưa
            if (form_bai_1 == null || form_bai_1.IsDisposed)
            {
                form_bai_1 = new Lab1_bai1.Form1();
                form_bai_1.Show();
            }
            else
            {
                form_bai_1.BringToFront(); // Đưa form lên trước nếu đã mở
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (form_bai_2 == null || form_bai_2.IsDisposed)
            {
                form_bai_2 = new Bai_2.Form1();
                form_bai_2.Show();
            }
            else
            {
                form_bai_2.BringToFront();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (form_bai_3 == null || form_bai_3.IsDisposed)
            {
                form_bai_3 = new Bai_3.output();
                form_bai_3.Show();
            }
            else
            {
                form_bai_3.BringToFront();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (form_bai_4 == null || form_bai_4.IsDisposed)
            {
                form_bai_4 = new Lab1_bai4.Form1();
                form_bai_4.Show();
            }
            else
            {
                form_bai_4.BringToFront();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (form_bai_5 == null || form_bai_5.IsDisposed)
            {
                form_bai_5 = new Lab1_bai5.Form1();
                form_bai_5.Show();
            }
            else
            {
                form_bai_5.BringToFront();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}