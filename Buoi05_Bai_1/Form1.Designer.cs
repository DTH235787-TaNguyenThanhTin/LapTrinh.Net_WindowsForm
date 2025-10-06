namespace Buoi05_Bai_1
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
            label3 = new Label();
            label4 = new Label();
            txtNhap = new TextBox();
            txtKT = new TextBox();
            txtTim = new TextBox();
            btnReset = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(281, 35);
            label1.Name = "label1";
            label1.Size = new Size(171, 25);
            label1.TabIndex = 0;
            label1.Text = "Kiểm tra và Tìm SNT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(195, 120);
            label2.Name = "label2";
            label2.Size = new Size(73, 25);
            label2.TabIndex = 1;
            label2.Text = "Nhập N";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(154, 182);
            label3.Name = "label3";
            label3.Size = new Size(114, 25);
            label3.TabIndex = 2;
            label3.Text = "Kiểm tra SNT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(100, 237);
            label4.Name = "label4";
            label4.Size = new Size(168, 25);
            label4.TabIndex = 3;
            label4.Text = "Tìm SNT nhỏ hơn N";
            // 
            // txtNhap
            // 
            txtNhap.Location = new Point(281, 120);
            txtNhap.Name = "txtNhap";
            txtNhap.Size = new Size(204, 31);
            txtNhap.TabIndex = 4;
            // 
            // txtKT
            // 
            txtKT.Location = new Point(281, 182);
            txtKT.Name = "txtKT";
            txtKT.Size = new Size(204, 31);
            txtKT.TabIndex = 5;
            // 
            // txtTim
            // 
            txtTim.Location = new Point(281, 237);
            txtTim.Name = "txtTim";
            txtTim.Size = new Size(204, 31);
            txtTim.TabIndex = 6;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(176, 307);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(119, 46);
            btnReset.TabIndex = 7;
            btnReset.Text = "Làm lại";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(402, 307);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(123, 46);
            btnClose.TabIndex = 8;
            btnClose.Text = "Thoát";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(btnReset);
            Controls.Add(txtTim);
            Controls.Add(txtKT);
            Controls.Add(txtNhap);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Làm lại";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNhap;
        private TextBox txtKT;
        private TextBox txtTim;
        private Button btnReset;
        private Button btnClose;
    }
}
