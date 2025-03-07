using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_bai4
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
 
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Enter_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(From_this.Text) || string.IsNullOrEmpty(To_that.Text))
            {
                MessageBox.Show("Vui lòng chọn cả định dạng cần chuyển đổi và định dạng đích!");
                return;
            }


            int number = 0;
            switch (From_this.Text)
            {
                case "Dec":
                    {
                        try { number = Int32.Parse(Number.Text); }
                        catch (Exception)
                        {
                            MessageBox.Show("Nhập sai định dạng Decimal");
                            return;
                        }
                        break;

                    }
                case "Bin":
                    {
                        try { number = Convert.ToInt32(Number.Text, 2); }
                        catch (Exception)
                        {
                            MessageBox.Show("Nhập sai định dạng Binary");
                            return;
                        }
                        break;
                    }
                case "Hex":
                    {
                        try { number = Convert.ToInt32(Number.Text, 16); }
                        catch (Exception)
                        {
                            MessageBox.Show("Nhập sai định dạng Hexadecimal");
                            return;
                        }
                        break;
                    }
            }

            switch (To_that.Text)
            {
                case "Dec":
                    {
                        Result_box.Text = Convert.ToString(number);
                        break;
                    }
                case "Bin":
                    {
                        Result_box.Text = Convert.ToString(number, 2);
                        break;
                    }
                case "Hex":
                    {
                        Result_box.Text = Convert.ToString(number, 16);
                        break;
                    }
            }
        }
    }
}
