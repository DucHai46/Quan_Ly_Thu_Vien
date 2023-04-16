using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.Common;
using System.Collections.ObjectModel;

namespace QuanLyThuVien
{
    public partial class frm_CapNhat : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        String str = @"Data Source=ADMIN\DUCHAI;Initial Catalog=QuanLyThuVien;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlDataAdapter adapter1 = new SqlDataAdapter();
        DataTable table = new DataTable();
        DataTable table1 = new DataTable();

        void LoadDgvLoaiSach()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select MaLoaiSach as 'Mã Loại Sách', TenLoaiSach as 'Tên Loại Sách', KieuSach as 'Kiểu Sách' from LoaiSach";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgvLoaiSach.DataSource = table;
        }
        void LoadDgvSach()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select MaSach as 'Mã sách', TenSach as 'Tên sách', MaLoaiSach as 'Mã loại sách', SoLuong as 'Số lượng', MaTacGia as 'Mã tác giả' from Sach";
            adapter1.SelectCommand = cmd;
            table1.Clear();
            adapter1.Fill(table1);
            dgvSach.DataSource = table1;
        }

        void LoadComboBox()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select MaLoaiSach From LoaiSach", conn);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error " + ex.ToString());
            }

            try
            {
                cmbMaLoaiSach.DataSource = dt;
                cmbMaLoaiSach.DisplayMember = "MaLoaiSach";
                cmbMaLoaiSach.ValueMember = "MaLoaiSach";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi load dữ liệu!\n", ex.ToString());
            }
        }

        public frm_CapNhat()
        {
            InitializeComponent();
        }
        private void frm_CapNhat_Load(object sender, EventArgs e)
        {
            Font currentFont = dgvLoaiSach.Font;
            Font newFont = new Font(currentFont.FontFamily, 12, FontStyle.Bold);
            dgvSach.Font = newFont;
            dgvLoaiSach.Font = newFont;
            dgvSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvLoaiSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            conn = new SqlConnection(str);
            conn.Open();
            LoadDgvLoaiSach();
            LoadDgvSach();
            LoadComboBox();
        }

        //button thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnThoat1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //button xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "delete from LoaiSach where MaLoaiSach = '" + txtMaLoaiSach.Text + "'";
            cmd.ExecuteNonQuery();
            LoadDgvLoaiSach();
        }
        private void btnXoa1_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "delete from Sach where MaSach = '" + txtMaSach.Text + "'";
            cmd.ExecuteNonQuery();
            LoadDgvSach();
        }


        //button sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "update LoaiSach set TenLoaiSach = N'" + txtTenLoaiSach.Text + "', KieuSach = N'" + txtKieuSach.Text + "' where MaLoaiSach = '"+txtMaLoaiSach.Text+"'";
            cmd.ExecuteNonQuery();
            LoadDgvLoaiSach();

        }
        private void btnSua1_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "update Sach set TenSach = N'" + txtTenSach.Text + "', MaLoaiSach = N'" + cmbMaLoaiSach.Text + "', SoLuong = '"+txtSoLuong.Text+"', MaTacGia = '"+txtMaTacGia.Text+"' where MaSach = '" + txtMaSach.Text + "'";
            cmd.ExecuteNonQuery();
            LoadDgvSach();
        }


        //button lưu sau khi thay đổi
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaLoaiSach.ReadOnly = false;
            txtMaLoaiSach.Clear();
            txtTenLoaiSach.Clear();
            txtKieuSach.Clear();
        }
        private void btnReset1_Click(object sender, EventArgs e)
        {
            txtMaSach.ReadOnly = false;
            txtMaSach.Clear();
            txtTenSach.Clear();
            cmbMaLoaiSach.ResetText();
            txtSoLuong.Clear();
            txtMaTacGia.Clear();
        }


        //button thêm vào listview
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtMaLoaiSach.Text == "" || txtTenLoaiSach.Text == "" || txtKieuSach.Text == " ")
            {
                MessageBox.Show("Hãy nhập dữ liệu!", "Thông Báo");
            }
            else
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "insert into LoaiSach values('"+txtMaLoaiSach.Text+ "',N'"+txtTenLoaiSach.Text+ "',N'"+txtKieuSach.Text+"' )";
                cmd.ExecuteNonQuery();
                LoadDgvLoaiSach();
            }
        }
        private void btnThem1_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text == "" || txtTenSach.Text == "" || cmbMaLoaiSach.Text == "" || txtSoLuong.Text == "" || txtSoLuong.Text == "0" || txtMaTacGia.Text == "")
            {
                MessageBox.Show("Hãy nhập dữ liệu!", "Thông Báo");
            }
            else
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "insert into Sach values('" + txtMaSach.Text + "',N'" + txtTenSach.Text + "','" + cmbMaLoaiSach.Text + "', '" + txtSoLuong.Text + "', '" + txtMaTacGia.Text + "' )";
                cmd.ExecuteNonQuery();
                LoadDgvSach();
            }
        }

        private void dgvLoaiSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaLoaiSach.ReadOnly = true;
            int i;
            i = dgvLoaiSach.CurrentRow.Index;
            txtMaLoaiSach.Text = dgvLoaiSach.Rows[i].Cells[0].Value.ToString();
            txtTenLoaiSach.Text = dgvLoaiSach.Rows[i].Cells[1].Value.ToString();
            txtKieuSach.Text = dgvLoaiSach.Rows[i].Cells[2].Value.ToString();
        }

        private void dgvSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSach.ReadOnly = true;
            int i;
            i = dgvSach.CurrentRow.Index;
            txtMaSach.Text = dgvSach.Rows[i].Cells[0].Value.ToString();
            txtTenSach.Text = dgvSach.Rows[i].Cells[1].Value.ToString();
            cmbMaLoaiSach.Text = dgvSach.Rows[i].Cells[2].Value.ToString();
            txtSoLuong.Text = dgvSach.Rows[i].Cells[3].Value.ToString();
            txtMaTacGia.Text = dgvSach.Rows[i].Cells[4].Value.ToString();
        }

    }
}
