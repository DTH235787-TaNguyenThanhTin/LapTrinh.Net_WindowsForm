namespace buoi05_bai_5._4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.grpChon = new System.Windows.Forms.GroupBox();
            this.rdoChuNhat = new System.Windows.Forms.RadioButton();
            this.rdoTamGiac = new System.Windows.Forms.RadioButton();
            this.rdoVuong = new System.Windows.Forms.RadioButton();
            this.rdoTron = new System.Windows.Forms.RadioButton();
            this.grpNhap = new System.Windows.Forms.GroupBox();
            this.lblCanhA = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lblCanhB = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lblCanhC = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblChuVi = new System.Windows.Forms.Label();
            this.lblDienTich = new System.Windows.Forms.Label();
            this.grpChon.SuspendLayout();
            this.grpNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(160, 20);
            this.lblTitle.Text = "Tìm Chu Vi và Diện Tích";
            this.lblTitle.AutoSize = true;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblSubtitle.ForeColor = System.Drawing.Color.Blue;
            this.lblSubtitle.Location = new System.Drawing.Point(100, 60);
            this.lblSubtitle.Text = "Hình Tròn - Hình Vuông - Hình Tam Giác - Hình Chữ Nhật";
            this.lblSubtitle.AutoSize = true;
            // 
            // grpChon
            // 
            this.grpChon.Controls.Add(this.rdoChuNhat);
            this.grpChon.Controls.Add(this.rdoTamGiac);
            this.grpChon.Controls.Add(this.rdoVuong);
            this.grpChon.Controls.Add(this.rdoTron);
            this.grpChon.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.grpChon.Location = new System.Drawing.Point(40, 100);
            this.grpChon.Size = new System.Drawing.Size(260, 140);
            this.grpChon.Text = "Chọn hình";
            // 
            // rdoTron
            // 
            this.rdoTron.Location = new System.Drawing.Point(20, 30);
            this.rdoTron.Text = "Hình tròn";
            this.rdoTron.CheckedChanged += new System.EventHandler(this.rdoTron_CheckedChanged);
            // 
            // rdoVuong
            // 
            this.rdoVuong.Location = new System.Drawing.Point(20, 60);
            this.rdoVuong.Text = "Hình vuông";
            this.rdoVuong.CheckedChanged += new System.EventHandler(this.rdoVuong_CheckedChanged);
            // 
            // rdoChuNhat
            // 
            this.rdoChuNhat.Location = new System.Drawing.Point(140, 30);
            this.rdoChuNhat.Text = "Hình chữ nhật";
            this.rdoChuNhat.CheckedChanged += new System.EventHandler(this.rdoChuNhat_CheckedChanged);
            // 
            // rdoTamGiac
            // 
            this.rdoTamGiac.Location = new System.Drawing.Point(140, 60);
            this.rdoTamGiac.Text = "Hình tam giác";
            this.rdoTamGiac.CheckedChanged += new System.EventHandler(this.rdoTamGiac_CheckedChanged);
            // 
            // grpNhap
            // 
            this.grpNhap.Controls.Add(this.lblCanhA);
            this.grpNhap.Controls.Add(this.txtA);
            this.grpNhap.Controls.Add(this.lblCanhB);
            this.grpNhap.Controls.Add(this.txtB);
            this.grpNhap.Controls.Add(this.lblCanhC);
            this.grpNhap.Controls.Add(this.txtC);
            this.grpNhap.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.grpNhap.Location = new System.Drawing.Point(340, 100);
            this.grpNhap.Size = new System.Drawing.Size(260, 140);
            this.grpNhap.Text = "Nhập dữ liệu";
            // 
            // lblCanhA
            // 
            this.lblCanhA.Location = new System.Drawing.Point(20, 30);
            this.lblCanhA.Text = "Cạnh a:";
            this.lblCanhA.AutoSize = true;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(100, 30);
            this.txtA.Width = 120;
            // 
            // lblCanhB
            // 
            this.lblCanhB.Location = new System.Drawing.Point(20, 65);
            this.lblCanhB.Text = "Cạnh b:";
            this.lblCanhB.AutoSize = true;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(100, 65);
            this.txtB.Width = 120;
            // 
            // lblCanhC
            // 
            this.lblCanhC.Location = new System.Drawing.Point(20, 100);
            this.lblCanhC.Text = "Cạnh c:";
            this.lblCanhC.AutoSize = true;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(100, 100);
            this.txtC.Width = 120;
            // 
            // Buttons
            // 
            this.btnThucHien = new System.Windows.Forms.Button();
            this.btnThucHien.Text = "Thực Hiện";
            this.btnThucHien.Location = new System.Drawing.Point(140, 270);
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);

            this.btnReset = new System.Windows.Forms.Button();
            this.btnReset.Text = "Reset";
            this.btnReset.Location = new System.Drawing.Point(280, 270);
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);

            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Location = new System.Drawing.Point(400, 270);
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblChuVi
            // 
            this.lblChuVi.Location = new System.Drawing.Point(160, 320);
            this.lblChuVi.Text = "Chu vi:";
            this.lblChuVi.AutoSize = true;
            // 
            // lblDienTich
            // 
            this.lblDienTich.Location = new System.Drawing.Point(160, 350);
            this.lblDienTich.Text = "Diện tích:";
            this.lblDienTich.AutoSize = true;

            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 420);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblTitle, this.lblSubtitle, this.grpChon, this.grpNhap,
                this.btnThucHien, this.btnReset, this.btnThoat, this.lblChuVi, this.lblDienTich
            });
            this.Text = "Tìm Chu Vi và Diện Tích";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.GroupBox grpChon;
        private System.Windows.Forms.RadioButton rdoChuNhat;
        private System.Windows.Forms.RadioButton rdoTamGiac;
        private System.Windows.Forms.RadioButton rdoVuong;
        private System.Windows.Forms.RadioButton rdoTron;
        private System.Windows.Forms.GroupBox grpNhap;
        private System.Windows.Forms.Label lblCanhA;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lblCanhB;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lblCanhC;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblChuVi;
        private System.Windows.Forms.Label lblDienTich;
    }
}
