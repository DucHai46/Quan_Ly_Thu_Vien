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
    public partial class frmTacGia : Form
    {
        static string startupPath = Application.StartupPath;

        SqlConnection conn;
        SqlCommand cmd;
        String str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + startupPath + @"\QuanLyThuVien.mdf;Integrated Security=True;Connect Timeout=30";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void LoadDgvTacGia()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select MaTacGia as 'Mã Tác Giả', TenTacGia as 'Tên Tác Giả', DiaChi as 'Địa Chỉ'  from TacGia";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgvTacGia.DataSource = table;
        }

        public frmTacGia()
        {
            InitializeComponent();
        }
        private void frmTacGia_Load(object sender, EventArgs e)
        {
            Font currentFont = dgvTacGia.Font;
            Font newFont = new Font(currentFont.FontFamily, 12, FontStyle.Bold);
            dgvTacGia.Font = newFont;
            dgvTacGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


            conn = new SqlConnection(str);
            conn.Open();
            LoadDgvTacGia();
        }


        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_MaTG.ResetText();
            txt_TenTG.ResetText();
            txt_DiaChi.ResetText();
            txt_MaTG.ReadOnly = false;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_MaTG.Text == "" || txt_TenTG.Text == "" || txt_DiaChi.Text == "")
            {
                MessageBox.Show("Hãy nhập dữ liệu!", "Thông Báo");
            }
            else
            {
                int count = 0;
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    if (table.Rows[i][0].ToString() == txt_MaTG.Text)
                    {
                        count++;
                        break;
                    }
                }
                if (count == 0)
                {
                    cmd = conn.CreateCommand();
                    cmd.CommandText = "insert into TacGia values('" + txt_MaTG.Text + "',N'" + txt_TenTG.Text + "',N'" + txt_DiaChi.Text + "' )";
                    cmd.ExecuteNonQuery();
                    LoadDgvTacGia();
                }
                else
                {
                    MessageBox.Show("Mã tác giả đã tồn tại!", "Thông báo");
                    txt_MaTG.Focus();
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (txt_MaTG.Text == "")
            {
                MessageBox.Show("Hãy chọn tác giả cần xoá!", "Thông báo");
            }
            else
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "delete from TacGia where MaTacGia = '" + txt_MaTG.Text + "'";
                cmd.ExecuteNonQuery();
                LoadDgvTacGia();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "update TacGia set TenTacGia = N'" + txt_TenTG.Text + "', DiaChi = N'" + txt_DiaChi.Text + "' where MaLoaiSach = '" + txt_MaTG.Text + "'";
            cmd.ExecuteNonQuery();
            LoadDgvTacGia();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TacGia_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn đóng chương trình không?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.No)
                e.Cancel = true;
        }


        private void dgvTacGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaTG.ReadOnly = true;
            int i;
            i = dgvTacGia.CurrentRow.Index;
            txt_MaTG.Text = dgvTacGia.Rows[i].Cells[0].Value.ToString();
            txt_TenTG.Text = dgvTacGia.Rows[i].Cells[1].Value.ToString();
            txt_DiaChi.Text = dgvTacGia.Rows[i].Cells[2].Value.ToString();
        }

    }
}
