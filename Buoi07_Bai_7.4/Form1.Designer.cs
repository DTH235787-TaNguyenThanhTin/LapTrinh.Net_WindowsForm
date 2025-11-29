namespace buoi07_bai_7._4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.Label labelTieuDe;
        private System.Windows.Forms.Label labelTien;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.btnChon = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.labelTien = new System.Windows.Forms.Label();
            this.labelTieuDe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTieuDe
            // 
            this.labelTieuDe.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelTieuDe.Location = new System.Drawing.Point(150, 10);
            this.labelTieuDe.Name = "labelTieuDe";
            this.labelTieuDe.Size = new System.Drawing.Size(300, 40);
            this.labelTieuDe.TabIndex = 0;
            this.labelTieuDe.Text = "Chọn vị trí ghế";
            this.labelTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTien
            // 
            this.labelTien.AutoSize = true;
            this.labelTien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelTien.Location = new System.Drawing.Point(50, 300);
            this.labelTien.Name = "labelTien";
            this.labelTien.Size = new System.Drawing.Size(94, 19);
            this.labelTien.TabIndex = 1;
            this.labelTien.Text = "Thành tiền:";
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblThanhTien.Location = new System.Drawing.Point(150, 300);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(49, 19);
            this.lblThanhTien.TabIndex = 2;
            this.lblThanhTien.Text = "0 VND";
            // 
            // btnChon
            // 
            this.btnChon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnChon.Location = new System.Drawing.Point(120, 340);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(100, 40);
            this.btnChon.TabIndex = 3;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnHuy.Location = new System.Drawing.Point(260, 340);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 40);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnThoat.Location = new System.Drawing.Point(400, 340);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 40);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(580, 400);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.lblThanhTien);
            this.Controls.Add(this.labelTien);
            this.Controls.Add(this.labelTieuDe);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vé xe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
    }
}
