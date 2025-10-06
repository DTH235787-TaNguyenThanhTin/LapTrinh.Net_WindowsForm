namespace Buoi3_bai6
{
    partial class lstTen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txtChuoi = new TextBox();
            btnThem = new Button();
            btnXoa = new Button();
            btnMauchu = new Button();
            btnMaunen = new Button();
            btnFont = new Button();
            btnDong = new Button();
            txtKq = new TextBox();
            lstChuoi = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtChuoi);
            groupBox1.Location = new Point(37, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(269, 78);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập chuỗi";
            // 
            // txtChuoi
            // 
            txtChuoi.Location = new Point(6, 41);
            txtChuoi.Name = "txtChuoi";
            txtChuoi.Size = new Size(257, 31);
            txtChuoi.TabIndex = 0;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(28, 143);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 34);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(172, 143);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(128, 34);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnMauchu
            // 
            btnMauchu.Location = new Point(328, 206);
            btnMauchu.Name = "btnMauchu";
            btnMauchu.Size = new Size(154, 34);
            btnMauchu.TabIndex = 5;
            btnMauchu.Text = "Chọn màu chữ";
            btnMauchu.UseVisualStyleBackColor = true;
            btnMauchu.Click += btnMauchu_Click;
            // 
            // btnMaunen
            // 
            btnMaunen.Location = new Point(488, 206);
            btnMaunen.Name = "btnMaunen";
            btnMaunen.Size = new Size(154, 34);
            btnMaunen.TabIndex = 6;
            btnMaunen.Text = "Chọn màu nền";
            btnMaunen.UseVisualStyleBackColor = true;
            btnMaunen.Click += btnMaunen_Click;
            // 
            // btnFont
            // 
            btnFont.Location = new Point(648, 206);
            btnFont.Name = "btnFont";
            btnFont.Size = new Size(115, 34);
            btnFont.TabIndex = 7;
            btnFont.Text = "Chọn Font";
            btnFont.UseVisualStyleBackColor = true;
            btnFont.Click += btnFont_Click;
            // 
            // btnDong
            // 
            btnDong.Location = new Point(488, 286);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(154, 34);
            btnDong.TabIndex = 8;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // txtKq
            // 
            txtKq.Location = new Point(328, 48);
            txtKq.Multiline = true;
            txtKq.Name = "txtKq";
            txtKq.RightToLeft = RightToLeft.No;
            txtKq.Size = new Size(425, 125);
            txtKq.TabIndex = 9;
            txtKq.TextChanged += txtKq_TextChanged;
            // 
            // lstChuoi
            // 
            lstChuoi.FormattingEnabled = true;
            lstChuoi.ItemHeight = 25;
            lstChuoi.Location = new Point(12, 206);
            lstChuoi.Name = "lstChuoi";
            lstChuoi.Size = new Size(294, 179);
            lstChuoi.TabIndex = 10;
            lstChuoi.SelectedIndexChanged += lstChuoi_DoubleClick;
            // 
            // lstTen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstChuoi);
            Controls.Add(txtKq);
            Controls.Add(btnDong);
            Controls.Add(btnFont);
            Controls.Add(btnMaunen);
            Controls.Add(btnMauchu);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(groupBox1);
            Name = "lstTen";
            Text = "Form1";
            Load += lstTen_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnThem;
        private Button btnXoa;
        private Button btnMauchu;
        private Button btnMaunen;
        private Button btnFont;
        private Button btnDong;
        private TextBox txtKq;
        private TextBox txtChuoi;
        private ListBox lstChuoi;
    }
}
