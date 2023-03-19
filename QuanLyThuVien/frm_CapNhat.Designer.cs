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
            this.tctCapNhat = new System.Windows.Forms.TabControl();
            this.tpg1 = new System.Windows.Forms.TabPage();
            this.tpg2 = new System.Windows.Forms.TabPage();
            this.tctCapNhat.SuspendLayout();
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
            this.tpg1.Location = new System.Drawing.Point(4, 22);
            this.tpg1.Name = "tpg1";
            this.tpg1.Padding = new System.Windows.Forms.Padding(3);
            this.tpg1.Size = new System.Drawing.Size(792, 424);
            this.tpg1.TabIndex = 0;
            this.tpg1.Text = "Cập Nhật Loại Sách";
            this.tpg1.UseVisualStyleBackColor = true;
            // 
            // tpg2
            // 
            this.tpg2.Location = new System.Drawing.Point(4, 22);
            this.tpg2.Name = "tpg2";
            this.tpg2.Padding = new System.Windows.Forms.Padding(3);
            this.tpg2.Size = new System.Drawing.Size(792, 424);
            this.tpg2.TabIndex = 1;
            this.tpg2.Text = "Cập Nhật Sách";
            this.tpg2.UseVisualStyleBackColor = true;
            // 
            // frm_CapNhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tctCapNhat);
            this.Name = "frm_CapNhat";
            this.Text = "Cập Nhật Thông Tin Sách";
            this.Load += new System.EventHandler(this.frm_CapNhat_Load);
            this.tctCapNhat.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tctCapNhat;
        private System.Windows.Forms.TabPage tpg1;
        private System.Windows.Forms.TabPage tpg2;
    }
}