using System.Windows.Forms;

namespace QuanLyThuVien_Demo
{
    partial class frmTimKiemSach
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_TimSach = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtn_TenSach = new System.Windows.Forms.RadioButton();
            this.rbtn_MaSach = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_MaSach = new System.Windows.Forms.TextBox();
            this.txt_TenSach = new System.Windows.Forms.TextBox();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.txt_MaTG = new System.Windows.Forms.TextBox();
            this.txt_MaLoaiSach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_TTTimKiem = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.txt_TimSach);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(23, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 78);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Thông Tin Cần Tìm Kiếm";
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.Firebrick;
            this.btn_search.Location = new System.Drawing.Point(249, 33);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(86, 26);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "Tìm Kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_TimSach
            // 
            this.txt_TimSach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimSach.Location = new System.Drawing.Point(11, 34);
            this.txt_TimSach.Name = "txt_TimSach";
            this.txt_TimSach.Size = new System.Drawing.Size(200, 26);
            this.txt_TimSach.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtn_TenSach);
            this.groupBox2.Controls.Add(this.rbtn_MaSach);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(420, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(196, 76);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Theo";
            // 
            // rbtn_TenSach
            // 
            this.rbtn_TenSach.AutoSize = true;
            this.rbtn_TenSach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_TenSach.ForeColor = System.Drawing.Color.Firebrick;
            this.rbtn_TenSach.Location = new System.Drawing.Point(101, 33);
            this.rbtn_TenSach.Name = "rbtn_TenSach";
            this.rbtn_TenSach.Size = new System.Drawing.Size(84, 23);
            this.rbtn_TenSach.TabIndex = 1;
            this.rbtn_TenSach.TabStop = true;
            this.rbtn_TenSach.Text = "Tên Sách";
            this.rbtn_TenSach.UseVisualStyleBackColor = true;
            // 
            // rbtn_MaSach
            // 
            this.rbtn_MaSach.AutoSize = true;
            this.rbtn_MaSach.Checked = true;
            this.rbtn_MaSach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_MaSach.ForeColor = System.Drawing.Color.Firebrick;
            this.rbtn_MaSach.Location = new System.Drawing.Point(9, 32);
            this.rbtn_MaSach.Name = "rbtn_MaSach";
            this.rbtn_MaSach.Size = new System.Drawing.Size(82, 23);
            this.rbtn_MaSach.TabIndex = 0;
            this.rbtn_MaSach.TabStop = true;
            this.rbtn_MaSach.Text = "Mã Sách";
            this.rbtn_MaSach.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_MaSach);
            this.groupBox3.Controls.Add(this.txt_TenSach);
            this.groupBox3.Controls.Add(this.txt_SoLuong);
            this.groupBox3.Controls.Add(this.txt_MaTG);
            this.groupBox3.Controls.Add(this.txt_MaLoaiSach);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(23, 205);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(593, 152);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông Tin Về Tác Giả";
            // 
            // txt_MaSach
            // 
            this.txt_MaSach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaSach.Location = new System.Drawing.Point(90, 29);
            this.txt_MaSach.Name = "txt_MaSach";
            this.txt_MaSach.ReadOnly = true;
            this.txt_MaSach.Size = new System.Drawing.Size(196, 26);
            this.txt_MaSach.TabIndex = 3;
            // 
            // txt_TenSach
            // 
            this.txt_TenSach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenSach.Location = new System.Drawing.Point(91, 63);
            this.txt_TenSach.Name = "txt_TenSach";
            this.txt_TenSach.ReadOnly = true;
            this.txt_TenSach.Size = new System.Drawing.Size(196, 26);
            this.txt_TenSach.TabIndex = 4;
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoLuong.Location = new System.Drawing.Point(90, 96);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.ReadOnly = true;
            this.txt_SoLuong.Size = new System.Drawing.Size(196, 26);
            this.txt_SoLuong.TabIndex = 5;
            // 
            // txt_MaTG
            // 
            this.txt_MaTG.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaTG.Location = new System.Drawing.Point(381, 33);
            this.txt_MaTG.Name = "txt_MaTG";
            this.txt_MaTG.ReadOnly = true;
            this.txt_MaTG.Size = new System.Drawing.Size(196, 26);
            this.txt_MaTG.TabIndex = 6;
            // 
            // txt_MaLoaiSach
            // 
            this.txt_MaLoaiSach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaLoaiSach.Location = new System.Drawing.Point(381, 66);
            this.txt_MaLoaiSach.Name = "txt_MaLoaiSach";
            this.txt_MaLoaiSach.ReadOnly = true;
            this.txt_MaLoaiSach.Size = new System.Drawing.Size(196, 26);
            this.txt_MaLoaiSach.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(9, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã Sách:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Firebrick;
            this.label5.Location = new System.Drawing.Point(295, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mã Tác Giả:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Firebrick;
            this.label6.Location = new System.Drawing.Point(295, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Mã Loại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Firebrick;
            this.label4.Location = new System.Drawing.Point(9, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số Lượng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(9, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên Sách:";
            // 
            // lbl_TTTimKiem
            // 
            this.lbl_TTTimKiem.AutoSize = true;
            this.lbl_TTTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TTTimKiem.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_TTTimKiem.Location = new System.Drawing.Point(268, 152);
            this.lbl_TTTimKiem.Name = "lbl_TTTimKiem";
            this.lbl_TTTimKiem.Size = new System.Drawing.Size(196, 19);
            this.lbl_TTTimKiem.TabIndex = 0;
            this.lbl_TTTimKiem.Text = "Nhập Thông Tin Cần Tìn Kiếm";
            this.lbl_TTTimKiem.Visible = false;
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.Firebrick;
            this.btn_exit.Location = new System.Drawing.Point(528, 145);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(86, 33);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Column1
            // 
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.Name = "Column5";
            // 
            // frmTimKiemSach
            // 
            this.AcceptButton = this.btn_search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(648, 401);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.lbl_TTTimKiem);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 11.25F);
            this.Name = "frmTimKiemSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tìm Kiếm Sách";
            this.Load += new System.EventHandler(this.frmTimKiemSach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_search;
        private TextBox txt_TimSach;
        private GroupBox groupBox2;
        private RadioButton rbtn_TenSach;
        private RadioButton rbtn_MaSach;
        private GroupBox groupBox3;
        private TextBox txt_MaSach;
        private TextBox txt_TenSach;
        private TextBox txt_SoLuong;
        private TextBox txt_MaTG;
        private TextBox txt_MaLoaiSach;
        private Label label2;
        private Label label5;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label lbl_TTTimKiem;
        private Button btn_exit;

        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}