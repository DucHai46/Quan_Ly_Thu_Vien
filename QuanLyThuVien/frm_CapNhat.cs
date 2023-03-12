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

            /*frm_CapNhatLoaiSach frmCapNhatLoaiSach = new frm_CapNhatLoaiSach();
            frmCapNhatLoaiSach.TopLevel = false;
            pnlLoaiSach.Controls.Add(frmCapNhatLoaiSach);
            frmCapNhatLoaiSach.FormBorderStyle= FormBorderStyle.None;
            frmCapNhatLoaiSach.Dock = DockStyle.Fill;
            frmCapNhatLoaiSach.Show();
            btnCapNhatLoaiSach.BackColor = Color.White;
            btnCapNhatSach.BackColor = Color.FromArgb(224,224,224);*/
            pnlCapNhatSach.Visible = false;
            pnlLoaiSach.Visible = true;
            btnCapNhatLoaiSach.BackColor = Color.White;
            btnCapNhatSach.BackColor = Color.FromArgb(224, 224, 224);

        }

        private void frm_CapNhat_Load(object sender, EventArgs e)
        {
            frm_CapNhatLoaiSach frmCapNhatLoaiSach = new frm_CapNhatLoaiSach();
            frmCapNhatLoaiSach.TopLevel = false;
            pnlLoaiSach.Controls.Add(frmCapNhatLoaiSach);
            frmCapNhatLoaiSach.FormBorderStyle = FormBorderStyle.None;
            frmCapNhatLoaiSach.Dock = DockStyle.Fill;
            frmCapNhatLoaiSach.Show();
            btnCapNhatLoaiSach.BackColor = Color.White;

            frm_CapNhatSach frmCapNhatSach = new frm_CapNhatSach();
            frmCapNhatSach.TopLevel = false;
            pnlCapNhatSach.Controls.Add(frmCapNhatSach);
            frmCapNhatSach.FormBorderStyle = FormBorderStyle.None;
            frmCapNhatSach.Dock = DockStyle.Fill;
            frmCapNhatSach.Show();
            btnCapNhatSach.BackColor = Color.White;

            pnlCapNhatSach.Visible = false;
            pnlLoaiSach.Visible = true;
            btnCapNhatLoaiSach.BackColor = Color.White;
            btnCapNhatSach.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void btnCapNhatSach_Click(object sender, EventArgs e)
        {
            /* frm_CapNhatSach frmCapNhatSach = new frm_CapNhatSach();
             frmCapNhatSach.TopLevel = false;
             pnlCapNhatSach.Controls.Add(frmCapNhatSach);
             frmCapNhatSach.FormBorderStyle = FormBorderStyle.None;
             frmCapNhatSach.Dock = DockStyle.Fill;
             frmCapNhatSach.Show();
             btnCapNhatSach.BackColor = Color.White;
             btnCapNhatLoaiSach.BackColor = Color.FromArgb(224, 224, 224);*/
            pnlCapNhatSach.Visible = true;
            pnlLoaiSach.Visible = false;
            btnCapNhatSach.BackColor = Color.White;
            btnCapNhatLoaiSach.BackColor = Color.FromArgb(224, 224, 224);
        }
    }
}
