namespace Buoi04_Bai_1
{
    partial class form1
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
            txtNhap = new TextBox();
            lblKQ = new TextBox();
            btnNhap = new Button();
            btnIn = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            btnSXTang = new Button();
            btnSXGiam = new Button();
            btnDemSoChan = new Button();
            btnDemSoLe = new Button();
            btnSoNguyenTo = new Button();
            btnSHH = new Button();
            btnSum = new Button();
            btnUCLN = new Button();
            btnTBMang = new Button();
            btnMin = new Button();
            btnMax = new Button();
            SuspendLayout();
            // 
            // txtNhap
            // 
            txtNhap.BackColor = SystemColors.Info;
            txtNhap.Location = new Point(239, 28);
            txtNhap.Name = "txtNhap";
            txtNhap.Size = new Size(150, 31);
            txtNhap.TabIndex = 0;
            // 
            // lblKQ
            // 
            lblKQ.BackColor = SystemColors.InactiveCaption;
            lblKQ.Location = new Point(23, 75);
            lblKQ.Multiline = true;
            lblKQ.Name = "lblKQ";
            lblKQ.Size = new Size(660, 168);
            lblKQ.TabIndex = 1;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(23, 18);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(210, 51);
            btnNhap.TabIndex = 2;
            btnNhap.Text = "Nhập 1 phần tử";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnIn
            // 
            btnIn.Location = new Point(405, 18);
            btnIn.Name = "btnIn";
            btnIn.Size = new Size(134, 51);
            btnIn.TabIndex = 3;
            btnIn.Text = "In Mảng";
            btnIn.UseVisualStyleBackColor = true;
            btnIn.Click += btnIn_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(545, 18);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(138, 51);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(703, 17);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(151, 53);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnSXTang
            // 
            btnSXTang.Location = new Point(703, 98);
            btnSXTang.Name = "btnSXTang";
            btnSXTang.Size = new Size(151, 61);
            btnSXTang.TabIndex = 6;
            btnSXTang.Text = "Sắp xếp Tăng";
            btnSXTang.UseVisualStyleBackColor = true;
            btnSXTang.Click += btnSXTang_Click;
            // 
            // btnSXGiam
            // 
            btnSXGiam.Location = new Point(703, 182);
            btnSXGiam.Name = "btnSXGiam";
            btnSXGiam.Size = new Size(151, 61);
            btnSXGiam.TabIndex = 7;
            btnSXGiam.Text = "Sắp xếp Giảm";
            btnSXGiam.UseVisualStyleBackColor = true;
            btnSXGiam.Click += btnSXGiam_Click;
            // 
            // btnDemSoChan
            // 
            btnDemSoChan.Location = new Point(23, 265);
            btnDemSoChan.Name = "btnDemSoChan";
            btnDemSoChan.Size = new Size(139, 47);
            btnDemSoChan.TabIndex = 8;
            btnDemSoChan.Text = "Đếm số chẵn";
            btnDemSoChan.UseVisualStyleBackColor = true;
            btnDemSoChan.Click += btnDemSoChan_Click;
            // 
            // btnDemSoLe
            // 
            btnDemSoLe.Location = new Point(178, 265);
            btnDemSoLe.Name = "btnDemSoLe";
            btnDemSoLe.Size = new Size(134, 47);
            btnDemSoLe.TabIndex = 9;
            btnDemSoLe.Text = "Đếm số lẻ";
            btnDemSoLe.UseVisualStyleBackColor = true;
            btnDemSoLe.Click += btnDemSoLe_Click;
            // 
            // btnSoNguyenTo
            // 
            btnSoNguyenTo.Location = new Point(328, 265);
            btnSoNguyenTo.Name = "btnSoNguyenTo";
            btnSoNguyenTo.Size = new Size(154, 47);
            btnSoNguyenTo.TabIndex = 10;
            btnSoNguyenTo.Text = "Số nguyên tố";
            btnSoNguyenTo.UseVisualStyleBackColor = true;
            btnSoNguyenTo.Click += btnSoNguyenTo_Click;
            // 
            // btnSHH
            // 
            btnSHH.Location = new Point(497, 265);
            btnSHH.Name = "btnSHH";
            btnSHH.Size = new Size(175, 47);
            btnSHH.TabIndex = 11;
            btnSHH.Text = "Số hoàn hảo";
            btnSHH.UseVisualStyleBackColor = true;
            btnSHH.Click += btnSHH_Click;
            // 
            // btnSum
            // 
            btnSum.Location = new Point(678, 265);
            btnSum.Name = "btnSum";
            btnSum.Size = new Size(176, 47);
            btnSum.TabIndex = 12;
            btnSum.Text = "Tổng mảng";
            btnSum.UseVisualStyleBackColor = true;
            btnSum.Click += btnSum_Click;
            // 
            // btnUCLN
            // 
            btnUCLN.Location = new Point(23, 335);
            btnUCLN.Name = "btnUCLN";
            btnUCLN.Size = new Size(244, 48);
            btnUCLN.TabIndex = 13;
            btnUCLN.Text = "UCLN 2 phần tử đầu tiên";
            btnUCLN.UseVisualStyleBackColor = true;
            btnUCLN.Click += btnUCLN_Click;
            // 
            // btnTBMang
            // 
            btnTBMang.Location = new Point(290, 335);
            btnTBMang.Name = "btnTBMang";
            btnTBMang.Size = new Size(208, 48);
            btnTBMang.TabIndex = 14;
            btnTBMang.Text = "Trung Bình Mảng";
            btnTBMang.UseVisualStyleBackColor = true;
            btnTBMang.Click += btnTBMang_Click;
            // 
            // btnMin
            // 
            btnMin.Location = new Point(519, 335);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(164, 48);
            btnMin.TabIndex = 15;
            btnMin.Text = "Số Nhỏ Nhất";
            btnMin.UseVisualStyleBackColor = true;
            btnMin.Click += btnMin_Click;
            // 
            // btnMax
            // 
            btnMax.Location = new Point(689, 335);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(164, 48);
            btnMax.TabIndex = 16;
            btnMax.Text = "Số Lớn Nhất";
            btnMax.UseVisualStyleBackColor = true;
            btnMax.Click += btnMax_Click;
            // 
            // form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 403);
            Controls.Add(btnMax);
            Controls.Add(btnMin);
            Controls.Add(btnTBMang);
            Controls.Add(btnUCLN);
            Controls.Add(btnSum);
            Controls.Add(btnSHH);
            Controls.Add(btnSoNguyenTo);
            Controls.Add(btnDemSoLe);
            Controls.Add(btnDemSoChan);
            Controls.Add(btnSXGiam);
            Controls.Add(btnSXTang);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnIn);
            Controls.Add(btnNhap);
            Controls.Add(lblKQ);
            Controls.Add(txtNhap);
            Name = "form1";
            Text = "Mảng số nguyên";
            Load += form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNhap;
        private TextBox lblKQ;
        private Button btnNhap;
        private Button btnIn;
        private Button btnXoa;
        private Button btnThoat;
        private Button btnSXTang;
        private Button btnSXGiam;
        private Button btnDemSoChan;
        private Button btnDemSoLe;
        private Button btnSoNguyenTo;
        private Button btnSHH;
        private Button btnSum;
        private Button btnUCLN;
        private Button btnTBMang;
        private Button btnMin;
        private Button btnMax;
    }
}
