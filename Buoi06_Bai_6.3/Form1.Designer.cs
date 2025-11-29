namespace Buoi06_Bai_6._3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.lstLop = new System.Windows.Forms.ListBox();
            this.dtpTG = new System.Windows.Forms.DateTimePicker();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnXoaItem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lstKetQua = new System.Windows.Forms.ListView();
            this.grpThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.lstLop);
            this.grpThongTin.Controls.Add(this.dtpTG);
            this.grpThongTin.Controls.Add(this.txtDiaChi);
            this.grpThongTin.Controls.Add(this.txtHoTen);
            this.grpThongTin.Controls.Add(this.txtMS);
            this.grpThongTin.Controls.Add(this.label4);
            this.grpThongTin.Controls.Add(this.label3);
            this.grpThongTin.Controls.Add(this.label2);
            this.grpThongTin.Controls.Add(this.label1);
            this.grpThongTin.Controls.Add(this.label5);
            this.grpThongTin.Location = new System.Drawing.Point(50, 70);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(360, 225);
            this.grpThongTin.TabIndex = 0;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Nhập thông tin:";
            // 
            // lstLop
            // 
            this.lstLop.FormattingEnabled = true;
            this.lstLop.ItemHeight = 15;
            this.lstLop.Items.AddRange(new object[] {
            "Lớp A",
            "Lớp B",
            "Lớp C",
            "Lớp D"});
            this.lstLop.Location = new System.Drawing.Point(110, 155);
            this.lstLop.Name = "lstLop";
            this.lstLop.Size = new System.Drawing.Size(120, 49);
            this.lstLop.TabIndex = 9;
            // 
            // dtpTG
            // 
            this.dtpTG.Location = new System.Drawing.Point(110, 122);
            this.dtpTG.Name = "dtpTG";
            this.dtpTG.Size = new System.Drawing.Size(200, 23);
            this.dtpTG.TabIndex = 8;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(110, 89);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(200, 23);
            this.txtDiaChi.TabIndex = 7;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(110, 56);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(200, 23);
            this.txtHoTen.TabIndex = 6;
            // 
            // txtMS
            // 
            this.txtMS.Location = new System.Drawing.Point(110, 23);
            this.txtMS.Name = "txtMS";
            this.txtMS.Size = new System.Drawing.Size(200, 23);
            this.txtMS.TabIndex = 5;
            // 
            // label4 - Lớp
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Lớp:";
            // 
            // label3 - Ngày sinh
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày sinh:";
            // 
            // label2 - Địa chỉ
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Địa chỉ:";
            // 
            // label1 - Họ tên
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ tên:";
            // 
            // label5 - Mã SV
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã SV:";
            // 
            // label6 - Tiêu đề
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(160, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(315, 37);
            this.label6.TabIndex = 1;
            this.label6.Text = "Danh sách sinh viên";
            // 
            // Các nút
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(460, 100);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(100, 25);
            this.btnThemMoi.TabIndex = 2;
            this.btnThemMoi.Text = "Thêm Mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            this.btnXoaItem.Location = new System.Drawing.Point(460, 150);
            this.btnXoaItem.Name = "btnXoaItem";
            this.btnXoaItem.Size = new System.Drawing.Size(100, 25);
            this.btnXoaItem.TabIndex = 3;
            this.btnXoaItem.Text = "Xóa Item";
            this.btnXoaItem.UseVisualStyleBackColor = true;
            this.btnXoaItem.Click += new System.EventHandler(this.btnXoaItem_Click);
            // 
            this.btnThoat.Location = new System.Drawing.Point(460, 200);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 25);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lstKetQua
            // 
            this.lstKetQua.Location = new System.Drawing.Point(50, 310);
            this.lstKetQua.Name = "lstKetQua";
            this.lstKetQua.Size = new System.Drawing.Size(510, 120);
            this.lstKetQua.TabIndex = 5;
            this.lstKetQua.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(640, 460);
            this.Controls.Add(this.lstKetQua);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoaItem);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grpThongTin);
            this.Name = "Form1";
            this.Text = "Danh sách sinh viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.ListBox lstLop;
        private System.Windows.Forms.DateTimePicker dtpTG;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnXoaItem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ListView lstKetQua;
    }
}
