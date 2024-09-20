using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    internal class SinhVien : Nguoi
    {
        string mSSV;
        string nganhHoc;
        double dTB;

        public string MSSV { get => mSSV; set => mSSV = value; }
        public string NganhHoc { get => nganhHoc; set => nganhHoc = value; }
        public double DTB { get => dTB; set => dTB = value; }


        public SinhVien() : base() { }
        public SinhVien(string hoTen, string ngaySinh, string gioiTinh, string mSSV, string nganhHoc, double dTB) : base(hoTen, ngaySinh, gioiTinh)
        {
            MSSV = mSSV;
            NganhHoc = nganhHoc;
            DTB = dTB;
        }

    }

    
}
