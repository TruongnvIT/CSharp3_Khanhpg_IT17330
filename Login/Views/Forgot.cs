using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.Models;

namespace Login
{
    [Serializable]
    public partial class Forgot : Form
    {
        List<doiTuong> _lstDoiTuongs = new List<doiTuong>();
        public Forgot()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignUp sign = new SignUp();
            string tbmatKhau = sign.laylaiMK(tb_tenDN.Text, tb_cccd.Text);
            MessageBox.Show("Mật khẩu của bạn là: " + tbmatKhau);
        }
    }
}
