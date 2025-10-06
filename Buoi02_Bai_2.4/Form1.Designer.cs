namespace Buoi02_Bai_2._4
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
            txtTen = new TextBox();
            btnHien = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(196, 181);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 0;
            label1.Text = "Họ tên";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(288, 181);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(231, 31);
            txtTen.TabIndex = 1;
            // 
            // btnHien
            // 
            btnHien.Location = new Point(332, 258);
            btnHien.Name = "btnHien";
            btnHien.Size = new Size(112, 34);
            btnHien.TabIndex = 2;
            btnHien.Text = "Hiển thị";
            btnHien.UseVisualStyleBackColor = true;
            btnHien.Click += btnHien_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHien);
            Controls.Add(txtTen);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Bai  2.4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTen;
        private Button btnHien;
    }
}
