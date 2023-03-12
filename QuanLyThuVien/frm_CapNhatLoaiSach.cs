using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class frm_CapNhatLoaiSach : Form
    {
        public frm_CapNhatLoaiSach()
        {
            InitializeComponent();
        }
        private void frm_CapNhatLoaiSach_Load(object sender, EventArgs e)
        {
            KhoiTaoLsv_DanhSachLoaiSach();
        }
        public void KhoiTaoLsv_DanhSachLoaiSach()
        {
            lsv_DanhSachLoaiSach.Columns.Add("Mã Loại Sách", 120);
            lsv_DanhSachLoaiSach.Columns.Add("Tên Loại Sách", 200);
            lsv_DanhSachLoaiSach.Columns.Add("Kiểu Sách", 450);

            lsv_DanhSachLoaiSach.View = View.Details;
        }

    }
}
