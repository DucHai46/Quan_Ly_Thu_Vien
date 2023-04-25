using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien_Demo
{
    public partial class Form_Doc_Gia : Form
    {
        static string startupPath = Application.StartupPath;

        SqlConnection conn;
        SqlCommand cmd;
        String str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + startupPath + @"\QuanLyThuVien.mdf;Integrated Security=True;Connect Timeout=30";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        public void LoadDgvDocGia()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select MaDocGia as 'Mã Độc Giả', TenDocGia as 'Tên Độc Giả'," +
                                    " GioiTinh as 'Giới Tính', NgaySinh as 'Ngày Sinh', DiaChi as 'Địa Chỉ' from DocGia ";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgvDocGia.DataSource = table;
        }

        public Form_Doc_Gia()
        {
            InitializeComponent();
        }


        private void Form_Doc_Gia_Load(object sender, EventArgs e)
        {
            Font currentFont = dgvDocGia.Font;
            Font newFont = new Font(currentFont.FontFamily, 12, FontStyle.Bold);
            dgvDocGia.Font = newFont;
            dgvDocGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            conn = new SqlConnection(str);
            conn.Open();
            LoadDgvDocGia();
        }

        private void dgvDocGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaDG.ReadOnly = true;
            int i = dgvDocGia.CurrentRow.Index;
            txtMaDG.Text = dgvDocGia.Rows[i].Cells[0].Value.ToString();
            txtTenDG.Text = dgvDocGia.Rows[i].Cells[1].Value.ToString();
            String gioitinh = dgvDocGia.Rows[i].Cells[2].Value.ToString();
            if (gioitinh == "Nam")
            {
                radNam.Checked = true;
            }
            else
            {
                radNu.Checked = true;
            }
            dtNgaySinh.Text = dgvDocGia.Rows[i].Cells[3].Value.ToString();
            txtDiaChi.Text = dgvDocGia.Rows[i].Cells[4].Value.ToString();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaDG.Text == "")
            {
                MessageBox.Show("Chưa nhập mã Độc Giả!", "Thông báo");
                txtMaDG.Focus();
            }
            else if (txtTenDG.Text == "")
            {
                MessageBox.Show("Chưa nhập Tên Độc Giả!", "Thông báo");
                txtTenDG.Focus();
            }
            else if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Chưa nhập địa chỉ độc giả!", "Thông báo");
                txtDiaChi.Focus();
            }
            else
            {
                String gioitinh = radNam.Text;
                if (radNu.Checked)
                {
                    gioitinh = "Nữ";
                }
                int count = 0;
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    if (table.Rows[i][0].ToString() == txtMaDG.Text)
                    {
                        count++;
                        break;
                    }
                }
                if (count == 0)
                {
                    cmd = conn.CreateCommand();
                    cmd.CommandText = "insert into DocGia values ('" + txtMaDG.Text + "', N'" + txtTenDG.Text + "', " +
                                                                 "N'" + gioitinh + "', '" + dtNgaySinh.Text + "', N'" + txtDiaChi.Text + "'  )";
                    cmd.ExecuteNonQuery();
                    LoadDgvDocGia();
                }
                else
                {
                    MessageBox.Show("Mã Độc Giả đã tồn tại!");
                    txtMaDG.Clear();
                    txtMaDG.Focus();
                }
            }
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "delete from DocGia where MaDocGia = '" + txtMaDG.Text + "'";
            cmd.ExecuteNonQuery();
            LoadDgvDocGia();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            String gioitinh = radNam.Text;
            if (radNu.Checked)
            {
                gioitinh = "Nữ";
            }
            cmd = conn.CreateCommand();
            cmd.CommandText = "update DocGia set TenDocGia = N'" + txtTenDG.Text + "', GioiTinh = N'" + gioitinh + "', " +
                                                 "NgaySinh = '" + dtNgaySinh.Text + "',DiaChi = '" + txtDiaChi.Text + "' " +
                                                 "where MaDocGia = '" + txtMaDG.Text + "'";
            cmd.ExecuteNonQuery();
            LoadDgvDocGia();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaDG.ReadOnly = false;
            txtDiaChi.Clear();
            txtMaDG.Clear();
            txtTenDG.Clear();
            radNam.Checked = true;
            dtNgaySinh.Text = DateTime.Now.ToString();
        }


    }
}
