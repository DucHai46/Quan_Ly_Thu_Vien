﻿namespace QuanLyThuVien
{
    partial class Form_Doc_Gia
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lvwDanhSachDG = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtTenDG = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaDG = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.dtNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbChiTietDG = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grbChiTietDG.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lvwDanhSachDG);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(7, 299);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1057, 332);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Độc Giả";
            // 
            // lvwDanhSachDG
            // 
            this.lvwDanhSachDG.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvwDanhSachDG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwDanhSachDG.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwDanhSachDG.FullRowSelect = true;
            this.lvwDanhSachDG.HideSelection = false;
            this.lvwDanhSachDG.Location = new System.Drawing.Point(4, 43);
            this.lvwDanhSachDG.Margin = new System.Windows.Forms.Padding(4);
            this.lvwDanhSachDG.Name = "lvwDanhSachDG";
            this.lvwDanhSachDG.Size = new System.Drawing.Size(1049, 285);
            this.lvwDanhSachDG.TabIndex = 0;
            this.lvwDanhSachDG.UseCompatibleStateImageBehavior = false;
            this.lvwDanhSachDG.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Độc Giả";
            this.columnHeader1.Width = 119;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Độc Giả";
            this.columnHeader2.Width = 203;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giới Tính";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ngày Mượn";
            this.columnHeader4.Width = 149;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Địa Chỉ";
            this.columnHeader5.Width = 197;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(3, 220);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(183, 69);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(874, 220);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(183, 69);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(664, 220);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(183, 69);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(438, 220);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(183, 69);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(218, 220);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(183, 69);
            this.btnLuu.TabIndex = 15;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // txtTenDG
            // 
            this.txtTenDG.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDG.Location = new System.Drawing.Point(171, 144);
            this.txtTenDG.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenDG.Name = "txtTenDG";
            this.txtTenDG.Size = new System.Drawing.Size(303, 35);
            this.txtTenDG.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(625, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày Mượn:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(767, 144);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(285, 35);
            this.txtDiaChi.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(627, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Địa Chỉ:";
            // 
            // txtMaDG
            // 
            this.txtMaDG.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDG.Location = new System.Drawing.Point(171, 70);
            this.txtMaDG.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaDG.Name = "txtMaDG";
            this.txtMaDG.Size = new System.Drawing.Size(303, 35);
            this.txtMaDG.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Độc Giả:";
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNam.Location = new System.Drawing.Point(24, 42);
            this.radNam.Margin = new System.Windows.Forms.Padding(4);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(81, 30);
            this.radNam.TabIndex = 0;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNu.Location = new System.Drawing.Point(24, 78);
            this.radNu.Margin = new System.Windows.Forms.Padding(4);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(64, 30);
            this.radNu.TabIndex = 0;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // dtNgayMuon
            // 
            this.dtNgayMuon.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayMuon.Location = new System.Drawing.Point(768, 66);
            this.dtNgayMuon.Margin = new System.Windows.Forms.Padding(4);
            this.dtNgayMuon.Name = "dtNgayMuon";
            this.dtNgayMuon.Size = new System.Drawing.Size(284, 35);
            this.dtNgayMuon.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radNam);
            this.groupBox2.Controls.Add(this.radNu);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(483, 47);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(135, 143);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giới Tính";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Độc Giả:";
            // 
            // grbChiTietDG
            // 
            this.grbChiTietDG.Controls.Add(this.dtNgayMuon);
            this.grbChiTietDG.Controls.Add(this.groupBox2);
            this.grbChiTietDG.Controls.Add(this.txtTenDG);
            this.grbChiTietDG.Controls.Add(this.label4);
            this.grbChiTietDG.Controls.Add(this.txtDiaChi);
            this.grbChiTietDG.Controls.Add(this.label3);
            this.grbChiTietDG.Controls.Add(this.txtMaDG);
            this.grbChiTietDG.Controls.Add(this.label2);
            this.grbChiTietDG.Controls.Add(this.label1);
            this.grbChiTietDG.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbChiTietDG.Location = new System.Drawing.Point(3, 13);
            this.grbChiTietDG.Margin = new System.Windows.Forms.Padding(4);
            this.grbChiTietDG.Name = "grbChiTietDG";
            this.grbChiTietDG.Padding = new System.Windows.Forms.Padding(4);
            this.grbChiTietDG.Size = new System.Drawing.Size(1063, 199);
            this.grbChiTietDG.TabIndex = 12;
            this.grbChiTietDG.TabStop = false;
            this.grbChiTietDG.Text = "Chi Tiết Độc Giả";
            // 
            // Form_Doc_Gia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1082, 641);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.grbChiTietDG);
            this.Name = "Form_Doc_Gia";
            this.Text = "Quản lý độc giả";
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grbChiTietDG.ResumeLayout(false);
            this.grbChiTietDG.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView lvwDanhSachDG;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtTenDG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaDG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.DateTimePicker dtNgayMuon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbChiTietDG;
    }
}