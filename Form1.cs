using System.Windows.Forms;

namespace OOP_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<SinhVien> li_sv = new List<SinhVien>();
        List<NhanVien> li_nv = new List<NhanVien>();

        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            SinhVien sinhVien = new SinhVien(txtHoTenSV.Text, txtNgaySinhSV.Text, txtGioiTinhSV.Text, txtMSSV.Text, txtNganhHoc.Text, Convert.ToInt32(txtDiem.Text));
            li_sv.Add(sinhVien);
            dataGridViewSV.DataSource = null;
            dataGridViewSV.DataSource = li_sv;
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = new NhanVien(txtHoTenNV.Text, txtNgaySinhNV.Text, txtGioiTinhNV.Text, txtMSNV.Text, txtLuong.Text, txtChucVu.Text);
            li_nv.Add(nhanVien);
            dataGridViewNV.DataSource = null;
            dataGridViewNV.DataSource = li_nv;
        }
    }
}
