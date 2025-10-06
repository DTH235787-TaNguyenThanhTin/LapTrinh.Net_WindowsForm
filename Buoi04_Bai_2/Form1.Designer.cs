namespace Buoi04_Bai_2
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
            txtNhap = new TextBox();
            lblKQ = new TextBox();
            btnTaomang = new Button();
            btnInmang = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 33);
            label1.Name = "label1";
            label1.Size = new Size(196, 25);
            label1.TabIndex = 0;
            label1.Text = "Nhập số phần tủ mảng";
            // 
            // txtNhap
            // 
            txtNhap.Location = new Point(258, 30);
            txtNhap.Multiline = true;
            txtNhap.Name = "txtNhap";
            txtNhap.Size = new Size(164, 41);
            txtNhap.TabIndex = 1;
            // 
            // lblKQ
            // 
            lblKQ.Location = new Point(67, 104);
            lblKQ.Multiline = true;
            lblKQ.Name = "lblKQ";
            lblKQ.Size = new Size(602, 104);
            lblKQ.TabIndex = 2;
            // 
            // btnTaomang
            // 
            btnTaomang.Location = new Point(447, 30);
            btnTaomang.Name = "btnTaomang";
            btnTaomang.Size = new Size(215, 51);
            btnTaomang.TabIndex = 3;
            btnTaomang.Text = "Tạo mảng random";
            btnTaomang.UseVisualStyleBackColor = true;
            btnTaomang.Click += btnTaomang_Click;
            // 
            // btnInmang
            // 
            btnInmang.Location = new Point(114, 234);
            btnInmang.Name = "btnInmang";
            btnInmang.Size = new Size(150, 53);
            btnInmang.TabIndex = 4;
            btnInmang.Text = "In mảng";
            btnInmang.UseVisualStyleBackColor = true;
            btnInmang.Click += btnInmang_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(429, 234);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(175, 53);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 333);
            Controls.Add(btnThoat);
            Controls.Add(btnInmang);
            Controls.Add(btnTaomang);
            Controls.Add(lblKQ);
            Controls.Add(txtNhap);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNhap;
        private TextBox lblKQ;
        private Button btnTaomang;
        private Button btnInmang;
        private Button btnThoat;
    }
}
