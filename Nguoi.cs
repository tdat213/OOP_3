using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    internal class Nguoi
    {
        public string hoTen;
        public string ngaySinh;
        public string gioiTinh;

        public string HoTen { get => hoTen; set => hoTen = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }

        public Nguoi() { }
        public Nguoi(string hoTen, string ngaySinh, string gioiTinh)
        {
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            GioiTinh=gioiTinh;
        }
    }
}
