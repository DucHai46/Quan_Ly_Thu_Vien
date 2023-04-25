namespace QuanLyThuVien_Demo
{
    partial class frm_DanhMuc
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnMuonTra = new System.Windows.Forms.Button();
            this.btnQlTacGia = new System.Windows.Forms.Button();
            this.btnQlDocGia = new System.Windows.Forms.Button();
            this.btnCapNhap = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtMaTacGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtMaLoai = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvLoaiSach = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSach)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 455);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản Lý Thư Viện";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.btnKetThuc);
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Controls.Add(this.btnMuonTra);
            this.groupBox2.Controls.Add(this.btnQlTacGia);
            this.groupBox2.Controls.Add(this.btnQlDocGia);
            this.groupBox2.Controls.Add(this.btnCapNhap);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(0, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(797, 381);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.BackColor = System.Drawing.SystemColors.Control;
            this.btnKetThuc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKetThuc.Location = new System.Drawing.Point(591, 282);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(195, 46);
            this.btnKetThuc.TabIndex = 5;
            this.btnKetThuc.Text = "Kết Thúc";
            this.btnKetThuc.UseVisualStyleBackColor = false;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.Control;
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(591, 230);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(195, 46);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // btnMuonTra
            // 
            this.btnMuonTra.BackColor = System.Drawing.SystemColors.Control;
            this.btnMuonTra.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMuonTra.Location = new System.Drawing.Point(591, 178);
            this.btnMuonTra.Name = "btnMuonTra";
            this.btnMuonTra.Size = new System.Drawing.Size(195, 46);
            this.btnMuonTra.TabIndex = 3;
            this.btnMuonTra.Text = "Quản Lý Mượn Trả";
            this.btnMuonTra.UseVisualStyleBackColor = false;
            this.btnMuonTra.Click += new System.EventHandler(this.btnMuonTra_Click);
            // 
            // btnQlTacGia
            // 
            this.btnQlTacGia.BackColor = System.Drawing.SystemColors.Control;
            this.btnQlTacGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQlTacGia.Location = new System.Drawing.Point(591, 126);
            this.btnQlTacGia.Name = "btnQlTacGia";
            this.btnQlTacGia.Size = new System.Drawing.Size(195, 46);
            this.btnQlTacGia.TabIndex = 2;
            this.btnQlTacGia.Text = "Quản Lý Tác Giả";
            this.btnQlTacGia.UseVisualStyleBackColor = false;
            // 
            // btnQlDocGia
            // 
            this.btnQlDocGia.BackColor = System.Drawing.SystemColors.Control;
            this.btnQlDocGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQlDocGia.Location = new System.Drawing.Point(591, 74);
            this.btnQlDocGia.Name = "btnQlDocGia";
            this.btnQlDocGia.Size = new System.Drawing.Size(195, 46);
            this.btnQlDocGia.TabIndex = 1;
            this.btnQlDocGia.Text = "Quản Lý Độc Giả";
            this.btnQlDocGia.UseVisualStyleBackColor = false;
            this.btnQlDocGia.Click += new System.EventHandler(this.btnQlDocGia_Click);
            // 
            // btnCapNhap
            // 
            this.btnCapNhap.BackColor = System.Drawing.SystemColors.Control;
            this.btnCapNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhap.Location = new System.Drawing.Point(591, 22);
            this.btnCapNhap.Name = "btnCapNhap";
            this.btnCapNhap.Size = new System.Drawing.Size(195, 46);
            this.btnCapNhap.TabIndex = 0;
            this.btnCapNhap.Text = "Cập Nhật";
            this.btnCapNhap.UseVisualStyleBackColor = false;
            this.btnCapNhap.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox5.Controls.Add(this.dgvSach);
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(6, 213);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(561, 163);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh Sách";
            // 
            // dgvSach
            // 
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSach.Location = new System.Drawing.Point(3, 28);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.ReadOnly = true;
            this.dgvSach.Size = new System.Drawing.Size(555, 132);
            this.dgvSach.TabIndex = 0;
            this.dgvSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSach_CellContentClick);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox4.Controls.Add(this.txtMaTacGia);
            this.groupBox4.Controls.Add(this.txtSoLuong);
            this.groupBox4.Controls.Add(this.txtMaLoai);
            this.groupBox4.Controls.Add(this.txtTenSach);
            this.groupBox4.Controls.Add(this.txtMaSach);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(210, 10);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(357, 197);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông Tin Chi Tiết";
            // 
            // txtMaTacGia
            // 
            this.txtMaTacGia.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTacGia.Location = new System.Drawing.Point(139, 157);
            this.txtMaTacGia.Multiline = true;
            this.txtMaTacGia.Name = "txtMaTacGia";
            this.txtMaTacGia.Size = new System.Drawing.Size(202, 25);
            this.txtMaTacGia.TabIndex = 4;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(139, 126);
            this.txtSoLuong.Multiline = true;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(202, 25);
            this.txtSoLuong.TabIndex = 3;
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLoai.Location = new System.Drawing.Point(139, 95);
            this.txtMaLoai.Multiline = true;
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Size = new System.Drawing.Size(202, 25);
            this.txtMaLoai.TabIndex = 2;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSach.Location = new System.Drawing.Point(139, 64);
            this.txtTenSach.Multiline = true;
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(202, 25);
            this.txtTenSach.TabIndex = 1;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSach.Location = new System.Drawing.Point(139, 33);
            this.txtMaSach.Multiline = true;
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(202, 25);
            this.txtMaSach.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã Tác Giả:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số Lượng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã Loại Sách:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã Sách:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Sách:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox3.Controls.Add(this.dgvLoaiSach);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(6, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(198, 197);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Loại Sách";
            // 
            // dgvLoaiSach
            // 
            this.dgvLoaiSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLoaiSach.Location = new System.Drawing.Point(3, 28);
            this.dgvLoaiSach.Name = "dgvLoaiSach";
            this.dgvLoaiSach.ReadOnly = true;
            this.dgvLoaiSach.Size = new System.Drawing.Size(192, 166);
            this.dgvLoaiSach.TabIndex = 0;
            this.dgvLoaiSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiSach_CellContentClick);
            // 
            // frm_DanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 455);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(816, 494);
            this.MinimumSize = new System.Drawing.Size(816, 494);
            this.Name = "frm_DanhMuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Mục Sách";
            this.Load += new System.EventHandler(this.frm_DanhMuc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnMuonTra;
        private System.Windows.Forms.Button btnQlTacGia;
        private System.Windows.Forms.Button btnQlDocGia;
        private System.Windows.Forms.Button btnCapNhap;
        private System.Windows.Forms.TextBox txtMaTacGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtMaLoai;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.DataGridView dgvLoaiSach;
    }
}

