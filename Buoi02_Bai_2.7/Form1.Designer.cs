namespace Buoi02_Bai_2._7
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
            txtKq = new TextBox();
            label4 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnTong
            // 
            btnTong.Location = new Point(355, 418);
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
            // txtKq
            // 
            txtKq.Location = new Point(355, 347);
            txtKq.Name = "txtKq";
            txtKq.Size = new Size(150, 31);
            txtKq.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(250, 350);
            label4.Name = "label4";
            label4.Size = new Size(71, 25);
            label4.TabIndex = 7;
            label4.Text = "ket qua";
            label4.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 575);
            Controls.Add(label4);
            Controls.Add(txtKq);
            Controls.Add(btnTong);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Bai  2.7";
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
        private TextBox txtKq;
        private Label label4;
    }
}
