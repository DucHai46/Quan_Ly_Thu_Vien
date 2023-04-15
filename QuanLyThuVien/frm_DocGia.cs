using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class Form_Doc_Gia : Form
    {
        public Form_Doc_Gia()
        {
            InitializeComponent();
        }

        

        private void Form_Doc_Gia_Load(object sender, EventArgs e)
        {
            NapListViewDSDocGia();

        }

        // NapListViewDSDocGia load từ sql để cập nhật tất cả dữ liệu lên bảng 

        /* Mã độc giả
         * Tên độc giả
         * Giới tính
         * Địa chỉ 
         * Ngày mượn
         */
        private void NapListViewDSDocGia()
        {
            lvwDanhSachDG.Items.Clear();
            // Viết tại đây

        }

        private void lvwDanhSachDG_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwDanhSachDG.SelectedItems.Count > 0)
            {
                ListViewItem li = lvwDanhSachDG.SelectedItems[lvwDanhSachDG.SelectedItems.Count - 1];
                foreach (ListViewItem lvw in lvwDanhSachDG.SelectedItems)
                {
                    txtMaDG.Text = lvw.SubItems[0].Text;
                    txtTenDG.Text = lvw.SubItems[1].Text;
                    dtNgayMuon.Text = lvw.SubItems[3].Text;
                    if (lvw.SubItems[2].Text == "Nam")
                        radNam.Checked = true;
                    else
                        radNu.Checked = true;
                    txtDiaChi.Text = lvw.SubItems[4].Text;
                }
            }
        }

        private void setButton()
        {
            btnThem.Text = "Thêm";
            txtMaDG.Text = "";
            txtTenDG.Text = "";
            radNam.Checked = true;
            dtNgayMuon.Text = "";
            txtDiaChi.Text = "";
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            lvwDanhSachDG.Enabled = true;
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                btnThem.Text = "Hủy";
                grbChiTietDG.Enabled = true;
                txtMaDG.Text = "";
                txtTenDG.Text = "";
                dtNgayMuon.Text = "";
                txtDiaChi.Text = "";
                txtMaDG.Focus();
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
                lvwDanhSachDG.Enabled = false;
            }
            else
            {
                setButton();
            }
        }

        /* Thao tác
         * click thêm -> Điền đầy đủ thông tin -> click lưu 
         */

        // Thêm độc giả vào sql 
        private void LuuThemDG()
        {
            try
            {
                // Viết tại đây

                setButton();
                NapListViewDSDocGia();
                MessageBox.Show("Lưu dữ liệu thành công!");
            }
            catch (Exception)
            {
                NapListViewDSDocGia();
                MessageBox.Show("Lưu dữ liệu thất bại!");
            }
        }

        /* Thao tác
         * Chọn vào ô cần sửa -> click vào sửa -> click lưu 
         */

        // Lưu sự thay đổi lại vào sql
        /* Tìm mã độc giả tương ứng từ đó lưu sự thay đổi */
        private void LuuSuaDG()
        {
            try
            {
                // Code mẫu
                /*dtDocGia = objDocGia.getTableDocGia_Theo_MaDG(lvwDanhSachDG.SelectedItems[0].Text);
                dtDocGia.Rows[0]["MaDG"] = txtMaDG.Text;
                dtDocGia.Rows[0]["TenDG"] = txtTenDG.Text;
                dtDocGia.Rows[0]["GioiTinh"] = radNu.Checked ? true : false;
                dtDocGia.Rows[0]["NgayMuon"] = dtNgayMuon.Value;
                dtDocGia.Rows[0]["DiaChi"] = txtDiaChi.Text;
                objDocGia.CapNhatTable_DocGia(dtDocGia);*/


                MessageBox.Show("Lưu sửa dữ liệu thành công!");
                NapListViewDSDocGia();
            }
            catch (Exception)
            {

                MessageBox.Show("Thất bại!", "Error");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Doc_Gia_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn đóng chương trình không?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dl == DialogResult.No)
                e.Cancel = true;
        }

        // Xóa dữ liệu tương ứng đã chọn trên sql
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvwDanhSachDG.SelectedItems.Count > 0)
            {
                DialogResult dl = MessageBox.Show("Bạn có chắc muốn xóa dữ liệu này?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dl == DialogResult.Yes)
                {
                    // Code mẫu viết code tại đây
                    /*DataRow[] dr = dtDocGia.Select("MaDG='" + txtMaDG.Text + "'");
                    dr[0].Delete();
                    objDocGia.CapNhatTable_DocGia(dtDocGia);*/


                    // clear text
                    txtMaDG.Text = "";
                    txtTenDG.Text = "";
                    radNam.Checked = true;
                    dtNgayMuon.Text = "";
                    txtDiaChi.Text = "";
                    grbChiTietDG.Enabled = false;
                    NapListViewDSDocGia();
                    MessageBox.Show("Xóa dữ liệu thành công!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn dữ liệu cần xóa!", "Thông báo");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvwDanhSachDG.SelectedItems.Count > 0)
            {
                txtMaDG.Focus();
            }
            else
            {
                MessageBox.Show("Bạn hãy chọn dữ liệu cần sửa!", "Thông báo");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
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
                if (lvwDanhSachDG.SelectedItems.Count == 0)
                {
                    LuuThemDG();
                }    
                    
                else
                    LuuSuaDG();
            }
        }
    }
}
