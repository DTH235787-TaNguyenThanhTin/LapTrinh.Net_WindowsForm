namespace Buoi02_Bai_2._6
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
            btnTong = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtB = new TextBox();
            txtA = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btnHieu = new Button();
            btnTich = new Button();
            btnThuong = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnTong
            // 
            btnTong.Location = new Point(102, 359);
            btnTong.Name = "btnTong";
            btnTong.Size = new Size(126, 57);
            btnTong.TabIndex = 5;
            btnTong.Text = "Tong";
            btnTong.UseVisualStyleBackColor = true;
            btnTong.Click += btnTong_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(331, 47);
            label1.Name = "label1";
            label1.Size = new Size(150, 26);
            label1.TabIndex = 4;
            label1.Text = "PHEP TOAN";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtB);
            groupBox1.Controls.Add(txtA);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(250, 89);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 234);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "thong tin";
            // 
            // txtB
            // 
            txtB.Location = new Point(105, 141);
            txtB.Name = "txtB";
            txtB.Size = new Size(150, 31);
            txtB.TabIndex = 3;
            // 
            // txtA
            // 
            txtA.Location = new Point(105, 86);
            txtA.Name = "txtA";
            txtA.Size = new Size(150, 31);
            txtA.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 147);
            label3.Name = "label3";
            label3.Size = new Size(23, 25);
            label3.TabIndex = 1;
            label3.Text = "b";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 86);
            label2.Name = "label2";
            label2.Size = new Size(21, 25);
            label2.TabIndex = 0;
            label2.Text = "a";
            // 
            // btnHieu
            // 
            btnHieu.Location = new Point(272, 359);
            btnHieu.Name = "btnHieu";
            btnHieu.Size = new Size(126, 57);
            btnHieu.TabIndex = 6;
            btnHieu.Text = "Hieu";
            btnHieu.UseVisualStyleBackColor = true;
            btnHieu.Click += btnHieu_Click;
            // 
            // btnTich
            // 
            btnTich.Location = new Point(434, 359);
            btnTich.Name = "btnTich";
            btnTich.Size = new Size(126, 57);
            btnTich.TabIndex = 7;
            btnTich.Text = "Tich";
            btnTich.UseVisualStyleBackColor = true;
            btnTich.Click += btnTich_Click;
            // 
            // btnThuong
            // 
            btnThuong.Location = new Point(595, 359);
            btnThuong.Name = "btnThuong";
            btnThuong.Size = new Size(126, 57);
            btnThuong.TabIndex = 8;
            btnThuong.Text = "Thuong";
            btnThuong.UseVisualStyleBackColor = true;
            btnThuong.Click += btnThuong_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThuong);
            Controls.Add(btnTich);
            Controls.Add(btnHieu);
            Controls.Add(btnTong);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Bai  2.6";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTong;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtB;
        private TextBox txtA;
        private Label label3;
        private Label label2;
        private Button btnHieu;
        private Button btnTich;
        private Button btnThuong;
    }
}
