using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class InFor : Form
    {
        private string _username;
        public InFor()
        {
            InitializeComponent();
            bool capnhat = cb_capnhat.Checked;
            tb_hoten.Enabled = capnhat;
            tb_diachi.Enabled = capnhat;
            tb_cancuoc.Enabled = capnhat;
            cbB_gioitinh.Enabled = capnhat;
            bt_chonanh.Enabled = capnhat;
            tbLoi();
        }

        public InFor(string uses)
        {
            InitializeComponent();
            bool capnhat = cb_capnhat.Checked;
            tb_hoten.Enabled = capnhat;
            tb_diachi.Enabled = capnhat;
            tb_cancuoc.Enabled = capnhat;
            cbB_gioitinh.Enabled = capnhat;
            bt_chonanh.Enabled = capnhat;
            tbLoi();
            _username = uses;
        }

        void tbLoi()
        {
            tb_loihoten.Visible = false;
            tb_loidiachi.Visible = false;
            tb_loicancuoc.Visible = false;
            tb_loigioitinh.Visible = false;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool capnhat = cb_capnhat.Checked;
            tb_hoten.Enabled = capnhat;
            tb_diachi.Enabled = capnhat;
            tb_cancuoc.Enabled = capnhat;
            cbB_gioitinh.Enabled = capnhat;
            bt_chonanh.Enabled = capnhat;
        }

        private void bt_dangky_Click(object sender, EventArgs e)
        {
            int _a = 0;
            if (tb_hoten.Text.Trim() == "")
            {
                tb_loihoten.Visible = true;
            }
            else
            {
                tb_loihoten.Visible = false;
                _a = _a + 1;
            }

            if (tb_diachi.Text.Trim() == "")
            {
                tb_loidiachi.Visible = true;
            }
            else
            {
                tb_loidiachi.Visible = false;
                _a = _a + 1;
            }

            if (tb_cancuoc.Text.Trim() == "")
            {
                tb_loicancuoc.Visible = true;
            }
            else
            {
                tb_loicancuoc.Visible = false;
                _a = _a + 1;
            }

            if (cbB_gioitinh.Text.Trim() == "")
            {
                tb_loigioitinh.Visible = true;
            }
            else
            {
                tb_loigioitinh.Visible = false;
                _a = _a + 1;
            }

            if (_a > 3)
            {
                MessageBox.Show("Cập nhật thành công");
                SignUp sign = new SignUp();
                sign.capNhat(_username,tb_hoten.Text, tb_diachi.Text, tb_cancuoc.Text, cbB_gioitinh.Text, dateTimePicker1.Value, ptB_avt.ImageLocation);
                this.Close();
            }
        }
        private void cbB_gioitinh_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void bt_chonanh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image file:| *.jpg; *.png; *.jpeg;...";
            ofd.ShowDialog();
            DialogResult result = MessageBox.Show("Bạn muốn đổi ảnh đại diện không ?", "Đổi ảnh đại diện",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                ptB_avt.Image = Image.FromFile(ofd.FileName);
            }
        }
    }
}
