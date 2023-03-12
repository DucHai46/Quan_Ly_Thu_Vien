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
    public partial class frm_CapNhat : Form
    {
        public frm_CapNhat()
        {
            InitializeComponent();
        }

        private void btnCapNhatLoaiSach_Click(object sender, EventArgs e)
        {
            frm_CapNhatLoaiSach frmCapNhatLoaiSach = new frm_CapNhatLoaiSach();
            frmCapNhatLoaiSach.TopLevel = false;
            pnlLoaiSach.Controls.Add(frmCapNhatLoaiSach);
            frmCapNhatLoaiSach.FormBorderStyle= FormBorderStyle.None;
            frmCapNhatLoaiSach.Dock = DockStyle.Fill;
            frmCapNhatLoaiSach.Show();
            pnlSach.Visible = false;
        }
    }
}
