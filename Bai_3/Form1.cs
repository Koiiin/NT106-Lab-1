using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_3
{
    public partial class output: Form
    {
        public output()
        {
            InitializeComponent();
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            double num = 0;
            try { num = Double.Parse(input.Text); }
            catch (Exception) { MessageBox.Show("Invalid input"); return; }
            string result = ConvertNumberToWords(num);
            textBox1.Text = result;

        }

        private string ConvertNumberToWords(double number)
        {
            if (number == 0) return "không";

            string[] ones = { "", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] teens = { "mười", "mười một", "mười hai", "mười ba", "mười bốn", "mười lăm", "mười sáu", "mười bảy", "mười tám", "mười chín" };
            string[] tens = { "", "", "hai mươi", "ba mươi", "bốn mươi", "năm mươi", "sáu mươi", "bảy mươi", "tám mươi", "chín mươi" };
            string[] thousands = { "", "nghìn", "triệu", "tỷ" };

            if (number < 0)
            {
                return "âm " + ConvertNumberToWords(Math.Abs(number));
            }

            string words = "";
            int groupIndex = 0;

            while (number > 0)
            {
                int threeDigits = (int)(number % 1000);
                number /= 1000;

                if (threeDigits > 0)
                {
                    string groupWords = ConvertThreeDigitsToWords(threeDigits);
                    words = groupWords + " " + thousands[groupIndex] + " " + words;
                }

                groupIndex++;
            }

            return words.Trim();
        }

        private string ConvertThreeDigitsToWords(int number)
        {
            string[] ones = { "", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] teens = { "mười", "mười một", "mười hai", "mười ba", "mười bốn", "mười lăm", "mười sáu", "mười bảy", "mười tám", "mười chín" };
            string[] tens = { "", "", "hai mươi", "ba mươi", "bốn mươi", "năm mươi", "sáu mươi", "bảy mươi", "tám mươi", "chín mươi" };

            string words = "";

            int hundreds = number / 100;
            int remainder = number % 100;
            int tensDigit = remainder / 10;
            int onesDigit = remainder % 10;

            if (hundreds > 0)
            {
                words += ones[hundreds] + " trăm";
                if (remainder > 0)
                {
                    words += " ";
                }
            }

            if (tensDigit == 1)
            {
                words += teens[onesDigit];
            }
            else if (tensDigit > 1)
            {
                words += tens[tensDigit];
                if (onesDigit > 0)
                {
                    words += " " + ones[onesDigit];
                }
            }
            else if (onesDigit > 0)
            {
                words += ones[onesDigit];
            }

            return words.Trim();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            input.Text = "";
            textBox1.Text = "";
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
