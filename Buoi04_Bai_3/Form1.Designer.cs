namespace Buoi04_Bai_3
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
            txtNhap = new TextBox();
            label1 = new Label();
            btnTaomang = new Button();
            btnTongmang = new Button();
            btnSoLonNhat = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // txtNhap
            // 
            txtNhap.Location = new Point(289, 22);
            txtNhap.Name = "txtNhap";
            txtNhap.Size = new Size(131, 31);
            txtNhap.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 25);
            label1.Name = "label1";
            label1.Size = new Size(196, 25);
            label1.TabIndex = 2;
            label1.Text = "Nhap so phan tu mang";
            // 
            // btnTaomang
            // 
            btnTaomang.Location = new Point(455, 12);
            btnTaomang.Name = "btnTaomang";
            btnTaomang.Size = new Size(176, 51);
            btnTaomang.TabIndex = 3;
            btnTaomang.Text = "Tao mang random";
            btnTaomang.UseVisualStyleBackColor = true;
            btnTaomang.Click += btnTaomang_Click;
            // 
            // btnTongmang
            // 
            btnTongmang.Enabled = false;
            btnTongmang.Location = new Point(28, 86);
            btnTongmang.Name = "btnTongmang";
            btnTongmang.Size = new Size(151, 49);
            btnTongmang.TabIndex = 4;
            btnTongmang.Text = "Tổng Mảng";
            btnTongmang.UseVisualStyleBackColor = true;
            btnTongmang.Click += btnTongmang_Click;
            // 
            // btnSoLonNhat
            // 
            btnSoLonNhat.Enabled = false;
            btnSoLonNhat.Location = new Point(250, 86);
            btnSoLonNhat.Name = "btnSoLonNhat";
            btnSoLonNhat.Size = new Size(157, 49);
            btnSoLonNhat.TabIndex = 5;
            btnSoLonNhat.Text = "Số Lớn Nhất";
            btnSoLonNhat.UseVisualStyleBackColor = true;
            btnSoLonNhat.Click += btnSoLonNhat_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(485, 86);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(150, 49);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 190);
            Controls.Add(btnThoat);
            Controls.Add(btnSoLonNhat);
            Controls.Add(btnTongmang);
            Controls.Add(btnTaomang);
            Controls.Add(label1);
            Controls.Add(txtNhap);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNhap;
        private Label label1;
        private Button btnTaomang;
        private Button btnTongmang;
        private Button btnSoLonNhat;
        private Button btnThoat;
    }
}
