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

namespace QuanLyThuVien_Demo
{
    public partial class frmDangKy : Form
    {
        static string startupPath = Application.StartupPath;

        SqlConnection conn;
        SqlCommand cmd;
        String str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + startupPath + @"\QuanLyThuVien.mdf;Integrated Security=True;Connect Timeout=30";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        public frmDangKy()
        {
            InitializeComponent();
        }
        private void frmDangKy_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from TaiKhoan";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogup_Click(object sender, EventArgs e)
        {

            if (txtTenDangNhap.Text == "" || txtMatKhau.Text == "" || txtMatKhau1.Text == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin!", "Thông báo");
                txtTenDangNhap.Focus();
            }
            else
            {
                if(txtMatKhau.Text != txtMatKhau1.Text)
                {
                    MessageBox.Show("Mật khẩu bạn nhập không giống nhau!", "Thông báo");
                }
                else
                {
                    int count = 0;
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        if (table.Rows[i][0].ToString() == txtTenDangNhap.Text)
                        {
                            count++;
                            break;
                        }
                    }
                    if (count == 0)
                    {
                        cmd = conn.CreateCommand();
                        cmd.CommandText = "insert into TaiKhoan values ('" + txtTenDangNhap.Text + "', '" + txtMatKhau.Text + "')";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Bạn đã đăng ký thành công!","Thông báo");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản đã tồn tại!");
                        txtTenDangNhap.Focus();
                    }
                }
            }
        }

    }
}
