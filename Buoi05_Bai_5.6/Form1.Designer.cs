namespace Buoi05_Bai_5._6
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.groupBoxMang = new System.Windows.Forms.GroupBox();
            this.btnXuatMang = new System.Windows.Forms.Button();
            this.btnNhapMang = new System.Windows.Forms.Button();
            this.txtMang = new System.Windows.Forms.TextBox();
            this.groupBoxChucNang = new System.Windows.Forms.GroupBox();
            this.rdoNguyenTo = new System.Windows.Forms.RadioButton();
            this.rdoDemLe = new System.Windows.Forms.RadioButton();
            this.rdoDemChan = new System.Windows.Forms.RadioButton();
            this.rdoTongChan = new System.Windows.Forms.RadioButton();
            this.rdoTongLe = new System.Windows.Forms.RadioButton();
            this.rdoChanCuoi = new System.Windows.Forms.RadioButton();
            this.rdoChan = new System.Windows.Forms.RadioButton();
            this.rdoMin = new System.Windows.Forms.RadioButton();
            this.groupBoxKetQua = new System.Windows.Forms.GroupBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBoxMang.SuspendLayout();
            this.groupBoxChucNang.SuspendLayout();
            this.groupBoxKetQua.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMang
            // 
            this.groupBoxMang.Controls.Add(this.btnXuatMang);
            this.groupBoxMang.Controls.Add(this.btnNhapMang);
            this.groupBoxMang.Controls.Add(this.txtMang);
            this.groupBoxMang.Location = new System.Drawing.Point(12, 12);
            this.groupBoxMang.Name = "groupBoxMang";
            this.groupBoxMang.Size = new System.Drawing.Size(400, 120);
            this.groupBoxMang.TabIndex = 0;
            this.groupBoxMang.TabStop = false;
            this.groupBoxMang.Text = "Mảng";
            // 
            // btnXuatMang
            // 
            this.btnXuatMang.Location = new System.Drawing.Point(260, 70);
            this.btnXuatMang.Name = "btnXuatMang";
            this.btnXuatMang.Size = new System.Drawing.Size(120, 30);
            this.btnXuatMang.TabIndex = 2;
            this.btnXuatMang.Text = "Xuất mảng";
            this.btnXuatMang.UseVisualStyleBackColor = true;
            this.btnXuatMang.Click += new System.EventHandler(this.btnXuatMang_Click);
            // 
            // btnNhapMang
            // 
            this.btnNhapMang.Location = new System.Drawing.Point(20, 70);
            this.btnNhapMang.Name = "btnNhapMang";
            this.btnNhapMang.Size = new System.Drawing.Size(200, 30);
            this.btnNhapMang.TabIndex = 1;
            this.btnNhapMang.Text = "Nhập mảng ngẫu nhiên";
            this.btnNhapMang.UseVisualStyleBackColor = true;
            this.btnNhapMang.Click += new System.EventHandler(this.btnNhapMang_Click);
            // 
            // txtMang
            // 
            this.txtMang.Location = new System.Drawing.Point(20, 30);
            this.txtMang.Multiline = true;
            this.txtMang.Name = "txtMang";
            this.txtMang.Size = new System.Drawing.Size(360, 30);
            this.txtMang.TabIndex = 0;
            // 
            // groupBoxChucNang
            // 
            this.groupBoxChucNang.Controls.Add(this.rdoNguyenTo);
            this.groupBoxChucNang.Controls.Add(this.rdoDemLe);
            this.groupBoxChucNang.Controls.Add(this.rdoDemChan);
            this.groupBoxChucNang.Controls.Add(this.rdoTongChan);
            this.groupBoxChucNang.Controls.Add(this.rdoTongLe);
            this.groupBoxChucNang.Controls.Add(this.rdoChanCuoi);
            this.groupBoxChucNang.Controls.Add(this.rdoChan);
            this.groupBoxChucNang.Controls.Add(this.rdoMin);
            this.groupBoxChucNang.Location = new System.Drawing.Point(12, 138);
            this.groupBoxChucNang.Name = "groupBoxChucNang";
            this.groupBoxChucNang.Size = new System.Drawing.Size(400, 240);
            this.groupBoxChucNang.TabIndex = 1;
            this.groupBoxChucNang.TabStop = false;
            this.groupBoxChucNang.Text = "Chức năng";
            // 
            // Các RadioButton
            // 
            this.rdoMin.AutoSize = true; this.rdoMin.Text = "Tìm giá trị nhỏ nhất";
            this.rdoMin.Location = new System.Drawing.Point(20, 25);

            this.rdoChan.AutoSize = true; this.rdoChan.Text = "Liệt kê giá trị chẵn";
            this.rdoChan.Location = new System.Drawing.Point(20, 50);

            this.rdoChanCuoi.AutoSize = true; this.rdoChanCuoi.Text = "Tìm số chẵn cuối cùng";
            this.rdoChanCuoi.Location = new System.Drawing.Point(20, 75);

            this.rdoTongLe.AutoSize = true; this.rdoTongLe.Text = "Tính tổng giá trị lẻ";
            this.rdoTongLe.Location = new System.Drawing.Point(20, 100);

            this.rdoTongChan.AutoSize = true; this.rdoTongChan.Text = "Tính tổng giá trị chẵn";
            this.rdoTongChan.Location = new System.Drawing.Point(20, 125);

            this.rdoDemChan.AutoSize = true; this.rdoDemChan.Text = "Đếm số lượng giá trị chẵn";
            this.rdoDemChan.Location = new System.Drawing.Point(20, 150);

            this.rdoDemLe.AutoSize = true; this.rdoDemLe.Text = "Đếm số lượng giá trị lẻ";
            this.rdoDemLe.Location = new System.Drawing.Point(20, 175);

            this.rdoNguyenTo.AutoSize = true; this.rdoNguyenTo.Text = "Kiểm tra số nguyên tố và nhỏ hơn n";
            this.rdoNguyenTo.Location = new System.Drawing.Point(20, 200);

            // 
            // groupBoxKetQua
            // 
            this.groupBoxKetQua.Controls.Add(this.txtKetQua);
            this.groupBoxKetQua.Location = new System.Drawing.Point(12, 384);
            this.groupBoxKetQua.Name = "groupBoxKetQua";
            this.groupBoxKetQua.Size = new System.Drawing.Size(400, 90);
            this.groupBoxKetQua.TabIndex = 2;
            this.groupBoxKetQua.TabStop = false;
            this.groupBoxKetQua.Text = "Kết quả";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(20, 30);
            this.txtKetQua.Multiline = true;
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.Size = new System.Drawing.Size(360, 45);
            this.txtKetQua.TabIndex = 0;
            // 
            // Các nút
            // 
            this.btnThucHien.Location = new System.Drawing.Point(430, 50);
            this.btnThucHien.Text = "Thực hiện";
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);

            this.btnLamLai.Location = new System.Drawing.Point(430, 100);
            this.btnLamLai.Text = "Làm lại";
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);

            this.btnThoat.Location = new System.Drawing.Point(430, 150);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(570, 490);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.btnThucHien);
            this.Controls.Add(this.groupBoxKetQua);
            this.Controls.Add(this.groupBoxChucNang);
            this.Controls.Add(this.groupBoxMang);
            this.Text = "Bài 5.6 - Xử lý mảng với RadioButton";
            this.groupBoxMang.ResumeLayout(false);
            this.groupBoxMang.PerformLayout();
            this.groupBoxChucNang.ResumeLayout(false);
            this.groupBoxChucNang.PerformLayout();
            this.groupBoxKetQua.ResumeLayout(false);
            this.groupBoxKetQua.PerformLayout();
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.GroupBox groupBoxMang;
        private System.Windows.Forms.Button btnXuatMang;
        private System.Windows.Forms.Button btnNhapMang;
        private System.Windows.Forms.TextBox txtMang;
        private System.Windows.Forms.GroupBox groupBoxChucNang;
        private System.Windows.Forms.RadioButton rdoNguyenTo;
        private System.Windows.Forms.RadioButton rdoDemLe;
        private System.Windows.Forms.RadioButton rdoDemChan;
        private System.Windows.Forms.RadioButton rdoTongChan;
        private System.Windows.Forms.RadioButton rdoTongLe;
        private System.Windows.Forms.RadioButton rdoChanCuoi;
        private System.Windows.Forms.RadioButton rdoChan;
        private System.Windows.Forms.RadioButton rdoMin;
        private System.Windows.Forms.GroupBox groupBoxKetQua;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.Button btnThoat;
    }
}
