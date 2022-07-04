using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp3_Khanhpg_IT17330
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void nutchay_Click(object sender, EventArgs e)
        {
            if (text_Nhap.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập số muốn chọn");
            }
            else
            {
                Random rnd = new Random();
                lb_bs1.Text = rnd.Next(10, 99) + "";// Tạo và sét cấc giá trị ngẫu nhiên
                lb_bs2.Text = rnd.Next(10, 99) + "";
                lb_bs3.Text = rnd.Next(10, 99) + "";
                lb_bs4.Text = rnd.Next(10, 99) + "";
            }

            List<string> list = new List<string>();
            list.Add(lb_bs1.Text);list.Add(lb_bs2.Text);list.Add(lb_bs3.Text);list.Add(lb_bs4.Text);
            string[] arr = text_Nhap.Text.Split('-');
            foreach (var x in arr)
            {
                if (list.IndexOf(x) != -1)
                {
                    MessageBox.Show("Chúc mừng bạn đã chiến thắng với bộ số " + x);
                    lb_tien.Text = Convert.ToInt32(lb_tien.Text) * 2 + "";
                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
