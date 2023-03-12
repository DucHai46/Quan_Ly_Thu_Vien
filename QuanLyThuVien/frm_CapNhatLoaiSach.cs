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
        public void KhoiTaoLsv_DanhSachLoaiSach()
        {
            lsv_DanhSachLoaiSach.Columns.Add("Mã Loại Sách", 120);
            lsv_DanhSachLoaiSach.Columns.Add("Tên Loại Sách", 200);
            lsv_DanhSachLoaiSach.Columns.Add("Kiểu Sách", 450);

            lsv_DanhSachLoaiSach.View = View.Details;
        }
        
        private List<LoaiSach> loaiSach = new List<LoaiSach>();
        public void KhoiTaoLsv_LoaiSach()
        {
            FileText ft = new FileText();
            ft.FileName = @"E:\tailieu\winform\baitap\QuanLyThuVien\LoaiSach.txt";
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
            foreach (LoaiSach  loaiSach in saches)
            {
                ListViewItem item = new ListViewItem(loaiSach.maLoaiSach);
                item.SubItems.Add(loaiSach.tenLoaiSach);
                item.SubItems.Add(loaiSach.kieuSach);
                lsv_DanhSachLoaiSach.Items.Add(item);
            }
        }
    }
}
