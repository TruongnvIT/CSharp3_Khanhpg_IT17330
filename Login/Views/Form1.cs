using Login.Models;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;

namespace Login
{
    [Serializable]
    public partial class Login1 : Form
    {
        private List<doiTuong> _dt = new List<doiTuong>();
        public Login1()
        {
            InitializeComponent();
        }
        private void bT_DN_Click(object sender, EventArgs e)
        {
            if (tB_tenDN1.Text.Trim() == "" || tB_matkhauDN1.Text.Trim() == "" )
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu");
            }
            else if (!cB_nguoimay.Checked)
            {
                MessageBox.Show("Bạn là người máy ư");
            }
            else
            {
                SignUp sign = new SignUp();
                bool a = sign.kiemTraDN(tB_tenDN1.Text, tB_matkhauDN1.Text);
                if (a == false)
                {
                    MessageBox.Show("Đăng nhập thất bại, kiểm tra lại tài khoản mật khẩu");
                }
                else
                {
                    MessageBox.Show("Đăng nhập thành công");
                    InFor inFor = new InFor(tB_tenDN1.Text);
                    inFor.ShowDialog();
                }

                //if (checkDN() == null)
                //{
                //    MessageBox.Show("Đăng nhập thất bại, kiểm tra lại tài khoản mật khẩu");
                //}
                //else
                //{
                //    MessageBox.Show("Đăng nhập thành công");
                //    InFor inFor = new InFor();
                //    inFor.ShowDialog();
                //}
            }
        }

        //doiTuong checkDN()
        //{
        //    SignUp sign = new SignUp();
        //    var x = _dt.FirstOrDefault(c => c.tenDN == "khanhpg" && c.matKhauDN == "1234");
        //    return x;
        //}
        private void lb_DK_MouseHover(object sender, EventArgs e)
        {
            lb_DK.ForeColor = Color.Blue;
        }
        private void lb_DK_MouseLeave(object sender, EventArgs e)
        {
            lb_DK.ForeColor = this.ForeColor;
        }
        private void lb_DK_Click(object sender, EventArgs e)
        {
            SignUp sign = new SignUp();
            sign.ShowDialog();
        }
        private void lB_quenMK_Click(object sender, EventArgs e)
        {
            Forgot fg = new Forgot();
            fg.ShowDialog();
        }
    }
}