using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace QuanLyThuVien_Demo
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Text = "Danh Mục";
            panel1.Controls.Clear();
            frm_DanhMuc Danhmuc = new frm_DanhMuc();
            Danhmuc.TopLevel = false;
            panel1.Controls.Add(Danhmuc);
            Danhmuc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Danhmuc.Dock = DockStyle.Fill;
            Danhmuc.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblDangKy_MouseMove(object sender, MouseEventArgs e)
        {
            lblDangKy.ForeColor = Color.Black;
        }

        private void lblDangKy_MouseLeave(object sender, EventArgs e)
        {
            lblDangKy.ForeColor = Color.Blue;
        }

        private void lblQuenMk_MouseMove(object sender, MouseEventArgs e)
        {
            lblQuenMk.ForeColor = Color.Black;

        }

        private void lblQuenMk_MouseLeave(object sender, EventArgs e)
        {
            lblQuenMk.ForeColor = Color.Blue;
        }
    }
}
