using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien_Demo
{
    public partial class Form_MuonTra : Form
    {
        static string startupPath = Application.StartupPath;

        SqlConnection conn;
        SqlCommand cmd;
        String str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + startupPath + @"\QuanLyThuVien.mdf;Integrated Security=True;Connect Timeout=30";
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlDataAdapter adapter1 = new SqlDataAdapter();
        DataTable tableMuon = new DataTable();
        DataTable tableTra = new DataTable();

        void LoadDgvChoMuon()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select MaDocGia as 'Mã độc giả', MaSach as 'Mã sách', SoLuong as 'Số lượng', NgayMuon as 'Ngày mượn', NgayHenTra as 'Ngày hẹn trả' from MuonSach";
            adapter.SelectCommand = cmd;
            tableMuon.Clear();
            adapter.Fill(tableMuon);
            dgvChoMuon.DataSource = tableMuon;
        }
        void LoadDgvTraSach()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select MaDocGia as 'Mã độc giả', MaSach as 'Mã sách', SoLuong as 'Số lượng', NgayMuon as 'Ngày mượn', NgayHenTra as 'Ngày hẹn trả', NgayTra as 'Ngày Trả' from TraSach";
            adapter1.SelectCommand = cmd;
            tableTra.Clear();
            adapter1.Fill(tableTra);
            dgvTraSach.DataSource = tableTra;
        }

        void LoadCb()
        {
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select MaSach From Sach", conn);
                SqlDataAdapter da1 = new SqlDataAdapter("Select MaDocGia From DocGia", conn);
                SqlDataAdapter da2 = new SqlDataAdapter("SELECT DISTINCT MuonSach.MaDocGia FROM dbo.MuonSach INNER JOIN dbo.DocGia ON DocGia.MaDocGia = MuonSach.MaDocGia", conn);
                da.Fill(dt);
                da1.Fill(dt1);
                da2.Fill(dt2);
            }
            catch (Exception ex)
            {
                throw new Exception("Error " + ex.ToString());
            }

            try
            {
                cbChonMaSach.DataSource = dt;
                cbChonMaSach.DisplayMember = "MaSach";
                cbChonMaSach.ValueMember = "MaSach";

                cbMaDG.DataSource = dt1;
                cbMaDG.DisplayMember = "MaDocGia";
                cbMaDG.ValueMember = "MaDocGia";

                cbMaDG_TraSach.DataSource = dt2; ;
                cbMaDG_TraSach.DisplayMember = "MaDocGia";
                cbMaDG_TraSach.ValueMember = "MaDocGia";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi load dữ liệu!\n", ex.ToString());
            }
        }


        public Form_MuonTra()
        {
            InitializeComponent();
        }
        // Load toàn bộ dữ liệu khi mở form lên
        private void Form_MuonTra_Load(object sender, EventArgs e)
        {
            Font currentFont = dgvChoMuon.Font;
            Font newFont = new Font(currentFont.FontFamily, 12, FontStyle.Bold);
            dgvTraSach.Font = newFont;
            dgvTraSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            conn = new SqlConnection(str);
            conn.Open();
            LoadDgvChoMuon();
            LoadDgvTraSach();
            LoadCb();

        }

        //===========================================================//
        // Đóng form hiện tại
        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //===========================================================//
        // Xóa sạch textbox để người quản lý nhập mới
        private void btnMuonMoi_Click(object sender, EventArgs e)
        {
            //=============== Thông tin mượn ============//
            cbMaDG.Text = "";
            txtMaSach.Text = "";
            dtNgayMuon.Text = "";
            dtNgayHenTra.Text = "";
            txtSoLuong.Text = "";

            //============= Thông tin sách ============//
            cbChonMaSach.Text = "";
            lblTenSach.Text = "";
            lblSoLuong.Text = "";
            lblMaLoai.Text = "";
            lblMaTG.Text = "";

        }

        //============= Cho Mượn button ============//
        private void btnChoMuon_Click(object sender, EventArgs e)
        {

            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Sach ", conn);
            tb.Clear();
            da.Fill(tb);
            cmd = conn.CreateCommand();

            if (cbMaDG.Text == "" || txtSoLuong.Text == "" || txtSoLuong.Text == "0")
            {
                MessageBox.Show("Hãy nhập đầy đủ dữ liệu!", "Thông Báo");
            }
            else
            {
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    if (tb.Rows[i][0].ToString() == txtMaSach.Text)
                    {
                        if (int.Parse(txtSoLuong.Text) > int.Parse(tb.Rows[i][3].ToString()))
                        {
                            MessageBox.Show("Vượt quá số lượng sách trong kho!! Kho: " + tb.Rows[i][3].ToString(), "Thông báo");
                            return;
                        }
                        else
                        {
                            int soluong = int.Parse(tb.Rows[i][3].ToString()) - int.Parse(txtSoLuong.Text);
                            cmd.CommandText = "update Sach set SoLuong = '" + soluong.ToString() + "' where MaSach = '" + txtMaSach.Text + "' ";
                            cmd.ExecuteNonQuery();
                            break;
                        }
                    }
                }
                cmd.CommandText = "insert into MuonSach values('" + cbMaDG.Text + "','" + txtMaSach.Text + "','" + txtSoLuong.Text + "', '" + dtNgayMuon.Text + "','" + dtNgayHenTra.Text + "' )";
                cmd.ExecuteNonQuery();
                LoadDgvChoMuon();
            }

        }

        //===========================================================//
        // Nhận sự kiện thay đổi text để update các thuộc tính của sách
        private void cbChonMaSach_TextChanged(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Sach ", conn);
            tb.Clear();
            da.Fill(tb);

            for (int i = 0; i < tb.Rows.Count; i++)
            {
                if (tb.Rows[i][0].ToString() == cbChonMaSach.Text)
                {
                    txtMaSach.Text = tb.Rows[i][0].ToString();
                    lblTenSach.Text = tb.Rows[i][1].ToString();
                    lblMaLoai.Text = tb.Rows[i][2].ToString();
                    lblSoLuong.Text = tb.Rows[i][3].ToString();
                    lblMaTG.Text = tb.Rows[i][4].ToString();
                }
            }

        }
        private void cbMaDG_TraSach_TextChanged(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT MaSach FROM dbo.MuonSach WHERE MaDocGia = '" + cbMaDG_TraSach.Text + "' ", conn);
            tb.Clear();
            da.Fill(tb);

            txtMaSach_TraSach.DataSource = tb;
            txtMaSach_TraSach.DisplayMember = "MaSach";
            txtMaSach_TraSach.ValueMember = "MaSach";
        }

        private void txtMaSach_TraSach_TextChanged(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM dbo.MuonSach WHERE MaDocGia = '" + cbMaDG_TraSach.Text + "' " +
                                                                                      "and MaSach = '" + txtMaSach_TraSach.Text + "' ", conn);
            tb.Clear();
            da.Fill(tb);
            txtSoLuong_TraSach.Text = tb.Rows[0][2].ToString();
            dtNgayMuon_TraSach.Text = tb.Rows[0][3].ToString();
            dtNgayHenTra_TraSach.Text = tb.Rows[0][4].ToString();
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            TimeSpan time = Convert.ToDateTime(dtNgayHenTra_TraSach.Text) - Convert.ToDateTime(dtNgayTra.Text);
            if ((int)time.Days >= 0)
            {
                lblTinhTrangTraSach.Text = "Đúng hạn!";
            }
            else
            {
                lblTinhTrangTraSach.Text = "Quá hạn!";
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "insert into TraSach values('" + cbMaDG_TraSach.Text + "','" + txtMaSach_TraSach.Text + "'," +
                                                         "'" + txtSoLuong_TraSach.Text + "', '" + dtNgayMuon_TraSach.Text + "'," +
                                                         "'" + dtNgayHenTra_TraSach.Text + "', '" + dtNgayTra.Text + "' )";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "DELETE FROM dbo.MuonSach WHERE MaDocGia = '" + cbMaDG_TraSach.Text + "' AND MaSach = '" + txtMaSach_TraSach.Text + "'";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "UPDATE dbo.Sach SET SoLuong += '" + int.Parse(txtSoLuong_TraSach.Text) + "'  WHERE MaSach = '" + txtMaSach_TraSach.Text + "'";
            cmd.ExecuteNonQuery();

            LoadDgvTraSach();
            LoadDgvChoMuon();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
