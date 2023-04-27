using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        static string startupPath = Application.StartupPath;

        SqlConnection conn;
        SqlCommand cmd;
        String str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + startupPath + @"\QuanLyThuVien.mdf;Integrated Security=True;Connect Timeout=30";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public void ThongTinDangNhap()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from TaiKhoan";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
        }
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();
            ThongTinDangNhap();
        }


        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if(txtTenDangNhap.Text == "" || txtMatKhau.Text == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin!", "Thông báo");
                txtTenDangNhap.Focus();
            }
            else
            {
                int count = 0;
                for(int i = 0; i < table.Rows.Count; i++)
                {
                    if(txtTenDangNhap.Text == table.Rows[i]["TaiKhoan"].ToString() &&
                        txtMatKhau.Text == table.Rows[i]["MatKhau"].ToString())
                    {
                        this.Text = "Danh Mục";
                        panel1.Controls.Clear();
                        frm_DanhMuc Danhmuc = new frm_DanhMuc();
                        Danhmuc.TopLevel = false;
                        panel1.Controls.Add(Danhmuc);
                        Danhmuc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                        Danhmuc.Dock = DockStyle.Fill;
                        Danhmuc.Show();
                        count = 1;
                        break;
                    }
                }
                if(count == 0)
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu của bạn đã sai!", "Thông báo");
                    txtTenDangNhap.Focus();
                }
            }
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

        private void lblDangKy_Click(object sender, EventArgs e)
        {

        }

        private void lblQuenMk_Click(object sender, EventArgs e)
        {

        }
    }
}
