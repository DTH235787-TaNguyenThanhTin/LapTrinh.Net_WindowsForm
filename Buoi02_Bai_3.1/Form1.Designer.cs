namespace Buoi02_Bai_3._1
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
            txtF = new TextBox();
            txtX = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btnTinh = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(292, 121);
            label1.Name = "label1";
            label1.Size = new Size(159, 25);
            label1.TabIndex = 0;
            label1.Text = "Tinh gia tri ham so";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtF);
            groupBox1.Controls.Add(txtX);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(234, 167);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 205);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "thong tin";
            // 
            // txtF
            // 
            txtF.Location = new Point(105, 139);
            txtF.Name = "txtF";
            txtF.Size = new Size(150, 31);
            txtF.TabIndex = 3;
            // 
            // txtX
            // 
            txtX.Location = new Point(105, 77);
            txtX.Name = "txtX";
            txtX.Size = new Size(150, 31);
            txtX.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 142);
            label3.Name = "label3";
            label3.Size = new Size(18, 25);
            label3.TabIndex = 1;
            label3.Text = "f";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 77);
            label2.Name = "label2";
            label2.Size = new Size(20, 25);
            label2.TabIndex = 0;
            label2.Text = "x";
            // 
            // btnTinh
            // 
            btnTinh.Location = new Point(339, 395);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(112, 34);
            btnTinh.TabIndex = 2;
            btnTinh.Text = "Tinh";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTinh);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "bai 3.1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtF;
        private TextBox txtX;
        private Label label3;
        private Label label2;
        private Button btnTinh;
    }
}
