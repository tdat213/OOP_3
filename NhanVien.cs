using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    internal class NhanVien : Nguoi
    {
        string mSNV;
        string luong;
        string chucVu;

        public string MSNV { get => mSNV; set => mSNV = value; }
        public string Luong { get => luong; set => luong = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }


        public NhanVien() : base() { }
        public NhanVien(string hoTen, string ngaySinh, string gioiTinh, string mSNV, string luong, string chucVu) : base(hoTen, ngaySinh, gioiTinh)
        {
            MSNV = mSNV;
            Luong = luong;
            ChucVu = chucVu;
        }

        
    }
}
