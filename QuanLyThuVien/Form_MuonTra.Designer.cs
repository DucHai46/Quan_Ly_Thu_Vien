using System.Windows.Forms;

namespace QuanLyThuVien
{
    partial class Form_MuonTra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTinhTrangTraSach = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblMaTG = new System.Windows.Forms.Label();
            this.lblMaLoai = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblTenSach = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnTraSach = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvTraSach = new System.Windows.Forms.DataGridView();
            this.dtNgayTra = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.dtNgayHenTra_TraSach = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dtNgayMuon_TraSach = new System.Windows.Forms.DateTimePicker();
            this.txtSoLuong_TraSach = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtMaSach_TraSach = new System.Windows.Forms.ComboBox();
            this.cbMaDG_TraSach = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabmuon = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvChoMuon = new System.Windows.Forms.DataGridView();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.btnChoMuon = new System.Windows.Forms.Button();
            this.btnMuonMoi = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtNgayHenTra = new System.Windows.Forms.DateTimePicker();
            this.dtNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbMaDG = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbChonMaSach = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabtra = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraSach)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabmuon.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChoMuon)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabtra.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTinhTrangTraSach
            // 
            this.lblTinhTrangTraSach.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTinhTrangTraSach.Location = new System.Drawing.Point(641, 195);
            this.lblTinhTrangTraSach.Name = "lblTinhTrangTraSach";
            this.lblTinhTrangTraSach.Size = new System.Drawing.Size(175, 24);
            this.lblTinhTrangTraSach.TabIndex = 9;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(336, 178);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(158, 58);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblMaTG
            // 
            this.lblMaTG.BackColor = System.Drawing.Color.Gainsboro;
            this.lblMaTG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMaTG.Location = new System.Drawing.Point(153, 200);
            this.lblMaTG.Name = "lblMaTG";
            this.lblMaTG.Size = new System.Drawing.Size(180, 23);
            this.lblMaTG.TabIndex = 2;
            // 
            // lblMaLoai
            // 
            this.lblMaLoai.BackColor = System.Drawing.Color.Gainsboro;
            this.lblMaLoai.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMaLoai.Location = new System.Drawing.Point(153, 119);
            this.lblMaLoai.Name = "lblMaLoai";
            this.lblMaLoai.Size = new System.Drawing.Size(180, 23);
            this.lblMaLoai.TabIndex = 2;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.BackColor = System.Drawing.Color.Gainsboro;
            this.lblSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSoLuong.Location = new System.Drawing.Point(153, 158);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(180, 23);
            this.lblSoLuong.TabIndex = 2;
            // 
            // lblTenSach
            // 
            this.lblTenSach.BackColor = System.Drawing.Color.Gainsboro;
            this.lblTenSach.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTenSach.Location = new System.Drawing.Point(153, 81);
            this.lblTenSach.Name = "lblTenSach";
            this.lblTenSach.Size = new System.Drawing.Size(180, 23);
            this.lblTenSach.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã Loại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã Tác Giả:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số Lượng:";
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(172, 178);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(158, 58);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnTraSach
            // 
            this.btnTraSach.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnTraSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTraSach.Location = new System.Drawing.Point(8, 178);
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.Size = new System.Drawing.Size(158, 58);
            this.btnTraSach.TabIndex = 7;
            this.btnTraSach.Text = "Trả Sách";
            this.btnTraSach.UseVisualStyleBackColor = true;
            this.btnTraSach.Click += new System.EventHandler(this.btnTraSach_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvTraSach);
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox5.Location = new System.Drawing.Point(11, 242);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(818, 211);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh Sách Trả Sách";
            // 
            // dgvTraSach
            // 
            this.dgvTraSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTraSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTraSach.Location = new System.Drawing.Point(3, 25);
            this.dgvTraSach.Name = "dgvTraSach";
            this.dgvTraSach.Size = new System.Drawing.Size(812, 183);
            this.dgvTraSach.TabIndex = 0;
            // 
            // dtNgayTra
            // 
            this.dtNgayTra.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.dtNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayTra.Location = new System.Drawing.Point(615, 121);
            this.dtNgayTra.Name = "dtNgayTra";
            this.dtNgayTra.Size = new System.Drawing.Size(181, 29);
            this.dtNgayTra.TabIndex = 17;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(486, 125);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 22);
            this.label17.TabIndex = 16;
            this.label17.Text = "Ngày Trả:";
            // 
            // dtNgayHenTra_TraSach
            // 
            this.dtNgayHenTra_TraSach.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.dtNgayHenTra_TraSach.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayHenTra_TraSach.Location = new System.Drawing.Point(615, 71);
            this.dtNgayHenTra_TraSach.Name = "dtNgayHenTra_TraSach";
            this.dtNgayHenTra_TraSach.Size = new System.Drawing.Size(181, 29);
            this.dtNgayHenTra_TraSach.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(486, 80);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(131, 22);
            this.label16.TabIndex = 14;
            this.label16.Text = "Ngày Hẹn Trả:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(356, 221);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(181, 29);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // dtNgayMuon_TraSach
            // 
            this.dtNgayMuon_TraSach.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.dtNgayMuon_TraSach.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayMuon_TraSach.Location = new System.Drawing.Point(615, 27);
            this.dtNgayMuon_TraSach.Name = "dtNgayMuon_TraSach";
            this.dtNgayMuon_TraSach.Size = new System.Drawing.Size(181, 29);
            this.dtNgayMuon_TraSach.TabIndex = 13;
            // 
            // txtSoLuong_TraSach
            // 
            this.txtSoLuong_TraSach.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtSoLuong_TraSach.Location = new System.Drawing.Point(162, 123);
            this.txtSoLuong_TraSach.Name = "txtSoLuong_TraSach";
            this.txtSoLuong_TraSach.ReadOnly = true;
            this.txtSoLuong_TraSach.Size = new System.Drawing.Size(181, 29);
            this.txtSoLuong_TraSach.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ngày Hẹn Trả:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(486, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 22);
            this.label7.TabIndex = 4;
            this.label7.Text = "Ngày Mượn:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(16, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "Số Lượng Mượn:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(16, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 22);
            this.label9.TabIndex = 6;
            this.label9.Text = "Mã Sách:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(16, 37);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 22);
            this.label15.TabIndex = 5;
            this.label15.Text = "Mã Độc Giả:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtMaSach_TraSach);
            this.groupBox4.Controls.Add(this.dtNgayTra);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.dtNgayHenTra_TraSach);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.dateTimePicker1);
            this.groupBox4.Controls.Add(this.dtNgayMuon_TraSach);
            this.groupBox4.Controls.Add(this.txtSoLuong_TraSach);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.cbMaDG_TraSach);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox4.Location = new System.Drawing.Point(8, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(830, 172);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thực Hiện Trả Sách";
            // 
            // txtMaSach_TraSach
            // 
            this.txtMaSach_TraSach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtMaSach_TraSach.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtMaSach_TraSach.FormattingEnabled = true;
            this.txtMaSach_TraSach.Location = new System.Drawing.Point(164, 73);
            this.txtMaSach_TraSach.Name = "txtMaSach_TraSach";
            this.txtMaSach_TraSach.Size = new System.Drawing.Size(181, 30);
            this.txtMaSach_TraSach.TabIndex = 18;
            this.txtMaSach_TraSach.TextChanged += new System.EventHandler(this.txtMaSach_TraSach_TextChanged);
            // 
            // cbMaDG_TraSach
            // 
            this.cbMaDG_TraSach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaDG_TraSach.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.cbMaDG_TraSach.FormattingEnabled = true;
            this.cbMaDG_TraSach.Location = new System.Drawing.Point(162, 28);
            this.cbMaDG_TraSach.Name = "cbMaDG_TraSach";
            this.cbMaDG_TraSach.Size = new System.Drawing.Size(181, 30);
            this.cbMaDG_TraSach.TabIndex = 9;
            this.cbMaDG_TraSach.TextChanged += new System.EventHandler(this.cbMaDG_TraSach_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Sách:";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabmuon);
            this.tabControl1.Controls.Add(this.tabtra);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(850, 491);
            this.tabControl1.TabIndex = 1;
            // 
            // tabmuon
            // 
            this.tabmuon.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tabmuon.Controls.Add(this.groupBox3);
            this.tabmuon.Controls.Add(this.btnKetThuc);
            this.tabmuon.Controls.Add(this.btnChoMuon);
            this.tabmuon.Controls.Add(this.btnMuonMoi);
            this.tabmuon.Controls.Add(this.groupBox2);
            this.tabmuon.Controls.Add(this.groupBox1);
            this.tabmuon.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.tabmuon.Location = new System.Drawing.Point(4, 33);
            this.tabmuon.Name = "tabmuon";
            this.tabmuon.Padding = new System.Windows.Forms.Padding(3);
            this.tabmuon.Size = new System.Drawing.Size(842, 454);
            this.tabmuon.TabIndex = 0;
            this.tabmuon.Text = "Quản Lý Mượn Sách";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvChoMuon);
            this.groupBox3.Location = new System.Drawing.Point(10, 255);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(831, 187);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Cho Mượn";
            // 
            // dgvChoMuon
            // 
            this.dgvChoMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChoMuon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChoMuon.Location = new System.Drawing.Point(3, 25);
            this.dgvChoMuon.Name = "dgvChoMuon";
            this.dgvChoMuon.Size = new System.Drawing.Size(825, 159);
            this.dgvChoMuon.TabIndex = 0;
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKetThuc.Location = new System.Drawing.Point(708, 139);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(116, 34);
            this.btnKetThuc.TabIndex = 4;
            this.btnKetThuc.Text = "Kết Thúc";
            this.btnKetThuc.UseVisualStyleBackColor = true;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // btnChoMuon
            // 
            this.btnChoMuon.Location = new System.Drawing.Point(708, 91);
            this.btnChoMuon.Name = "btnChoMuon";
            this.btnChoMuon.Size = new System.Drawing.Size(116, 39);
            this.btnChoMuon.TabIndex = 3;
            this.btnChoMuon.Text = "Cho Mượn";
            this.btnChoMuon.UseVisualStyleBackColor = true;
            this.btnChoMuon.Click += new System.EventHandler(this.btnChoMuon_Click);
            // 
            // btnMuonMoi
            // 
            this.btnMuonMoi.Location = new System.Drawing.Point(708, 41);
            this.btnMuonMoi.Name = "btnMuonMoi";
            this.btnMuonMoi.Size = new System.Drawing.Size(116, 40);
            this.btnMuonMoi.TabIndex = 2;
            this.btnMuonMoi.Text = "Mượn Mới";
            this.btnMuonMoi.UseVisualStyleBackColor = true;
            this.btnMuonMoi.Click += new System.EventHandler(this.btnMuonMoi_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtNgayHenTra);
            this.groupBox2.Controls.Add(this.dtNgayMuon);
            this.groupBox2.Controls.Add(this.txtSoLuong);
            this.groupBox2.Controls.Add(this.txtMaSach);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cbMaDG);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(355, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 241);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thực Hiện Cho Mượn";
            // 
            // dtNgayHenTra
            // 
            this.dtNgayHenTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayHenTra.Location = new System.Drawing.Point(166, 200);
            this.dtNgayHenTra.Name = "dtNgayHenTra";
            this.dtNgayHenTra.Size = new System.Drawing.Size(158, 29);
            this.dtNgayHenTra.TabIndex = 3;
            // 
            // dtNgayMuon
            // 
            this.dtNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayMuon.Location = new System.Drawing.Point(166, 158);
            this.dtNgayMuon.Name = "dtNgayMuon";
            this.dtNgayMuon.Size = new System.Drawing.Size(158, 29);
            this.dtNgayMuon.TabIndex = 3;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(166, 116);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(158, 29);
            this.txtSoLuong.TabIndex = 2;
            // 
            // txtMaSach
            // 
            this.txtMaSach.BackColor = System.Drawing.Color.Gainsboro;
            this.txtMaSach.Location = new System.Drawing.Point(166, 78);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.ReadOnly = true;
            this.txtMaSach.Size = new System.Drawing.Size(158, 29);
            this.txtMaSach.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 200);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(131, 22);
            this.label14.TabIndex = 0;
            this.label14.Text = "Ngày Hẹn Trả:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 163);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 22);
            this.label13.TabIndex = 0;
            this.label13.Text = "Ngày Mượn:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 22);
            this.label12.TabIndex = 0;
            this.label12.Text = "Số Lượng Mượn:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 22);
            this.label11.TabIndex = 0;
            this.label11.Text = "Mã Sách:";
            // 
            // cbMaDG
            // 
            this.cbMaDG.FormattingEnabled = true;
            this.cbMaDG.Location = new System.Drawing.Point(166, 44);
            this.cbMaDG.Name = "cbMaDG";
            this.cbMaDG.Size = new System.Drawing.Size(158, 30);
            this.cbMaDG.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 22);
            this.label10.TabIndex = 0;
            this.label10.Text = "Mã Độc Giả:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMaTG);
            this.groupBox1.Controls.Add(this.lblMaLoai);
            this.groupBox1.Controls.Add(this.lblSoLuong);
            this.groupBox1.Controls.Add(this.lblTenSach);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbChonMaSach);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 242);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sách";
            // 
            // cbChonMaSach
            // 
            this.cbChonMaSach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChonMaSach.FormattingEnabled = true;
            this.cbChonMaSach.Location = new System.Drawing.Point(154, 45);
            this.cbChonMaSach.Name = "cbChonMaSach";
            this.cbChonMaSach.Size = new System.Drawing.Size(181, 30);
            this.cbChonMaSach.TabIndex = 1;
            this.cbChonMaSach.TextChanged += new System.EventHandler(this.cbChonMaSach_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn Mã Sách:";
            // 
            // tabtra
            // 
            this.tabtra.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tabtra.Controls.Add(this.lblTinhTrangTraSach);
            this.tabtra.Controls.Add(this.label18);
            this.tabtra.Controls.Add(this.btnThoat);
            this.tabtra.Controls.Add(this.btnLuu);
            this.tabtra.Controls.Add(this.btnTraSach);
            this.tabtra.Controls.Add(this.groupBox5);
            this.tabtra.Controls.Add(this.groupBox4);
            this.tabtra.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.tabtra.Location = new System.Drawing.Point(4, 33);
            this.tabtra.Name = "tabtra";
            this.tabtra.Padding = new System.Windows.Forms.Padding(3);
            this.tabtra.Size = new System.Drawing.Size(842, 454);
            this.tabtra.TabIndex = 1;
            this.tabtra.Text = "Quản Lý Trả Sách";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(548, 199);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(87, 22);
            this.label18.TabIndex = 8;
            this.label18.Text = "Trả sách:";
            // 
            // Form_MuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 494);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_MuonTra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mượn Trả Sách";
            this.Load += new System.EventHandler(this.Form_MuonTra_Load);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraSach)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabmuon.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChoMuon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabtra.ResumeLayout(false);
            this.tabtra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblTinhTrangTraSach;
        private Button btnThoat;
        private Label lblMaTG;
        private Label lblMaLoai;
        private Label lblSoLuong;
        private Label lblTenSach;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnLuu;
        private Button btnTraSach;
        private GroupBox groupBox5;
        private DateTimePicker dtNgayTra;
        private Label label17;
        private DateTimePicker dtNgayHenTra_TraSach;
        private Label label16;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dtNgayMuon_TraSach;
        private TextBox txtSoLuong_TraSach;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label15;
        private GroupBox groupBox4;
        private ComboBox cbMaDG_TraSach;
        private Label label2;
        private TabControl tabControl1;
        private TabPage tabmuon;
        private GroupBox groupBox3;
        private Button btnKetThuc;
        private Button btnChoMuon;
        private Button btnMuonMoi;
        private GroupBox groupBox2;
        private DateTimePicker dtNgayHenTra;
        private DateTimePicker dtNgayMuon;
        private TextBox txtSoLuong;
        private TextBox txtMaSach;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private ComboBox cbMaDG;
        private Label label10;
        private GroupBox groupBox1;
        private ComboBox cbChonMaSach;
        private Label label1;
        private TabPage tabtra;
        private ComboBox txtMaSach_TraSach;
        private DataGridView dgvChoMuon;
        private Label label18;
        private DataGridView dgvTraSach;
    }
}
