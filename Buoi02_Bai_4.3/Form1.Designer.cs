namespace Buoi02_Bai_4._3
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
            btnTinh = new Button();
            txtS = new TextBox();
            txtN = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnTinh
            // 
            btnTinh.Location = new Point(340, 266);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(156, 44);
            btnTinh.TabIndex = 14;
            btnTinh.Text = "Tính";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // txtS
            // 
            txtS.Location = new Point(328, 201);
            txtS.Name = "txtS";
            txtS.Size = new Size(194, 31);
            txtS.TabIndex = 13;
            // 
            // txtN
            // 
            txtN.Location = new Point(328, 140);
            txtN.Name = "txtN";
            txtN.Size = new Size(194, 31);
            txtN.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(278, 207);
            label2.Name = "label2";
            label2.Size = new Size(22, 25);
            label2.TabIndex = 11;
            label2.Text = "S";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(278, 146);
            label1.Name = "label1";
            label1.Size = new Size(22, 25);
            label1.TabIndex = 10;
            label1.Text = "n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTinh);
            Controls.Add(txtS);
            Controls.Add(txtN);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "cấu trúc đơn giản";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTinh;
        private TextBox txtS;
        private TextBox txtN;
        private Label label2;
        private Label label1;
    }
}
