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
namespace QuanLyThuVien
{
    public partial class frm_DanhMuc : Form
    {
        public frm_DanhMuc()
        {
            InitializeComponent();
        }
        private void frm_DanhMuc_Load(object sender, EventArgs e)
        {
            KhoiTaoLsv_DanhSach();
            KhoiTao_Sach();
            lsbLoaiSach.DataSource = KhoiTaoLsb_LoaiSach();
            lsbLoaiSach.DisplayMember = "tenLoaiSach";
            lsbLoaiSach.ValueMember = "maLoaiSach";
        }

        private List<Sach> sachTH = new List<Sach>();
        private List<Sach> sachTC = new List<Sach>();
        private List<Sach> sachGK = new List<Sach>();
        private List<Sach> sachTT = new List<Sach>();
        private List<Sach> sachKT = new List<Sach>();
        public List<LoaiSach> KhoiTaoLsb_LoaiSach()
        {
            List<LoaiSach> loaiSach = new List<LoaiSach>();
            FileText ft = new FileText();
            string currentDirectory = System.IO.Directory.GetCurrentDirectory() + "/Data";
            ft.FileName = currentDirectory + "/LoaiSach.txt";
            String[] str = ft.ReadLoaiSach();
            for (int i = 0; i < str.Length; i++)
            {
                String[] parts = str[i].Split(',');
                loaiSach.Add(new LoaiSach() { maLoaiSach = parts[0], tenLoaiSach = parts[1], kieuSach = parts[2] });
            }
            return loaiSach;
        }
        public void KhoiTaoLsv_DanhSach()
        {
            lsvDanhSach.Columns.Add("Mã Sách", 100);
            lsvDanhSach.Columns.Add("Tên Sách", 125);
            lsvDanhSach.Columns.Add("Mã Loại Sách", 130);
            lsvDanhSach.Columns.Add("Số Lượng", 100);
            lsvDanhSach.Columns.Add("Mã Tác Giả", 100);
            lsvDanhSach.View = View.Details;
        }
        public void KhoiTao_Sach()
        {

            FileText ft = new FileText();
            string currentDirectory = System.IO.Directory.GetCurrentDirectory() + "/Data";
            ft.FileName = currentDirectory + "/Sach.txt";
            String[] str = ft.ReadSach();
            for (int i = 0; i < str.Length; i++)
            {
                String[] parts = str[i].Split(',');
                switch (parts[2]) { 
                case "TH":
                        sachTH.Add(new Sach() { maSach = parts[0], tenSach = parts[1], maLoaiSach = parts[2], soLuong = Convert.ToInt32(parts[3]), maTacGia = parts[4] }); break;
                case "TC":
                        sachTC.Add(new Sach() { maSach = parts[0], tenSach = parts[1], maLoaiSach = parts[2], soLuong = Convert.ToInt32(parts[3]), maTacGia = parts[4] }); break;
                case "SGK":
                        sachGK.Add(new Sach() { maSach = parts[0], tenSach = parts[1], maLoaiSach = parts[2], soLuong = Convert.ToInt32(parts[3]), maTacGia = parts[4] }); break;
                case "TT":
                        sachTT.Add(new Sach() { maSach = parts[0], tenSach = parts[1], maLoaiSach = parts[2], soLuong = Convert.ToInt32(parts[3]), maTacGia = parts[4] }); break;
                case "KT":
                        sachKT.Add(new Sach() { maSach = parts[0], tenSach = parts[1], maLoaiSach = parts[2], soLuong = Convert.ToInt32(parts[3]), maTacGia = parts[4] }); break;
                }
            }
        }
        private void Add_lsv(List<Sach> saches)
        {
            lsvDanhSach.Clear();
            KhoiTaoLsv_DanhSach();
            foreach (Sach sach in saches)
            {
                ListViewItem item = new ListViewItem(sach.maSach);
                item.SubItems.Add(sach.tenSach);
                item.SubItems.Add(sach.maLoaiSach);
                item.SubItems.Add(sach.soLuong.ToString());
                item.SubItems.Add(sach.maTacGia);
                lsvDanhSach.Items.Add(item);
            }
        }
        private void lsbLoaiSach_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (lsbLoaiSach.SelectedValue.ToString())
            {
                case "TH":

                    Add_lsv(sachTH); break;
                case "TC":

                    Add_lsv(sachTC); break;
                case "SGK":

                    Add_lsv(sachGK); break;
                case "TT":

                    Add_lsv(sachTT); break;
                case "KT":

                    Add_lsv(sachKT); break;
            }
        }
        private void lsvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lsvDanhSach.SelectedItems.Count > 0)
            {
                txtMaSach.Text = lsvDanhSach.SelectedItems[0].SubItems[0].Text;
                txtTenSach.Text = lsvDanhSach.SelectedItems[0].SubItems[1].Text;
                txtMaLoai.Text = lsvDanhSach.SelectedItems[0].SubItems[2].Text;
                txtSoLuong.Text = lsvDanhSach.SelectedItems[0].SubItems[3].Text;
                txtMaTacGia.Text = lsvDanhSach.SelectedItems[0].SubItems[4].Text;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            frm_CapNhat frmCapNhat = new frm_CapNhat();
            frmCapNhat.ShowDialog();
        }
    }
}
