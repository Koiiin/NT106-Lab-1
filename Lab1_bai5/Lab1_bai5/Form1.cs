using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Lab1_bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void result_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(input.Text, @"^[0-9. ]+$"))
            {
                MessageBox.Show($"Invalid input: Must be a list of valid number separated by space.");
                return;
            }
            string[] parts = input.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            double[] listPoint = new double[parts.Length];

            for (int i = 0; i < parts.Length; i++)
            {
                if (!double.TryParse(parts[i], out listPoint[i]) || listPoint[i] < 0 || listPoint[i] > 10)
                {
                    MessageBox.Show($"Invalid input: Must be in range [0, 10].", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            double max = listPoint.Max();
            double min = listPoint.Min();
            double avg = listPoint.Average();
            int count_pass = listPoint.Count(x => x >= 5);

            string rank = "";
            rank =  avg >= 8 && min >= 6.5 ? "Giỏi" : 
                    avg >= 6.5 && min >= 5 ? "Khá" : 
                    avg >= 5 && min >= 3.5 ? "TB" : 
                    avg >= 3.5 && min >= 2 ? "Yếu" : 
                    "Kém";

            // Xóa dữ liệu cũ trong ListView
            listView1.Items.Clear();

            // Thêm danh sách môn học vào ListView
            for (int i = 0; i < listPoint.Length; i++)
            {
                ListViewItem item = new ListViewItem($"Môn {i + 1}: {listPoint[i]}");
                listView1.Items.Add(item);
            }

            max_out.Text = $"Điểm cao nhất: {max}";
            min_out.Text = $"Điểm thấp nhất: {min}";
            average_out.Text = $"Điểm trung bình: {avg:F2}";
            pass_out.Text = $"Số môn đậu: {count_pass}";
            not_pass_out.Text = $"Số môn không đậu: {listPoint.Length - count_pass}";
            rank_out.Text = $"Xếp loại: {rank}";
        }


    }
}
