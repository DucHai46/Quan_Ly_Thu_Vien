﻿namespace QuanLyThuVien
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
            this.pnlLoaiSach = new System.Windows.Forms.Panel();
            this.pnlSach = new System.Windows.Forms.Panel();
            this.btnCapNhatLoaiSach = new System.Windows.Forms.Button();
            this.btnCapNhatSach = new System.Windows.Forms.Button();
            this.pnlLoaiSach.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLoaiSach
            // 
            this.pnlLoaiSach.Controls.Add(this.pnlSach);
            this.pnlLoaiSach.Location = new System.Drawing.Point(1, 26);
            this.pnlLoaiSach.Name = "pnlLoaiSach";
            this.pnlLoaiSach.Size = new System.Drawing.Size(798, 423);
            this.pnlLoaiSach.TabIndex = 1;
            // 
            // pnlSach
            // 
            this.pnlSach.Location = new System.Drawing.Point(0, 0);
            this.pnlSach.Name = "pnlSach";
            this.pnlSach.Size = new System.Drawing.Size(798, 420);
            this.pnlSach.TabIndex = 2;
            // 
            // btnCapNhatLoaiSach
            // 
            this.btnCapNhatLoaiSach.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatLoaiSach.Location = new System.Drawing.Point(1, -3);
            this.btnCapNhatLoaiSach.Name = "btnCapNhatLoaiSach";
            this.btnCapNhatLoaiSach.Size = new System.Drawing.Size(127, 23);
            this.btnCapNhatLoaiSach.TabIndex = 2;
            this.btnCapNhatLoaiSach.Text = "Cập Nhật Loại Sách";
            this.btnCapNhatLoaiSach.UseVisualStyleBackColor = true;
            this.btnCapNhatLoaiSach.Click += new System.EventHandler(this.btnCapNhatLoaiSach_Click);
            // 
            // btnCapNhatSach
            // 
            this.btnCapNhatSach.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatSach.Location = new System.Drawing.Point(125, -3);
            this.btnCapNhatSach.Name = "btnCapNhatSach";
            this.btnCapNhatSach.Size = new System.Drawing.Size(127, 23);
            this.btnCapNhatSach.TabIndex = 3;
            this.btnCapNhatSach.Text = "Cập Nhật Sách";
            this.btnCapNhatSach.UseVisualStyleBackColor = true;
            // 
            // frm_CapNhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCapNhatLoaiSach);
            this.Controls.Add(this.btnCapNhatSach);
            this.Controls.Add(this.pnlLoaiSach);
            this.Name = "frm_CapNhat";
            this.Text = "Cập Nhật Thông Tin Sách";
            this.pnlLoaiSach.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLoaiSach;
        private System.Windows.Forms.Button btnCapNhatLoaiSach;
        private System.Windows.Forms.Button btnCapNhatSach;
        private System.Windows.Forms.Panel pnlSach;
    }
}