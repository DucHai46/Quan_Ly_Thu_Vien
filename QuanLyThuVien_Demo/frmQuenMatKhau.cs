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
    public partial class frmQuenMatKhau : Form
    {

        static string startupPath = Application.StartupPath;

        SqlConnection conn;
        SqlCommand cmd;
        String str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + startupPath + @"\QuanLyThuVien.mdf;Integrated Security=True;Connect Timeout=30";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        public frmQuenMatKhau()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMatKhau_Click(object sender, EventArgs e)
        {
            if(txtTenDangNhap.Text == "")
            {
                MessageBox.Show("Hãy nhập tên tài khoản!", "Thông báo");
            }
            else
            {
                int count = 0;
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    if (table.Rows[i][0].ToString() == txtTenDangNhap.Text)
                    {
                        count++;
                        lblQuenMk.Text = table.Rows[i][1].ToString();
                        break;

                    }
                }
                if (count == 0)
                {
                    MessageBox.Show("Tài khoản không tồn tại!");
                    txtTenDangNhap.Focus();
                }
            }
        }

        private void frmQuenMatKhau_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from TaiKhoan";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
        }
    }
}
