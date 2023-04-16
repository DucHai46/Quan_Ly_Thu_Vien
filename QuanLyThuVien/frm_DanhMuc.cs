using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using System.Runtime.CompilerServices;
using System.Data.SqlClient;

namespace QuanLyThuVien
{
    public partial class frm_DanhMuc : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        String str = @"Data Source=ADMIN\DUCHAI;Initial Catalog=QuanLyThuVien;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlDataAdapter adapter1 = new SqlDataAdapter();
        DataTable table= new DataTable();
        DataTable table1= new DataTable();

        void LoadLoaiSach()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select TenLoaiSach as 'Tên loại sách' from LoaiSach";
            adapter1.SelectCommand= cmd;
            table1.Clear();
            adapter1.Fill(table1); 
            dgvLoaiSach.DataSource = table1;
        }
        void LoadSach(String TruyVan)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = TruyVan;
            adapter.SelectCommand= cmd;
            table.Clear();
            adapter.Fill(table);
            dgvSach.DataSource = table;
        }

        public frm_DanhMuc()
        {
            InitializeComponent();
        }
        private void frm_DanhMuc_Load(object sender, EventArgs e)
        {
            Font currentFont = dgvSach.Font;
            Font newFont = new Font(currentFont.FontFamily, 12, FontStyle.Bold);
            dgvSach.Font = newFont;
            dgvLoaiSach.Font = newFont;
            dgvSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvLoaiSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            

            conn = new SqlConnection(str);
            conn.Open();
            LoadSach("select MaSach as 'Mã sách', TenSach as 'Tên sách', MaLoaiSach as 'Mã loại sách', SoLuong as 'Số lượng', MaTacGia as 'Mã tác giả' from Sach");
            LoadLoaiSach();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            frm_CapNhat frmCapNhat = new frm_CapNhat();
            frmCapNhat.ShowDialog();
        }

        private void btnMuonTra_Click(object sender, EventArgs e)
        {
            Form_MuonTra frmMuonTra = new Form_MuonTra();
            if(frmMuonTra.ShowDialog() == DialogResult.Cancel)
            {
                LoadSach("select MaSach as 'Mã sách', TenSach as 'Tên sách', MaLoaiSach as 'Mã loại sách', SoLuong as 'Số lượng', MaTacGia as 'Mã tác giả' from Sach");
            }
        }

        private void btnQlDocGia_Click(object sender, EventArgs e)
        {
            Form_Doc_Gia frmDocGia = new Form_Doc_Gia();
            frmDocGia.ShowDialog();
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvSach.CurrentRow.Index;
            txtMaSach.Text = dgvSach.Rows[i].Cells[0].Value.ToString();
            txtTenSach.Text = dgvSach.Rows[i].Cells[1].Value.ToString();
            txtMaLoai.Text = dgvSach.Rows[i].Cells[2].Value.ToString();
            txtSoLuong.Text = dgvSach.Rows[i].Cells[3].Value.ToString();
            txtMaTacGia.Text = dgvSach.Rows[i].Cells[4].Value.ToString();
        }

        private void dgvLoaiSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvLoaiSach.CurrentRow.Index;
            cmd = conn.CreateCommand();
            String TenLoaiSach = dgvLoaiSach.Rows[i].Cells[0].Value.ToString();

            LoadSach("select S.MaSach as 'Mã sách', S.TenSach as 'Tên sách', S.MaLoaiSach as 'Mã loại sách', S.SoLuong as 'Số lượng', S.MaTacGia as 'Mã tác giả' from Sach as S inner join LoaiSach as LS on S.MaLoaiSach = LS.MaLoaiSach where LS.TenLoaiSach = N'" + TenLoaiSach + "'");
        }

    }
}
