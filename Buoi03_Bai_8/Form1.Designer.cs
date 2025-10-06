namespace Buoi3_bai8
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
            cboTen = new ComboBox();
            btnHien = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(143, 107);
            label1.Name = "label1";
            label1.Size = new Size(67, 25);
            label1.TabIndex = 0;
            label1.Text = "Họ Tên";
            // 
            // cboTen
            // 
            cboTen.FormattingEnabled = true;
            cboTen.Items.AddRange(new object[] { "Nguyen Van A", "Tran Van C" });
            cboTen.Location = new Point(270, 99);
            cboTen.Name = "cboTen";
            cboTen.Size = new Size(182, 33);
            cboTen.TabIndex = 1;
            // 
            // btnHien
            // 
            btnHien.Location = new Point(270, 200);
            btnHien.Name = "btnHien";
            btnHien.Size = new Size(181, 34);
            btnHien.TabIndex = 2;
            btnHien.Text = "Hiện Lời Chào";
            btnHien.UseVisualStyleBackColor = true;
            btnHien.Click += btnHien_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 450);
            Controls.Add(btnHien);
            Controls.Add(cboTen);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboTen;
        private Button btnHien;
    }
}
