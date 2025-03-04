using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bai_2
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }



        private void btn_Search_Click(object sender, EventArgs e)
        {
            double num1 = 0, num2 = 0, num3 = 0;

            try { num1 = Double.Parse(inputNum1.Text); }
            catch
            {
                MessageBox.Show("Error Số thứ 1 phải là số nguyên");
            }

            try { num2 = Double.Parse(inputNum2.Text); }
            catch
            {
                MessageBox.Show("Error Số thứ 2 phải là số nguyên");
            }

            try { num3 = Double.Parse(inputNum3.Text); }
            catch
            {
                MessageBox.Show("Error Số thứ 3 phải là số nguyên");
            }

            double max = Math.Max(num1, Math.Max(num2, num3));
            double min = Math.Min(num1, Math.Min(num2, num3));

            result_max.Text = max.ToString();
            result_min.Text = min.ToString();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            result_max.Text = "";
            result_min.Text = "";
            inputNum1.Text = "";
            inputNum2.Text = "";
            inputNum3.Text = "";
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
