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

        public void TabCreating(TabControl TabControl, string Text, Form Form, int Index)
        {
                TabControl.SelectedTab = TabControl.TabPages[Index];
                Form.TopLevel = false;
                Form.Parent = TabControl.TabPages[Index];
                Form.Dock = DockStyle.Fill;
                Form.FormBorderStyle = FormBorderStyle.None;
                Form.Show();
         
        }

        private void frm_CapNhat_Load(object sender, EventArgs e)
        {
            frm_CapNhatSach frmCapNhatSach = new frm_CapNhatSach();
            TabCreating(tctCapNhat, "Cập Nhật Sách", frmCapNhatSach, 1);
            frm_CapNhatLoaiSach frmCapNhatLoaiSach = new frm_CapNhatLoaiSach();
            TabCreating(tctCapNhat, "Cập Nhật Loại Sách", frmCapNhatLoaiSach, 0);
        }
    }
}
