namespace QuanLyThuVien
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
            this.pnlCapNhatSach = new System.Windows.Forms.Panel();
            this.pnlLoaiSach = new System.Windows.Forms.Panel();
            this.btnCapNhatLoaiSach = new System.Windows.Forms.Button();
            this.btnCapNhatSach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlCapNhatSach
            // 
            this.pnlCapNhatSach.Location = new System.Drawing.Point(1, 26);
            this.pnlCapNhatSach.Name = "pnlCapNhatSach";
            this.pnlCapNhatSach.Size = new System.Drawing.Size(798, 421);
            this.pnlCapNhatSach.TabIndex = 1;
            // 
            // pnlLoaiSach
            // 
            this.pnlLoaiSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pnlLoaiSach.Location = new System.Drawing.Point(1, 26);
            this.pnlLoaiSach.Name = "pnlLoaiSach";
            this.pnlLoaiSach.Size = new System.Drawing.Size(798, 421);
            this.pnlLoaiSach.TabIndex = 2;
            // 
            // btnCapNhatLoaiSach
            // 
            this.btnCapNhatLoaiSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCapNhatLoaiSach.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatLoaiSach.Location = new System.Drawing.Point(1, -3);
            this.btnCapNhatLoaiSach.Name = "btnCapNhatLoaiSach";
            this.btnCapNhatLoaiSach.Size = new System.Drawing.Size(127, 23);
            this.btnCapNhatLoaiSach.TabIndex = 2;
            this.btnCapNhatLoaiSach.Text = "Cập Nhật Loại Sách";
            this.btnCapNhatLoaiSach.UseVisualStyleBackColor = false;
            this.btnCapNhatLoaiSach.Click += new System.EventHandler(this.btnCapNhatLoaiSach_Click);
            // 
            // btnCapNhatSach
            // 
            this.btnCapNhatSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCapNhatSach.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatSach.Location = new System.Drawing.Point(125, -3);
            this.btnCapNhatSach.Name = "btnCapNhatSach";
            this.btnCapNhatSach.Size = new System.Drawing.Size(127, 23);
            this.btnCapNhatSach.TabIndex = 3;
            this.btnCapNhatSach.Text = "Cập Nhật Sách";
            this.btnCapNhatSach.UseVisualStyleBackColor = false;
            this.btnCapNhatSach.Click += new System.EventHandler(this.btnCapNhatSach_Click);
            // 
            // frm_CapNhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlLoaiSach);
            this.Controls.Add(this.btnCapNhatLoaiSach);
            this.Controls.Add(this.btnCapNhatSach);
            this.Controls.Add(this.pnlCapNhatSach);
            this.Name = "frm_CapNhat";
            this.Text = "Cập Nhật Thông Tin Sách";
            this.Load += new System.EventHandler(this.frm_CapNhat_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCapNhatSach;
        private System.Windows.Forms.Button btnCapNhatLoaiSach;
        private System.Windows.Forms.Button btnCapNhatSach;
        private System.Windows.Forms.Panel pnlLoaiSach;
    }
}