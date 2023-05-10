namespace QuanLyThuVien_Demo
{
    partial class frm_CapNhat
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tctCapNhat = new System.Windows.Forms.TabControl();
            this.tpg1 = new System.Windows.Forms.TabPage();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvLoaiSach = new System.Windows.Forms.DataGridView();
            this.btnSua = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTenLoaiSach = new System.Windows.Forms.TextBox();
            this.txtKieuSach = new System.Windows.Forms.TextBox();
            this.txtMaLoaiSach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.tpg2 = new System.Windows.Forms.TabPage();
            this.btnThem1 = new System.Windows.Forms.Button();
            this.btnThoat1 = new System.Windows.Forms.Button();
            this.btnXoa1 = new System.Windows.Forms.Button();
            this.btnSua1 = new System.Windows.Forms.Button();
            this.btnReset1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbMaLoaiSach = new System.Windows.Forms.ComboBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbTacGia = new System.Windows.Forms.ComboBox();
            this.tctCapNhat.SuspendLayout();
            this.tpg1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSach)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tpg2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tctCapNhat
            // 
            this.tctCapNhat.Controls.Add(this.tpg1);
            this.tctCapNhat.Controls.Add(this.tpg2);
            this.tctCapNhat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tctCapNhat.Location = new System.Drawing.Point(0, 0);
            this.tctCapNhat.Name = "tctCapNhat";
            this.tctCapNhat.SelectedIndex = 0;
            this.tctCapNhat.Size = new System.Drawing.Size(800, 450);
            this.tctCapNhat.TabIndex = 0;
            // 
            // tpg1
            // 
            this.tpg1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tpg1.Controls.Add(this.btnThem);
            this.tpg1.Controls.Add(this.btnThoat);
            this.tpg1.Controls.Add(this.btnXoa);
            this.tpg1.Controls.Add(this.groupBox2);
            this.tpg1.Controls.Add(this.btnSua);
            this.tpg1.Controls.Add(this.groupBox1);
            this.tpg1.Controls.Add(this.btnReset);
            this.tpg1.Location = new System.Drawing.Point(4, 22);
            this.tpg1.Name = "tpg1";
            this.tpg1.Padding = new System.Windows.Forms.Padding(3);
            this.tpg1.Size = new System.Drawing.Size(792, 424);
            this.tpg1.TabIndex = 0;
            this.tpg1.Text = "Cập Nhật Loại Sách";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(21, 178);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(130, 50);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(662, 178);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(112, 50);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(501, 178);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(130, 50);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvLoaiSach);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(783, 190);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Loại Sách";
            // 
            // dgvLoaiSach
            // 
            this.dgvLoaiSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLoaiSach.Location = new System.Drawing.Point(3, 25);
            this.dgvLoaiSach.Name = "dgvLoaiSach";
            this.dgvLoaiSach.Size = new System.Drawing.Size(777, 162);
            this.dgvLoaiSach.TabIndex = 0;
            this.dgvLoaiSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiSach_CellContentClick);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(342, 178);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(130, 50);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.txtTenLoaiSach);
            this.groupBox1.Controls.Add(this.txtKieuSach);
            this.groupBox1.Controls.Add(this.txtMaLoaiSach);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(778, 156);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi Tiết Loại Sách";
            // 
            // txtTenLoaiSach
            // 
            this.txtTenLoaiSach.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoaiSach.Location = new System.Drawing.Point(179, 116);
            this.txtTenLoaiSach.Multiline = true;
            this.txtTenLoaiSach.Name = "txtTenLoaiSach";
            this.txtTenLoaiSach.Size = new System.Drawing.Size(201, 23);
            this.txtTenLoaiSach.TabIndex = 1;
            // 
            // txtKieuSach
            // 
            this.txtKieuSach.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKieuSach.Location = new System.Drawing.Point(514, 49);
            this.txtKieuSach.Multiline = true;
            this.txtKieuSach.Name = "txtKieuSach";
            this.txtKieuSach.Size = new System.Drawing.Size(201, 23);
            this.txtKieuSach.TabIndex = 2;
            // 
            // txtMaLoaiSach
            // 
            this.txtMaLoaiSach.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLoaiSach.Location = new System.Drawing.Point(179, 49);
            this.txtMaLoaiSach.Multiline = true;
            this.txtMaLoaiSach.Name = "txtMaLoaiSach";
            this.txtMaLoaiSach.Size = new System.Drawing.Size(201, 23);
            this.txtMaLoaiSach.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(406, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kiểu Sách:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Loại Sách:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Loại Sách:";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(177, 178);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(130, 50);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tpg2
            // 
            this.tpg2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tpg2.Controls.Add(this.btnThem1);
            this.tpg2.Controls.Add(this.btnThoat1);
            this.tpg2.Controls.Add(this.btnXoa1);
            this.tpg2.Controls.Add(this.btnSua1);
            this.tpg2.Controls.Add(this.btnReset1);
            this.tpg2.Controls.Add(this.groupBox4);
            this.tpg2.Controls.Add(this.groupBox3);
            this.tpg2.Location = new System.Drawing.Point(4, 22);
            this.tpg2.Name = "tpg2";
            this.tpg2.Padding = new System.Windows.Forms.Padding(3);
            this.tpg2.Size = new System.Drawing.Size(792, 424);
            this.tpg2.TabIndex = 1;
            this.tpg2.Text = "Cập Nhật Sách";
            // 
            // btnThem1
            // 
            this.btnThem1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem1.Location = new System.Drawing.Point(16, 179);
            this.btnThem1.Name = "btnThem1";
            this.btnThem1.Size = new System.Drawing.Size(130, 50);
            this.btnThem1.TabIndex = 11;
            this.btnThem1.Text = "Thêm";
            this.btnThem1.UseVisualStyleBackColor = true;
            this.btnThem1.Click += new System.EventHandler(this.btnThem1_Click);
            // 
            // btnThoat1
            // 
            this.btnThoat1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat1.Location = new System.Drawing.Point(657, 179);
            this.btnThoat1.Name = "btnThoat1";
            this.btnThoat1.Size = new System.Drawing.Size(112, 50);
            this.btnThoat1.TabIndex = 10;
            this.btnThoat1.Text = "Thoát";
            this.btnThoat1.UseVisualStyleBackColor = true;
            this.btnThoat1.Click += new System.EventHandler(this.btnThoat1_Click);
            // 
            // btnXoa1
            // 
            this.btnXoa1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa1.Location = new System.Drawing.Point(500, 179);
            this.btnXoa1.Name = "btnXoa1";
            this.btnXoa1.Size = new System.Drawing.Size(130, 50);
            this.btnXoa1.TabIndex = 7;
            this.btnXoa1.Text = "Xóa";
            this.btnXoa1.UseVisualStyleBackColor = true;
            this.btnXoa1.Click += new System.EventHandler(this.btnXoa1_Click);
            // 
            // btnSua1
            // 
            this.btnSua1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua1.Location = new System.Drawing.Point(337, 179);
            this.btnSua1.Name = "btnSua1";
            this.btnSua1.Size = new System.Drawing.Size(130, 50);
            this.btnSua1.TabIndex = 8;
            this.btnSua1.Text = "Sửa";
            this.btnSua1.UseVisualStyleBackColor = true;
            this.btnSua1.Click += new System.EventHandler(this.btnSua1_Click);
            // 
            // btnReset1
            // 
            this.btnReset1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset1.Location = new System.Drawing.Point(172, 179);
            this.btnReset1.Name = "btnReset1";
            this.btnReset1.Size = new System.Drawing.Size(130, 50);
            this.btnReset1.TabIndex = 9;
            this.btnReset1.Text = "Reset";
            this.btnReset1.UseVisualStyleBackColor = true;
            this.btnReset1.Click += new System.EventHandler(this.btnReset1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvSach);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(0, 234);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(792, 190);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh Sách Các Loại Sách";
            // 
            // dgvSach
            // 
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSach.Location = new System.Drawing.Point(3, 25);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.Size = new System.Drawing.Size(786, 162);
            this.dgvSach.TabIndex = 0;
            this.dgvSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSach_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbTacGia);
            this.groupBox3.Controls.Add(this.cmbMaLoaiSach);
            this.groupBox3.Controls.Add(this.txtSoLuong);
            this.groupBox3.Controls.Add(this.txtTenSach);
            this.groupBox3.Controls.Add(this.txtMaSach);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(789, 167);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi Tiết Sách";
            // 
            // cmbMaLoaiSach
            // 
            this.cmbMaLoaiSach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaLoaiSach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaLoaiSach.FormattingEnabled = true;
            this.cmbMaLoaiSach.Location = new System.Drawing.Point(155, 107);
            this.cmbMaLoaiSach.Name = "cmbMaLoaiSach";
            this.cmbMaLoaiSach.Size = new System.Drawing.Size(193, 27);
            this.cmbMaLoaiSach.TabIndex = 2;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(482, 73);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(193, 25);
            this.txtSoLuong.TabIndex = 1;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSach.Location = new System.Drawing.Point(155, 73);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(193, 25);
            this.txtTenSach.TabIndex = 1;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSach.Location = new System.Drawing.Point(155, 36);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(193, 25);
            this.txtMaSach.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(382, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số Lượng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(382, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã Tác Giả:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã Loại Sách:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên Sách:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(42, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã Sách:";
            // 
            // cmbTacGia
            // 
            this.cmbTacGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTacGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTacGia.FormattingEnabled = true;
            this.cmbTacGia.Location = new System.Drawing.Point(482, 34);
            this.cmbTacGia.Name = "cmbTacGia";
            this.cmbTacGia.Size = new System.Drawing.Size(193, 27);
            this.cmbTacGia.TabIndex = 3;
            // 
            // frm_CapNhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tctCapNhat);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "frm_CapNhat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cập Nhật Thông Tin Sách";
            this.Load += new System.EventHandler(this.frm_CapNhat_Load);
            this.tctCapNhat.ResumeLayout(false);
            this.tpg1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tpg2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tctCapNhat;
        private System.Windows.Forms.TabPage tpg1;
        private System.Windows.Forms.TabPage tpg2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTenLoaiSach;
        private System.Windows.Forms.TextBox txtKieuSach;
        private System.Windows.Forms.TextBox txtMaLoaiSach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnThem1;
        private System.Windows.Forms.Button btnThoat1;
        private System.Windows.Forms.Button btnXoa1;
        private System.Windows.Forms.Button btnSua1;
        private System.Windows.Forms.Button btnReset1;
        private System.Windows.Forms.DataGridView dgvLoaiSach;
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.ComboBox cmbMaLoaiSach;
        private System.Windows.Forms.ComboBox cmbTacGia;
    }
}