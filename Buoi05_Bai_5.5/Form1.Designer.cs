namespace Buoi05_Bai_5._5
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox groupBoxMangGoc;
        private System.Windows.Forms.GroupBox groupBoxKetQua;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnXuatMang;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Button btnTang2;
        private System.Windows.Forms.Button btnDemLe;
        private System.Windows.Forms.Button btnSapTang;
        private System.Windows.Forms.Button btnTongLe;
        private System.Windows.Forms.Button btnSapGiam;

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
            this.groupBoxMangGoc = new System.Windows.Forms.GroupBox();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.groupBoxKetQua = new System.Windows.Forms.GroupBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnXuatMang = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnTang2 = new System.Windows.Forms.Button();
            this.btnDemLe = new System.Windows.Forms.Button();
            this.btnSapTang = new System.Windows.Forms.Button();
            this.btnTongLe = new System.Windows.Forms.Button();
            this.btnSapGiam = new System.Windows.Forms.Button();
            this.groupBoxMangGoc.SuspendLayout();
            this.groupBoxKetQua.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMangGoc
            // 
            this.groupBoxMangGoc.Controls.Add(this.txtNhap);
            this.groupBoxMangGoc.Location = new System.Drawing.Point(20, 20);
            this.groupBoxMangGoc.Name = "groupBoxMangGoc";
            this.groupBoxMangGoc.Size = new System.Drawing.Size(360, 100);
            this.groupBoxMangGoc.TabIndex = 0;
            this.groupBoxMangGoc.TabStop = false;
            this.groupBoxMangGoc.Text = "Mảng gốc";
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(15, 25);
            this.txtNhap.Multiline = true;
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.ReadOnly = true;
            this.txtNhap.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNhap.Size = new System.Drawing.Size(320, 60);
            this.txtNhap.TabIndex = 0;
            // 
            // groupBoxKetQua
            // 
            this.groupBoxKetQua.Controls.Add(this.txtKetQua);
            this.groupBoxKetQua.Location = new System.Drawing.Point(20, 130);
            this.groupBoxKetQua.Name = "groupBoxKetQua";
            this.groupBoxKetQua.Size = new System.Drawing.Size(360, 100);
            this.groupBoxKetQua.TabIndex = 1;
            this.groupBoxKetQua.TabStop = false;
            this.groupBoxKetQua.Text = "Kết quả";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(15, 25);
            this.txtKetQua.Multiline = true;
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtKetQua.Size = new System.Drawing.Size(320, 60);
            this.txtKetQua.TabIndex = 0;
            // 
            // Các nút chức năng
            // 
            this.btnXuatMang = new System.Windows.Forms.Button();
            this.btnXuatMang.Location = new System.Drawing.Point(400, 30);
            this.btnXuatMang.Name = "btnXuatMang";
            this.btnXuatMang.Size = new System.Drawing.Size(170, 30);
            this.btnXuatMang.Text = "Xuất mảng ngẫu nhiên";
            this.btnXuatMang.Click += new System.EventHandler(this.btnXuatMang_Click);

            this.btnMin = new System.Windows.Forms.Button();
            this.btnMin.Location = new System.Drawing.Point(400, 70);
            this.btnMin.Size = new System.Drawing.Size(170, 30);
            this.btnMin.Text = "Tìm phần tử nhỏ nhất";
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);

            this.btnTong = new System.Windows.Forms.Button();
            this.btnTong.Location = new System.Drawing.Point(400, 110);
            this.btnTong.Size = new System.Drawing.Size(170, 30);
            this.btnTong.Text = "Tính tổng giá trị mảng";
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);

            this.btnTang2 = new System.Windows.Forms.Button();
            this.btnTang2.Location = new System.Drawing.Point(400, 150);
            this.btnTang2.Size = new System.Drawing.Size(170, 30);
            this.btnTang2.Text = "Tăng mỗi phần tử lên 2";
            this.btnTang2.Click += new System.EventHandler(this.btnTang2_Click);

            this.btnDemLe = new System.Windows.Forms.Button();
            this.btnDemLe.Location = new System.Drawing.Point(400, 190);
            this.btnDemLe.Size = new System.Drawing.Size(170, 30);
            this.btnDemLe.Text = "Đếm số phần tử lẻ";
            this.btnDemLe.Click += new System.EventHandler(this.btnDemLe_Click);

            this.btnSapTang = new System.Windows.Forms.Button();
            this.btnSapTang.Location = new System.Drawing.Point(400, 230);
            this.btnSapTang.Size = new System.Drawing.Size(170, 30);
            this.btnSapTang.Text = "Sắp mảng tăng";
            this.btnSapTang.Click += new System.EventHandler(this.btnSapTang_Click);

            this.btnTongLe = new System.Windows.Forms.Button();
            this.btnTongLe.Location = new System.Drawing.Point(400, 270);
            this.btnTongLe.Size = new System.Drawing.Size(170, 30);
            this.btnTongLe.Text = "Tổng phần tử lẻ";
            this.btnTongLe.Click += new System.EventHandler(this.btnTongLe_Click);

            this.btnSapGiam = new System.Windows.Forms.Button();
            this.btnSapGiam.Location = new System.Drawing.Point(400, 310);
            this.btnSapGiam.Size = new System.Drawing.Size(170, 30);
            this.btnSapGiam.Text = "Sắp mảng giảm";
            this.btnSapGiam.Click += new System.EventHandler(this.btnSapGiam_Click);

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(600, 370);
            this.Controls.Add(this.groupBoxMangGoc);
            this.Controls.Add(this.groupBoxKetQua);
            this.Controls.Add(this.btnXuatMang);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.btnTang2);
            this.Controls.Add(this.btnDemLe);
            this.Controls.Add(this.btnSapTang);
            this.Controls.Add(this.btnTongLe);
            this.Controls.Add(this.btnSapGiam);
            this.Name = "Form1";
            this.Text = "Xử lý mảng ngẫu nhiên";
            this.groupBoxMangGoc.ResumeLayout(false);
            this.groupBoxMangGoc.PerformLayout();
            this.groupBoxKetQua.ResumeLayout(false);
            this.groupBoxKetQua.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion
    }
}
