namespace Buoi3_bai5
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
            label2 = new Label();
            txtN = new TextBox();
            txtM = new TextBox();
            groupBox1 = new GroupBox();
            rdo2 = new RadioButton();
            rdo1 = new RadioButton();
            label3 = new Label();
            txtKq = new TextBox();
            btnTinh = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 51);
            label1.Name = "label1";
            label1.Size = new Size(87, 25);
            label1.TabIndex = 0;
            label1.Text = "Nhập n =";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 105);
            label2.Name = "label2";
            label2.Size = new Size(93, 25);
            label2.TabIndex = 1;
            label2.Text = "Nhập m =";
            // 
            // txtN
            // 
            txtN.Location = new Point(169, 51);
            txtN.Name = "txtN";
            txtN.Size = new Size(74, 31);
            txtN.TabIndex = 2;
            // 
            // txtM
            // 
            txtM.Location = new Point(169, 105);
            txtM.Name = "txtM";
            txtM.Size = new Size(74, 31);
            txtM.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdo2);
            groupBox1.Controls.Add(rdo1);
            groupBox1.Location = new Point(366, 51);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(375, 119);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chọn";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // rdo2
            // 
            rdo2.AutoSize = true;
            rdo2.Location = new Point(25, 84);
            rdo2.Name = "rdo2";
            rdo2.Size = new Size(308, 29);
            rdo2.TabIndex = 1;
            rdo2.TabStop = true;
            rdo2.Text = "Ước số chung lớn nhất của n và m";
            rdo2.UseVisualStyleBackColor = true;
            // 
            // rdo1
            // 
            rdo1.AutoSize = true;
            rdo1.Location = new Point(25, 40);
            rdo1.Name = "rdo1";
            rdo1.Size = new Size(269, 29);
            rdo1.TabIndex = 0;
            rdo1.TabStop = true;
            rdo1.Text = "Các ước số chung của n và m";
            rdo1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 240);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 5;
            label3.Text = "kết quả là";
            // 
            // txtKq
            // 
            txtKq.Location = new Point(76, 284);
            txtKq.Name = "txtKq";
            txtKq.Size = new Size(676, 31);
            txtKq.TabIndex = 6;
            // 
            // btnTinh
            // 
            btnTinh.Location = new Point(92, 377);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(112, 34);
            btnTinh.TabIndex = 7;
            btnTinh.Text = "Tính";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(284, 377);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(463, 377);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(112, 34);
            btnThoat.TabIndex = 9;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnTinh);
            Controls.Add(txtKq);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(txtM);
            Controls.Add(txtN);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtN;
        private TextBox txtM;
        private GroupBox groupBox1;
        private RadioButton rdo2;
        private RadioButton rdo1;
        private Label label3;
        private TextBox txtKq;
        private Button btnTinh;
        private Button btnXoa;
        private Button btnThoat;
    }
}
