using Login.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    [Serializable]
    public partial class SignUp : Form
    {
        private Stream _fs;
        private BinaryFormatter _bf;
        private List<doiTuong> _lsDoiTuongs = new List<doiTuong>();
        private doiTuong _doiTuong = new doiTuong();
        private string _path = @"C:\Users\ADMIN\OneDrive\Desktop\C#\C#3\CSharp3_Khanhpg_IT17330\Login\Views\XMLFile1.xml";

        public SignUp()
        {
            InitializeComponent();
            checkLoi();
        }
        void checkLoi()
        {
            tb_loihoten.Visible = false;
            tb_loidiachi.Visible = false;
            tb_loicancuoc.Visible = false;
            tb_loigioitinh.Visible = false;
            tb_loitenDN.Visible = false;
            tb_loimatkhau.Visible = false;
            tb_loinhaplaiMK.Visible = false;
            tb_loimkkhongchung.Visible = false;
        }
        private void bt_chonanh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image file:| *.jpg; *.png; *.jpeg;...";
            ofd.ShowDialog();
            DialogResult result = MessageBox.Show("Bạn muốn đổi ảnh đại diện không", "Đổi ảnh đại diện", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                ptB_avt.Image = Image.FromFile(ofd.FileName);
                ptB_avt.ImageLocation = ofd.FileName;//lưu đường dẫn ảnh
            }
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

            if (tb_tenDN.Text.Trim() == "")
            {
                tb_loitenDN.Visible = true;
            }
            else
            {
                tb_loitenDN.Visible = false;
                _a = _a + 1;
            }

            if (tb_matkhauDN.Text.Trim() == "")
            {
                tb_loimatkhau.Visible = true;
            }
            else
            {
                tb_loimatkhau.Visible = false;
                _a = _a + 1;
            }

            if (tb_nhaplaiMK.Text.Trim() == "")
            {
                tb_loinhaplaiMK.Visible = true;
            }
            else
            {
                tb_loinhaplaiMK.Visible = false;
                _a = _a + 1;
            }

            if (tb_matkhauDN.Text != tb_nhaplaiMK.Text)
            {
                tb_loimkkhongchung.Visible = true;
            }
            else
            {
                tb_loimkkhongchung.Visible = false;
                _a = _a + 1;
            }
            if (_a > 7)
            {
                bool dt = ktFile(_path);
                if (dt == false)
                {
                    MessageBox.Show("Bạn đã đăng ký thành công");
                    ReadFile();
                    themDt();
                    SaveFile();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Bạn đã đăng ký thành công");
                    themDt();
                    SaveFile();
                    this.Close();
                }
            }
        }

        void themDt()
        {
            _doiTuong.hoTen = tb_hoten.Text;
            _doiTuong.diaChi = tb_diachi.Text;
            _doiTuong.CCCD = tb_cancuoc.Text;
            _doiTuong.gioiTinh = cbB_gioitinh.Text;
            _doiTuong.tenDN = tb_tenDN.Text;
            _doiTuong.matKhauDN = tb_matkhauDN.Text;
            _doiTuong.ngaySinh = dateTimePicker1.Value;
            _doiTuong.pathImage = ptB_avt.ImageLocation;
            _lsDoiTuongs.Add(_doiTuong);
        }
        public bool kiemTraDN(string a, string b)
        {
            ReadFile();
            var n = _lsDoiTuongs.FirstOrDefault(c => c.tenDN == a && c.matKhauDN == b);
            if (n != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string laylaiMK(string a, string b)
        {
            ReadFile();
            var n = _lsDoiTuongs.FirstOrDefault(c => c.tenDN == a && c.CCCD == b);
            if (n == null)
            {
                return "Tải khoản không tồn tại";
            }
            else
            {
                return n.matKhauDN;
            }
        }

       
        public void capNhat(string name,string a, string b, string c, string d, DateTime e, string f)
        {
            ReadFile();
            var x = _lsDoiTuongs.FirstOrDefault(c => c.tenDN == name);
            x.hoTen = a;
            x.diaChi = b;
            x.CCCD = c;
            x.gioiTinh = d;
            x.ngaySinh = e;
            x.pathImage = f;
            SaveFile();
        }

        public bool ktFile(string fileName)
        {
            var info = new FileInfo(fileName);
            if (info.Length == 0)
            {
                return true;
            }
            if (info.Length < 8)
            {
                var content = File.ReadAllText(fileName);
                return content.Length == 0;
            }
            return false;
        }
        public void SaveFile()
        {
            _fs = new FileStream(_path, FileMode.Create);
            _bf = new BinaryFormatter();
            _bf.Serialize(_fs, _lsDoiTuongs);
            _fs.Close();
        }
        public void ReadFile()
        {
            _fs = new FileStream(_path, FileMode.Open);
            _bf = new BinaryFormatter();
            var data = _bf.Deserialize(_fs);
            _lsDoiTuongs = (List<doiTuong>)data;
            _fs.Close();
        }
        private void cb_hienmk_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_hienmk.Checked)
            {
                tb_matkhauDN.PasswordChar = '\0';
                tb_nhaplaiMK.PasswordChar = '\0';
            }
            else if (!cb_hienmk.Checked)
            {
                tb_matkhauDN.PasswordChar = '*';
                tb_nhaplaiMK.PasswordChar = '*';
            }
        }

        private void cbB_gioitinh_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
    }
}
