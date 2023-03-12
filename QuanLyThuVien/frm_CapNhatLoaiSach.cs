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
    public partial class frm_CapNhatLoaiSach : Form
    {
        public frm_CapNhatLoaiSach()
        {
            InitializeComponent();
        }
        private void frm_CapNhatLoaiSach_Load(object sender, EventArgs e)
        {
            KhoiTaoLsv_DanhSachLoaiSach();
            Add_lsv(loaiSach);
        }
        private List<LoaiSach> loaiSach = new List<LoaiSach>();

        public void KhoiTaoLsv_DanhSachLoaiSach()
        {
            lsv_DanhSachLoaiSach.Columns.Add("Mã Loại Sách", 120);
            lsv_DanhSachLoaiSach.Columns.Add("Tên Loại Sách", 200);
            lsv_DanhSachLoaiSach.Columns.Add("Kiểu Sách", 450);

            lsv_DanhSachLoaiSach.View = View.Details;
        }
        
        public void KhoiTaoLsv_LoaiSach()
        {
            string currentDirectory = System.IO.Directory.GetCurrentDirectory() + "/Data";
            FileText ft = new FileText();
            ft.FileName = currentDirectory + "/LoaiSach.txt";
            String[] str = ft.ReadLoaiSach();
            for (int i = 0; i < str.Length; i++)
            {
                String[] parts = str[i].Split(',');
                loaiSach.Add(new LoaiSach() { maLoaiSach = parts[0], tenLoaiSach = parts[1], kieuSach = parts[2] });
            }
        }
        private void Add_lsv(List<LoaiSach> saches)
        {
            KhoiTaoLsv_LoaiSach();
            foreach (LoaiSach loaiSach in saches)
            {
                ListViewItem item = new ListViewItem(loaiSach.maLoaiSach);
                item.SubItems.Add(loaiSach.tenLoaiSach);
                item.SubItems.Add(loaiSach.kieuSach);
                lsv_DanhSachLoaiSach.Items.Add(item);
            }
        }
        private void lsv_DanhSachLoaiSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_DanhSachLoaiSach.SelectedItems.Count > 0)
            {
                txtMaLoaiSach.Text = lsv_DanhSachLoaiSach.SelectedItems[0].SubItems[0].Text;
                txtTenLoaiSach.Text = lsv_DanhSachLoaiSach.SelectedItems[0].SubItems[1].Text;
                txtKieuSach.Text = lsv_DanhSachLoaiSach.SelectedItems[0].SubItems[2].Text;
            }
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (lsv_DanhSachLoaiSach.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    for (int i = 0; i <= lsv_DanhSachLoaiSach.Items.Count; i++)
                    {
                        LoaiSach item = loaiSach[i];
                        if(item.maLoaiSach == lsv_DanhSachLoaiSach.SelectedItems[0].SubItems[0].Text)
                        {
                            loaiSach.Remove(item);
                        }
                    }
                    lsv_DanhSachLoaiSach.Items.Remove(lsv_DanhSachLoaiSach.SelectedItems[0]);
                }
               /* loaiSach.Clear();
                for (int i = 0; i < lsv_DanhSachLoaiSach.Items.Count; i++)
                {
                    loaiSach.Add(new LoaiSach() { maLoaiSach = lsv_DanhSachLoaiSach.Items[i].SubItems[0].Text, tenLoaiSach = lsv_DanhSachLoaiSach.Items[i].SubItems[1].Text, kieuSach = lsv_DanhSachLoaiSach.Items[i].SubItems[2].Text });
                }*/
            }
        }

    }
}
