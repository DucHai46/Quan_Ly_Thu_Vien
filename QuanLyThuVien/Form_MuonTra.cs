using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class Form_MuonTra : Form
    {
        string currentDirectory = System.IO.Directory.GetCurrentDirectory() + "/Data";
        public Form_MuonTra()
        {
            InitializeComponent();
        }

        // Load 2 comboBox ở page1 và 1 comboBox ở page2
        private void LoadComboBox()
        {
            cbMaDG_TraSach.Items.Clear();
            cbMaDG.Items.Clear();
            cbChonMaSach.Items.Clear();

            string File_Sach = currentDirectory + "/Sach.txt";
            string File_Doc_Gia = currentDirectory + "/Doc_gia.txt";

            string[] lines_Sach = File.ReadAllLines(File_Sach);
            string[] lines_Doc_Gia = File.ReadAllLines(File_Doc_Gia);

            foreach (string line in lines_Sach)
                cbChonMaSach.Items.Add(line.Split(',')[1]);
            foreach (string line in lines_Doc_Gia)
            {
                cbMaDG.Items.Add(line.Split(',')[0]);
                cbMaDG_TraSach.Items.Add(line.Split(',')[0]);
            }
                
            
        }
        //---------------------------------------//
        // Load listViewTable ở lvwDanhSach
        private void Load_lvwDanhSach()
        {
            string File_Muon_Sach = currentDirectory + "/Muon_Sach.txt";
            string[] lines_Muon_Sach = File.ReadAllLines(File_Muon_Sach);
            foreach (string line in lines_Muon_Sach)
            {
                ListViewItem li = new ListViewItem();
                li.Text = line.Split(',')[0];
                li.SubItems.Add(line.Split(',')[1]);
                li.SubItems.Add(line.Split(',')[2]);
                string ngaymuon = Convert.ToDateTime(line.Split(',')[3]).ToShortDateString();
                li.SubItems.Add(ngaymuon);
                string ngayhentra = Convert.ToDateTime(line.Split(',')[4]).ToShortDateString();
                li.SubItems.Add(ngayhentra);
                lvwDanhSach.Items.Add(li);
            }

            // Load lại cbMaDG_TraSach ở Trả sách
            cbMaDG_TraSach.Items.Clear();
            foreach (string line in lines_Muon_Sach)
                cbMaDG_TraSach.Items.Add(line.Split(',')[0]);

        }

        // Load listViewTable ở lvwDanhSach
        private void Load_lvwDanhSachTra()
        {
            string File_Tra_Sach = currentDirectory + "/Tra_Sach.txt";
            string[] lines_Tra_Sach = File.ReadAllLines(File_Tra_Sach);
            foreach (string line in lines_Tra_Sach)
            {
                ListViewItem li = new ListViewItem();
                li.Text = line.Split(',')[0];
                li.SubItems.Add(line.Split(',')[1]);
                li.SubItems.Add(line.Split(',')[2]);
                string ngaymuon = Convert.ToDateTime(line.Split(',')[3]).ToShortDateString();
                li.SubItems.Add(ngaymuon);

                string ngayhentra = Convert.ToDateTime(line.Split(',')[4]).ToShortDateString();
                li.SubItems.Add(ngayhentra);

                string ngaytra = Convert.ToDateTime(line.Split(',')[5]).ToShortDateString();
                li.SubItems.Add(ngaytra);
                lvwDanhSachTra.Items.Add(li);
            }
        }

        // Load toàn bộ dữ liệu khi mở form lên
        private void Form_MuonTra_Load(object sender, EventArgs e)
        {
            Load_lvwDanhSach();
            Load_lvwDanhSachTra();
            LoadComboBox();
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
            lblMaSach.Text = "";
            lblSoLuong.Text = "";
            lblMaLoai.Text = "";
            lblMaTG.Text = "";

        }


        private void btnChoMuon_Click(object sender, EventArgs e)
        {
            bool exists = false;
            int so_luong_Sach_Muon = 0;
            int so_luong_Sach = 0;

            string File_Muon_Sach = currentDirectory + "/Muon_Sach.txt";

            string File_Sach = currentDirectory + "/Sach.txt";
            string[] lines_Sach = File.ReadAllLines(File_Sach);
            string[] lines_Muon_Sach = File.ReadAllLines(File_Muon_Sach);

            string noiDung = cbMaDG.Text + ","
                                + txtMaSach.Text + ","
                                + txtSoLuong.Text + ","
                                + dtNgayMuon.Text + ","
                                + dtNgayHenTra.Text + "\n";

            //===========================================================//
            // Kiểm tra mã sách đúng không
            foreach (string line in lines_Sach)
                if (txtMaSach.Text == line.Split(',')[0])
                {
                    so_luong_Sach = int.Parse(line.Split(',')[3]);
                    exists = true;
                    break;
                }

            if (!exists)
            {
                MessageBox.Show("Không tồn tại mã sách như vậy");
                txtMaSach.Focus();
                return;
            }

            //===========================================================//
            // Kiểm tra đã điền độc giả chưa
            if (cbMaDG.Text == "")
            {
                MessageBox.Show("Chưa điền độc giả");
                cbMaDG.Focus();
                return;
            }

            if (txtSoLuong.Text == "" || int.Parse(txtSoLuong.Text) == 0)
            {
                MessageBox.Show("Chưa điền số lượng");
                return;
            }

            foreach (string line in lines_Muon_Sach)
            {
                if (txtMaSach.Text == line.Split(',')[1])
                    so_luong_Sach_Muon += int.Parse(line.Split(',')[2]);
            }
                

            if (int.Parse(txtSoLuong.Text) > (so_luong_Sach - so_luong_Sach_Muon))
            {
                MessageBox.Show(string.Format("Số sách còn lại {0} < {1}", so_luong_Sach - so_luong_Sach_Muon, txtSoLuong.Text));
                txtSoLuong.Focus();
                return;
            }

            File.AppendAllText(File_Muon_Sach, noiDung);
            lvwDanhSach.Items.Clear();
            Load_lvwDanhSach();

        }

        //===========================================================//
        // Nhận sự kiện thay đổi text để update các thuộc tính của sách
        private void cbChonMaSach_TextChanged(object sender, EventArgs e)
        {
            string textFile = currentDirectory + "/Sach.txt";
            string[] lines = File.ReadAllLines(textFile);
            foreach (string line in lines)
            {
                if (line.Split(',')[1] == cbChonMaSach.Text)
                {
                    lblMaSach.Text = line.Split(',')[0];
                    lblMaLoai.Text = line.Split(',')[2];
                    lblSoLuong.Text = line.Split(',')[3];
                    lblMaTG.Text = line.Split(',')[4];
                    txtMaSach.Text = line.Split(',')[0];
                }
            }
        }

        private void cbMaDG_TraSach_TextChanged(object sender, EventArgs e)
        {
            bool is_Borrow = false;
            string File_Muon_Sach = currentDirectory + "/Muon_Sach.txt";
            string[] lines_Muon_Sach = File.ReadAllLines(File_Muon_Sach);

            // Clear ALL infor to set new value with name MaDG
            txtMaSach_TraSach.SelectedIndex = -1;
            txtMaSach_TraSach.Items.Clear();
            txtSoLuong_TraSach.Text = "";
            
            // Add all infor 
            foreach (string line in lines_Muon_Sach)
            {

                if (line.Split(',')[0] == cbMaDG_TraSach.Text)
                {
                    txtMaSach_TraSach.Items.Add(line.Split(',')[1]);
                    is_Borrow = true;
                }
            }
            if (!is_Borrow) 
            {
                MessageBox.Show(String.Format("Độc giả {0} chưa mượn cuốn nào", cbMaDG_TraSach.Text));
            }
        }

        private void txtMaSach_TraSach_TextChanged(object sender, EventArgs e)
        {
            if (txtMaSach_TraSach.Text == "")
            {
                return;
            }
            string File_Muon_Sach = currentDirectory + "/Muon_Sach.txt";
            string[] lines_Muon_Sach = File.ReadAllLines(File_Muon_Sach);

            dtNgayMuon_TraSach.Text = "";
            dtNgayHenTra_TraSach.Text = "";
            dtNgayTra.Text = "";

            foreach (string line in lines_Muon_Sach)
            {

                if (line.Split(',')[0] == cbMaDG_TraSach.Text && line.Split(',')[1] == txtMaSach_TraSach.Text)
                {

                    txtSoLuong_TraSach.Text = line.Split(',')[2];
                    string ngaymuontra = Convert.ToDateTime(line.Split(',')[3]).ToShortDateString();
                    dtNgayMuon_TraSach.Text = ngaymuontra;

                    string ngayhentra = Convert.ToDateTime(line.Split(',')[4]).ToShortDateString();
                    dtNgayHenTra_TraSach.Text = ngayhentra;
                }
            }
        }
    }
}
