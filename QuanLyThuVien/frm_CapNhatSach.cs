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
    public partial class frm_CapNhatSach : Form
    {
        public frm_CapNhatSach()
        {
            InitializeComponent();
        }
        public void KhoiTaoLsv_DanhSachCacLoaiSach()
        {
            lsvCacLoaiSach.Columns.Add("Mã Sách", 120);
            lsvCacLoaiSach.Columns.Add("Tên Sách", 200);
            lsvCacLoaiSach.Columns.Add("Mã Loại Sách", 120);
            lsvCacLoaiSach.Columns.Add("Số Lượng", 100);
            lsvCacLoaiSach.Columns.Add("Mã Tác Giả", 120);
            lsvCacLoaiSach.View = View.Details;
        }

        private void frm_CapNhatSach_Load(object sender, EventArgs e)
        {
            KhoiTaoLsv_DanhSachCacLoaiSach();
        }
    }
}
