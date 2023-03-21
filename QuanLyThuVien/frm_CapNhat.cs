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

namespace QuanLyThuVien
{
    public partial class frm_CapNhat : Form
    {
        string currentDirectory = System.IO.Directory.GetCurrentDirectory() + "/Data";
        private List<LoaiSach> loaiSach = new List<LoaiSach>();
        private List<Sach> Sach = new List<Sach>();


        public frm_CapNhat()
        {
            InitializeComponent();
        }
        private void frm_CapNhat_Load(object sender, EventArgs e)
        {
            KhoiTaoLsv_DanhSachCacLoaiSach();
            KhoiTaoLsv_DanhSachLoaiSach();
            KhoiTaoLoaiSach();
            KhoiTao();
        }


        //Khởi tạo listviewtable
        public void KhoiTaoLsv_DanhSachCacLoaiSach()
        {
            lsv_CacLoaiSach.Columns.Add("Mã Sách", 120);
            lsv_CacLoaiSach.Columns.Add("Tên Sách", 200);
            lsv_CacLoaiSach.Columns.Add("Mã Loại Sách", 120);
            lsv_CacLoaiSach.Columns.Add("Số Lượng", 100);
            lsv_CacLoaiSach.Columns.Add("Mã Tác Giả", 120);
            lsv_CacLoaiSach.View = View.Details;
        }
        public void KhoiTaoLsv_DanhSachLoaiSach()
        {
            lsv_DanhSachLoaiSach.Columns.Add("Mã Loại Sách", 120);
            lsv_DanhSachLoaiSach.Columns.Add("Tên Loại Sách", 200);
            lsv_DanhSachLoaiSach.Columns.Add("Kiểu Sách", 450);

            lsv_DanhSachLoaiSach.View = View.Details;
        }


        //khởi tạo data trong frm cập nhật loại sách
        public void KhoiTaoLoaiSach()
        {
            String File_LoaiSach = currentDirectory + "/LoaiSach.txt";
            String[] str = File.ReadAllLines(File_LoaiSach);
            foreach (String str2 in str)
            {
                loaiSach.Add(new LoaiSach() { maLoaiSach = str2.Split(',')[0], tenLoaiSach = str2.Split(',')[1], kieuSach = str2.Split(',')[2] });
            }
            foreach (LoaiSach loaiSach1 in loaiSach)
            {
                ListViewItem item = new ListViewItem(loaiSach1.maLoaiSach);
                item.SubItems.Add(loaiSach1.tenLoaiSach);
                item.SubItems.Add(loaiSach1.kieuSach);
                lsv_DanhSachLoaiSach.Items.Add(item);
            }
        }


        // Khởi tạo data trong frm cập nhật sách
        public void KhoiTao()
        {
            String File_Sach = currentDirectory + "/Sach.txt"; 
            String[] str = File.ReadAllLines(File_Sach);
            foreach (String str2 in str)
            {
                Sach.Add(new Sach() { maSach = str2.Split(',')[0], tenSach = str2.Split(',')[1], maLoaiSach = str2.Split(',')[2], soLuong = int.Parse(str2.Split(',')[3]), maTacGia = str2.Split(',')[4] });
            }
            foreach (String str2 in str)
            {
                cmbMaLoaiSach.Items.Add(str2.Split(',')[2]);
                cmbMaTacGia.Items.Add(str2.Split(',')[4]);            
            }
            for(int i = 0; i < cmbMaLoaiSach.Items.Count-1; i++)
            {
                if (cmbMaLoaiSach.Items[i].ToString() == cmbMaLoaiSach.Items[i + 1].ToString())
                {
                    cmbMaLoaiSach.Items.Remove(cmbMaLoaiSach.Items[i+1]);
                    i--;
                }
            }
            foreach (Sach Sach1 in Sach)
            {
                ListViewItem item = new ListViewItem(Sach1.maSach);
                item.SubItems.Add(Sach1.tenSach);
                item.SubItems.Add(Sach1.maLoaiSach);
                item.SubItems.Add(Sach1.soLuong.ToString());
                item.SubItems.Add(Sach1.maTacGia);
                lsv_CacLoaiSach.Items.Add(item);
            }
        }


        //khi items được chọn trong listview thay đổi
        private void lsv_DanhSachLoaiSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_DanhSachLoaiSach.SelectedItems.Count > 0)
            {
                txtMaLoaiSach.Text = lsv_DanhSachLoaiSach.SelectedItems[0].SubItems[0].Text;
                txtTenLoaiSach.Text = lsv_DanhSachLoaiSach.SelectedItems[0].SubItems[1].Text;
                txtKieuSach.Text = lsv_DanhSachLoaiSach.SelectedItems[0].SubItems[2].Text;
            }
        }
        private void lsv_CacLoaiSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lsv_CacLoaiSach.SelectedItems.Count > 0)
            {
                txtMaSach.Text = lsv_CacLoaiSach.SelectedItems[0].SubItems[0].Text;
                txtTenSach.Text = lsv_CacLoaiSach.SelectedItems[0].SubItems[1].Text;
                cmbMaLoaiSach.Text = lsv_CacLoaiSach.SelectedItems[0].SubItems[2].Text;
                txtSoLuong.Text = lsv_CacLoaiSach.SelectedItems[0].SubItems[3].Text;
                cmbMaTacGia.Text = lsv_CacLoaiSach.SelectedItems[0].SubItems[4].Text;
            }
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
            if (lsv_DanhSachLoaiSach.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    lsv_DanhSachLoaiSach.Items.Remove(lsv_DanhSachLoaiSach.SelectedItems[0]);
                }
                loaiSach.Clear();
                for (int i = 0; i < lsv_DanhSachLoaiSach.Items.Count; i++)
                {
                    loaiSach.Add(new LoaiSach() { maLoaiSach = lsv_DanhSachLoaiSach.Items[i].SubItems[0].Text, tenLoaiSach = lsv_DanhSachLoaiSach.Items[i].SubItems[1].Text, kieuSach = lsv_DanhSachLoaiSach.Items[i].SubItems[2].Text });
                }
            }
        }
        private void btnXoa1_Click(object sender, EventArgs e)
        {
                if (lsv_CacLoaiSach.SelectedItems.Count > 0)
                {
                    if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    {
                        lsv_CacLoaiSach.Items.Remove(lsv_CacLoaiSach.SelectedItems[0]);
                    }
                    Sach.Clear();
                    for (int i = 0; i < lsv_CacLoaiSach.Items.Count; i++)
                    {
                        Sach.Add(new Sach() { maSach = lsv_CacLoaiSach.Items[i].SubItems[0].Text, tenSach = lsv_CacLoaiSach.Items[i].SubItems[1].Text, maLoaiSach = lsv_CacLoaiSach.Items[i].SubItems[2].Text, soLuong = int.Parse(lsv_CacLoaiSach.Items[i].SubItems[3].Text), maTacGia = lsv_CacLoaiSach.Items[i].SubItems[4].Text });
                    }
                }
        }


        //button sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lsv_DanhSachLoaiSach.SelectedItems.Count > 0)
            {
                lsv_DanhSachLoaiSach.SelectedItems[0].SubItems[0].Text = null;
                lsv_DanhSachLoaiSach.SelectedItems[0].SubItems[1].Text = null;
                lsv_DanhSachLoaiSach.SelectedItems[0].SubItems[2].Text = null;
                lsv_DanhSachLoaiSach.SelectedItems[0].SubItems[0].Text = txtMaLoaiSach.Text;
                lsv_DanhSachLoaiSach.SelectedItems[0].SubItems[1].Text = txtTenLoaiSach.Text;
                lsv_DanhSachLoaiSach.SelectedItems[0].SubItems[2].Text = txtKieuSach.Text;
                loaiSach.Clear();
                for (int i = 0; i < lsv_DanhSachLoaiSach.Items.Count; i++)
                {
                    loaiSach.Add(new LoaiSach() { maLoaiSach = lsv_DanhSachLoaiSach.Items[i].SubItems[0].Text, tenLoaiSach = lsv_DanhSachLoaiSach.Items[i].SubItems[1].Text, kieuSach = lsv_DanhSachLoaiSach.Items[i].SubItems[2].Text });
                }
            }
        }
        private void btnSua1_Click(object sender, EventArgs e)
        {
            if (lsv_CacLoaiSach.SelectedItems.Count > 0)
            {
                lsv_CacLoaiSach.SelectedItems[0].SubItems[0].Text = null;
                lsv_CacLoaiSach.SelectedItems[0].SubItems[1].Text = null;
                lsv_CacLoaiSach.SelectedItems[0].SubItems[2].Text = null;
                lsv_CacLoaiSach.SelectedItems[0].SubItems[3].Text = null;
                lsv_CacLoaiSach.SelectedItems[0].SubItems[4].Text = null;
                lsv_CacLoaiSach.SelectedItems[0].SubItems[0].Text = txtMaSach.Text;
                lsv_CacLoaiSach.SelectedItems[0].SubItems[1].Text = txtTenSach.Text;
                lsv_CacLoaiSach.SelectedItems[0].SubItems[2].Text = cmbMaLoaiSach.Text;
                lsv_CacLoaiSach.SelectedItems[0].SubItems[3].Text = txtSoLuong.Text;
                lsv_CacLoaiSach.SelectedItems[0].SubItems[4].Text = cmbMaTacGia.Text;
                Sach.Clear();
                for (int i = 0; i < lsv_CacLoaiSach.Items.Count; i++)
                {
                    Sach.Add(new Sach() { maSach = lsv_CacLoaiSach.Items[i].SubItems[0].Text, tenSach = lsv_CacLoaiSach.Items[i].SubItems[1].Text, maLoaiSach = lsv_CacLoaiSach.Items[i].SubItems[2].Text, soLuong = int.Parse(lsv_CacLoaiSach.Items[i].SubItems[3].Text), maTacGia = lsv_CacLoaiSach.Items[i].SubItems[4].Text });
                }
            }
        }


        //button lưu sau khi thay đổi
        private void btnLuu_Click(object sender, EventArgs e)
        {
            String File_LoaiSach = currentDirectory + "/LoaiSach.txt";
            String[] str = new string[loaiSach.Count];
            for (int i = 0; i < loaiSach.Count; i++)
            {
                str[i] = lsv_DanhSachLoaiSach.Items[i].SubItems[0].Text + "," + lsv_DanhSachLoaiSach.Items[i].SubItems[1].Text + "," + lsv_DanhSachLoaiSach.Items[i].SubItems[2].Text;
            }
            File.WriteAllLines(File_LoaiSach, str);
        }
        private void btnLuu1_Click(object sender, EventArgs e)
        {
            String File_Sach = currentDirectory + "/Sach.txt";
            String[] str = new string[Sach.Count];
            for (int i = 0; i < Sach.Count; i++)
            {
                str[i] = lsv_CacLoaiSach.Items[i].SubItems[0].Text + "," + lsv_CacLoaiSach.Items[i].SubItems[1].Text + "," + lsv_CacLoaiSach.Items[i].SubItems[2].Text + "," + lsv_CacLoaiSach.Items[i].SubItems[3].Text + "," + lsv_CacLoaiSach.Items[i].SubItems[4].Text;
            }
            File.WriteAllLines(File_Sach, str);
        }


        //button thêm vào listview
        private void btnThem_Click(object sender, EventArgs e)
        {
            loaiSach.Add(new LoaiSach() { maLoaiSach = txtMaLoaiSach.Text, tenLoaiSach = txtTenLoaiSach.Text, kieuSach = txtKieuSach.Text });
            ListViewItem item = new ListViewItem(txtMaLoaiSach.Text);
            item.SubItems.Add(txtTenLoaiSach.Text);
            item.SubItems.Add(txtKieuSach.Text);
            lsv_DanhSachLoaiSach.Items.Add(item);
        }
        private void btnThem1_Click(object sender, EventArgs e)
        {
            Sach.Add(new Sach() { maSach = txtMaSach.Text, tenSach = txtTenSach.Text, maLoaiSach = cmbMaLoaiSach.Text, soLuong = int.Parse(txtSoLuong.Text), maTacGia = cmbMaTacGia.Text });
            ListViewItem item = new ListViewItem(txtMaSach.Text);
            item.SubItems.Add(txtTenSach.Text);
            item.SubItems.Add(cmbMaLoaiSach.Text);
            item.SubItems.Add(txtSoLuong.Text);
            item.SubItems.Add(cmbMaTacGia.Text);
            lsv_CacLoaiSach.Items.Add(item);
        }
    }
}
