namespace Buoi06_Bai_6._4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.ComboBox cboQueQuan;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ListView lvSinhVien;
        private System.Windows.Forms.Label lblTieuDe;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.cboQueQuan = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lvSinhVien = new System.Windows.Forms.ListView();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.grpThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.Blue;
            this.lblTieuDe.Location = new System.Drawing.Point(250, 20);
            this.lblTieuDe.Text = "Quản lý Sinh viên";
            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.txtMaSV);
            this.grpThongTin.Controls.Add(this.txtHoTen);
            this.grpThongTin.Controls.Add(this.dtpNgaySinh);
            this.grpThongTin.Controls.Add(this.rdoNam);
            this.grpThongTin.Controls.Add(this.rdoNu);
            this.grpThongTin.Controls.Add(this.txtDienThoai);
            this.grpThongTin.Controls.Add(this.cboQueQuan);
            this.grpThongTin.Location = new System.Drawing.Point(40, 70);
            this.grpThongTin.Size = new System.Drawing.Size(600, 150);
            this.grpThongTin.Text = "Thông tin chi tiết";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(20, 30);
            this.txtMaSV.PlaceholderText = "Mã sinh viên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(20, 60);
            this.txtHoTen.PlaceholderText = "Họ tên";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(20, 90);
            // 
            // rdoNam
            // 
            this.rdoNam.Location = new System.Drawing.Point(250, 30);
            this.rdoNam.Text = "Nam";
            // 
            // rdoNu
            // 
            this.rdoNu.Location = new System.Drawing.Point(320, 30);
            this.rdoNu.Text = "Nữ";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(250, 60);
            this.txtDienThoai.PlaceholderText = "Điện thoại";
            // 
            // cboQueQuan
            // 
            this.cboQueQuan.Location = new System.Drawing.Point(250, 90);
            this.cboQueQuan.Items.AddRange(new object[] {
            "An Giang",
            "Cần Thơ",
            "Tiền Giang",
            "Hậu Giang"});
            // 
            // Buttons
            // 
            this.btnThem.Text = "Thêm";
            this.btnThem.Location = new System.Drawing.Point(80, 230);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            this.btnXoa.Text = "Xóa";
            this.btnXoa.Location = new System.Drawing.Point(180, 230);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            this.btnSua.Text = "Sửa";
            this.btnSua.Location = new System.Drawing.Point(280, 230);
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            this.btnThoat.Text = "Thoát";
            this.btnThoat.Location = new System.Drawing.Point(380, 230);
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // ListView
            // 
            this.lvSinhVien.Location = new System.Drawing.Point(40, 270);
            this.lvSinhVien.Size = new System.Drawing.Size(600, 150);
            this.lvSinhVien.View = System.Windows.Forms.View.Details;
            this.lvSinhVien.FullRowSelect = true;
            this.lvSinhVien.GridLines = true;
            this.lvSinhVien.SelectedIndexChanged += new System.EventHandler(this.lvSinhVien_SelectedIndexChanged);
            this.lvSinhVien.Columns.Add("Mã SV", 80);
            this.lvSinhVien.Columns.Add("Họ tên", 130);
            this.lvSinhVien.Columns.Add("Ngày sinh", 100);
            this.lvSinhVien.Columns.Add("Phái", 70);
            this.lvSinhVien.Columns.Add("Điện thoại", 120);
            this.lvSinhVien.Columns.Add("Quê quán", 100);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lvSinhVien);
            this.Text = "Quản lý Sinh viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
