using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Models
{
    [Serializable]
    internal class doiTuong
    {
        public string hoTen { get; set; }
        public string diaChi { get; set; }
        public string CCCD { get; set; }
        public string gioiTinh { get; set; }
        public string tenDN { get; set; }
        public string matKhauDN { get; set; }
        public DateTime ngaySinh { get; set; }
        public string pathImage { get; set; }
        public doiTuong()
        {

        }
        public doiTuong(string hoTen, string diaChi, string cccd, string gioiTinh, string tenDn, string matKhauDn, DateTime ngaySinh, string pathImage)
        {
            this.hoTen = hoTen;
            this.diaChi = diaChi;
            CCCD = cccd;
            this.gioiTinh = gioiTinh;
            tenDN = tenDn;
            matKhauDN = matKhauDn;
            this.ngaySinh = ngaySinh;
            this.pathImage = pathImage;
        }
    }

}
