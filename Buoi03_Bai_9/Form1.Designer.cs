namespace Buoi3_bai9
{
    partial class Form1
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            chkLam = new CheckBox();
            chkHoc = new CheckBox();
            groupBox2 = new GroupBox();
            rdNu = new RadioButton();
            rdNam = new RadioButton();
            Time = new DateTimePicker();
            txtEmail = new TextBox();
            txtDienthoai = new TextBox();
            txtDiachi = new TextBox();
            txtTen = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnHien = new Button();
            btnThoat = new Button();
            grpHinh = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            grpHinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(288, 27);
            label1.Name = "label1";
            label1.Size = new Size(252, 27);
            label1.TabIndex = 0;
            label1.Text = "THÔNG TIN CÁ NHÂN";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkLam);
            groupBox1.Controls.Add(chkHoc);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(Time);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtDienthoai);
            groupBox1.Controls.Add(txtDiachi);
            groupBox1.Controls.Add(txtTen);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(58, 83);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(524, 444);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "s";
            // 
            // chkLam
            // 
            chkLam.AutoSize = true;
            chkLam.Location = new Point(322, 380);
            chkLam.Name = "chkLam";
            chkLam.Size = new Size(135, 29);
            chkLam.TabIndex = 14;
            chkLam.Text = "Đang đi làm";
            chkLam.UseVisualStyleBackColor = true;
            // 
            // chkHoc
            // 
            chkHoc.AutoSize = true;
            chkHoc.Location = new Point(181, 380);
            chkHoc.Name = "chkHoc";
            chkHoc.Size = new Size(135, 29);
            chkHoc.TabIndex = 13;
            chkHoc.Text = "Đang đi học";
            chkHoc.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rdNu);
            groupBox2.Controls.Add(rdNam);
            groupBox2.Location = new Point(149, 95);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(300, 63);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            // 
            // rdNu
            // 
            rdNu.AutoSize = true;
            rdNu.Location = new Point(131, 16);
            rdNu.Name = "rdNu";
            rdNu.Size = new Size(61, 29);
            rdNu.TabIndex = 1;
            rdNu.TabStop = true;
            rdNu.Text = "Nữ";
            rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            rdNam.AutoSize = true;
            rdNam.Location = new Point(12, 16);
            rdNam.Name = "rdNam";
            rdNam.Size = new Size(75, 29);
            rdNam.TabIndex = 0;
            rdNam.TabStop = true;
            rdNam.Text = "Nam";
            rdNam.UseVisualStyleBackColor = true;
            // 
            // Time
            // 
            Time.Location = new Point(149, 157);
            Time.Name = "Time";
            Time.Size = new Size(300, 31);
            Time.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(152, 321);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(297, 31);
            txtEmail.TabIndex = 10;
            // 
            // txtDienthoai
            // 
            txtDienthoai.Location = new Point(152, 269);
            txtDienthoai.Name = "txtDienthoai";
            txtDienthoai.Size = new Size(297, 31);
            txtDienthoai.TabIndex = 9;
            // 
            // txtDiachi
            // 
            txtDiachi.Location = new Point(152, 210);
            txtDiachi.Name = "txtDiachi";
            txtDiachi.Size = new Size(297, 31);
            txtDiachi.TabIndex = 8;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(152, 58);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(297, 31);
            txtTen.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(43, 364);
            label8.Name = "label8";
            label8.Size = new Size(92, 25);
            label8.TabIndex = 6;
            label8.Text = "Tình trạng";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(43, 321);
            label7.Name = "label7";
            label7.Size = new Size(54, 25);
            label7.TabIndex = 5;
            label7.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 269);
            label6.Name = "label6";
            label6.Size = new Size(93, 25);
            label6.TabIndex = 4;
            label6.Text = "Điện thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 216);
            label5.Name = "label5";
            label5.Size = new Size(65, 25);
            label5.TabIndex = 3;
            label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 163);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 2;
            label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 111);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 1;
            label3.Text = "Giới tính";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 58);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 0;
            label2.Text = "Họ tên";
            // 
            // btnHien
            // 
            btnHien.Location = new Point(59, 566);
            btnHien.Name = "btnHien";
            btnHien.Size = new Size(180, 34);
            btnHien.TabIndex = 2;
            btnHien.Text = "Hiện Thông Tin";
            btnHien.UseVisualStyleBackColor = true;
            btnHien.Click += btnHien_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(310, 566);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(112, 34);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // grpHinh
            // 
            grpHinh.Controls.Add(pictureBox1);
            grpHinh.Location = new Point(627, 83);
            grpHinh.Name = "grpHinh";
            grpHinh.Size = new Size(203, 241);
            grpHinh.TabIndex = 4;
            grpHinh.TabStop = false;
            grpHinh.Text = "Hình ảnh";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(31, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 176);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 672);
            Controls.Add(grpHinh);
            Controls.Add(btnThoat);
            Controls.Add(btnHien);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            grpHinh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private DateTimePicker Time;
        private TextBox txtEmail;
        private TextBox txtDienthoai;
        private TextBox txtDiachi;
        private TextBox txtTen;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private CheckBox chkHoc;
        private GroupBox groupBox2;
        private RadioButton rdNu;
        private RadioButton rdNam;
        private CheckBox chkLam;
        private Button btnHien;
        private Button btnThoat;
        private GroupBox grpHinh;
        private PictureBox pictureBox1;
    }
}
