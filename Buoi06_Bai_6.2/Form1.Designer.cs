using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Buoi06_Bai_6._2
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
            label1 = new Label();
            txtHoTen = new TextBox();
            btnThem = new Button();
            grpChonLop = new GroupBox();
            rdLopA = new RadioButton();
            rdLopB = new RadioButton();
            grpLopA = new GroupBox();
            lstA = new ListBox();
            grpLopB = new GroupBox();
            lstB = new ListBox();
            btnASangB = new Button();
            btnBSangA = new Button();
            btnChuyenHetSangB = new Button();
            btnChuyenHetSangA = new Button();
            btnTong = new Button();
            btnThoat = new Button();
            grpChonLop.SuspendLayout();
            grpLopA.SuspendLayout();
            grpLopB.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            label1.Location = new Point(100, 30);
            label1.Name = "label1";
            label1.Size = new Size(59, 21);
            label1.TabIndex = 0;
            label1.Text = "Họ tên:";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(166, 32);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(200, 23);
            txtHoTen.TabIndex = 1;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(380, 32);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // grpChonLop
            // 
            grpChonLop.Controls.Add(rdLopA);
            grpChonLop.Controls.Add(rdLopB);
            grpChonLop.Location = new Point(180, 70);
            grpChonLop.Name = "grpChonLop";
            grpChonLop.Size = new Size(180, 50);
            grpChonLop.TabIndex = 3;
            grpChonLop.TabStop = false;
            grpChonLop.Text = "Chọn lớp";
            // 
            // rdLopA
            // 
            rdLopA.AutoSize = true;
            rdLopA.Location = new Point(20, 22);
            rdLopA.Name = "rdLopA";
            rdLopA.Size = new Size(56, 19);
            rdLopA.TabIndex = 0;
            rdLopA.TabStop = true;
            rdLopA.Text = "Lớp A";
            rdLopA.UseVisualStyleBackColor = true;
            // 
            // rdLopB
            // 
            rdLopB.AutoSize = true;
            rdLopB.Location = new Point(100, 22);
            rdLopB.Name = "rdLopB";
            rdLopB.Size = new Size(55, 19);
            rdLopB.TabIndex = 1;
            rdLopB.TabStop = true;
            rdLopB.Text = "Lớp B";
            rdLopB.UseVisualStyleBackColor = true;
            // 
            // grpLopA
            // 
            grpLopA.Controls.Add(lstA);
            grpLopA.Location = new Point(100, 140);
            grpLopA.Name = "grpLopA";
            grpLopA.Size = new Size(200, 180);
            grpLopA.TabIndex = 4;
            grpLopA.TabStop = false;
            grpLopA.Text = "Lớp A";
            // 
            // lstA
            // 
            lstA.FormattingEnabled = true;
            lstA.ItemHeight = 15;
            lstA.Items.AddRange(new object[] { "Nguyễn Hoàng Uy", "Trần Quang Toàn", "Tạ Nguyễn Thành Tín" });
            lstA.Location = new Point(16, 25);
            lstA.Name = "lstA";
            lstA.SelectionMode = SelectionMode.MultiExtended;
            lstA.Size = new Size(160, 139);
            lstA.TabIndex = 0;
            // 
            // grpLopB
            // 
            grpLopB.Controls.Add(lstB);
            grpLopB.Location = new Point(420, 140);
            grpLopB.Name = "grpLopB";
            grpLopB.Size = new Size(200, 180);
            grpLopB.TabIndex = 5;
            grpLopB.TabStop = false;
            grpLopB.Text = "Lớp B";
            // 
            // lstB
            // 
            lstB.FormattingEnabled = true;
            lstB.ItemHeight = 15;
            lstB.Items.AddRange(new object[] { "Thái Vĩnh Nghi", "Nguyễn Ngọc Tài", "Trần Đăng Khoa" });
            lstB.Location = new Point(20, 25);
            lstB.Name = "lstB";
            lstB.SelectionMode = SelectionMode.MultiExtended;
            lstB.Size = new Size(160, 139);
            lstB.TabIndex = 0;
            // 
            // btnASangB
            // 
            btnASangB.Location = new Point(320, 170);
            btnASangB.Name = "btnASangB";
            btnASangB.Size = new Size(75, 23);
            btnASangB.TabIndex = 6;
            btnASangB.Text = ">";
            btnASangB.UseVisualStyleBackColor = true;
            btnASangB.Click += btnASangB_Click;
            // 
            // btnBSangA
            // 
            btnBSangA.Location = new Point(320, 200);
            btnBSangA.Name = "btnBSangA";
            btnBSangA.Size = new Size(75, 23);
            btnBSangA.TabIndex = 7;
            btnBSangA.Text = "<";
            btnBSangA.UseVisualStyleBackColor = true;
            btnBSangA.Click += btnBSangA_Click;
            // 
            // btnChuyenHetSangB
            // 
            btnChuyenHetSangB.Location = new Point(320, 230);
            btnChuyenHetSangB.Name = "btnChuyenHetSangB";
            btnChuyenHetSangB.Size = new Size(75, 23);
            btnChuyenHetSangB.TabIndex = 8;
            btnChuyenHetSangB.Text = ">>";
            btnChuyenHetSangB.UseVisualStyleBackColor = true;
            btnChuyenHetSangB.Click += btnChuyenHetSangB_Click;
            // 
            // btnChuyenHetSangA
            // 
            btnChuyenHetSangA.Location = new Point(320, 260);
            btnChuyenHetSangA.Name = "btnChuyenHetSangA";
            btnChuyenHetSangA.Size = new Size(75, 23);
            btnChuyenHetSangA.TabIndex = 9;
            btnChuyenHetSangA.Text = "<<";
            btnChuyenHetSangA.UseVisualStyleBackColor = true;
            btnChuyenHetSangA.Click += btnChuyenHetSangA_Click;
            // 
            // btnTong
            // 
            btnTong.Location = new Point(220, 340);
            btnTong.Name = "btnTong";
            btnTong.Size = new Size(120, 23);
            btnTong.TabIndex = 10;
            btnTong.Text = "Tổng sinh viên";
            btnTong.UseVisualStyleBackColor = true;
            btnTong.Click += btnTong_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(360, 340);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 11;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 400);
            Controls.Add(btnThoat);
            Controls.Add(btnTong);
            Controls.Add(btnChuyenHetSangA);
            Controls.Add(btnChuyenHetSangB);
            Controls.Add(btnBSangA);
            Controls.Add(btnASangB);
            Controls.Add(grpLopB);
            Controls.Add(grpLopA);
            Controls.Add(grpChonLop);
            Controls.Add(btnThem);
            Controls.Add(txtHoTen);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Danh sách sinh viên";
            grpChonLop.ResumeLayout(false);
            grpChonLop.PerformLayout();
            grpLopA.ResumeLayout(false);
            grpLopB.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtHoTen;
        private Button btnThem;
        private GroupBox grpChonLop;
        private RadioButton rdLopA;
        private RadioButton rdLopB;
        private GroupBox grpLopA;
        private ListBox lstA;
        private GroupBox grpLopB;
        private ListBox lstB;
        private Button btnASangB;
        private Button btnBSangA;
        private Button btnChuyenHetSangB;
        private Button btnChuyenHetSangA;
        private Button btnTong;
        private Button btnThoat;
    }
}
