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
    public partial class frmTimKiemSach : Form
    {
        static string startupPath = Application.StartupPath;

        SqlConnection conn;
        SqlCommand cmd;
        String str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + startupPath + @"\QuanLyThuVien.mdf;Integrated Security=True;Connect Timeout=30";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        public frmTimKiemSach()
        {
            InitializeComponent();
        }

        private void frmTimKiemSach_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if(txt_TimSach.Text == "")
            {
                lbl_TTTimKiem.Visible = true;
            }
            else
            {
                if (rbtn_MaSach.Checked)
                {
                    cmd = conn.CreateCommand();
                    cmd.CommandText = "select * from Sach where MaSach = '"+ txt_TimSach.Text.ToUpper()+"'";
                    adapter.SelectCommand = cmd;
                    table.Clear();
                    adapter.Fill(table);
                }
                else
                {
                    //Chuẩn hoá tên sách
                    string ten = txt_TimSach.Text;
                    string tensach = "";
                    ten = ten.Trim().ToLower();
                    for (int i = 0; i < ten.Length; i++)
                    {
                        if (i == 0)
                            tensach += ten[i].ToString().ToUpper();
                        else
                            tensach += ten[i];
                        if (ten[i] == ' ')
                        {
                            while (ten[i] == ' ')
                            {
                                i++;
                            }
                            tensach += ten[i].ToString().ToUpper();
                        }
                    }
                    //-----------//
                    cmd = conn.CreateCommand();
                    cmd.CommandText = "select * from Sach where TenSach = N'" + tensach + "'";
                    adapter.SelectCommand = cmd;
                    table.Clear();
                    adapter.Fill(table);
                }

                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("Không có loại sách bạn cần tìm", "Thông báo");
                    return;
                }
                txt_MaSach.Text = table.Rows[0]["MaSach"].ToString();
                txt_TenSach.Text = table.Rows[0]["TenSach"].ToString();
                txt_SoLuong.Text = table.Rows[0]["SoLuong"].ToString();
                txt_MaTG.Text = table.Rows[0]["MaTacGia"].ToString();
                txt_MaLoaiSach.Text = table.Rows[0]["MaLoaiSach"].ToString();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
