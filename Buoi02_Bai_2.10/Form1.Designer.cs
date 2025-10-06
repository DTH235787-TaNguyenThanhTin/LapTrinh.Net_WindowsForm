namespace Buoi02_Bai_2._10
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
            btnThoat = new Button();
            btnDCheo = new Button();
            btnDT = new Button();
            btnCV = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtB = new TextBox();
            txtA = new TextBox();
            label3 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(585, 329);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(126, 57);
            btnThoat.TabIndex = 30;
            btnThoat.Text = "Thoat";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnDCheo
            // 
            btnDCheo.Location = new Point(424, 329);
            btnDCheo.Name = "btnDCheo";
            btnDCheo.Size = new Size(126, 57);
            btnDCheo.TabIndex = 29;
            btnDCheo.Text = "Duong cheo";
            btnDCheo.UseVisualStyleBackColor = true;
            btnDCheo.Click += btnDCheo_Click;
            // 
            // btnDT
            // 
            btnDT.Location = new Point(262, 329);
            btnDT.Name = "btnDT";
            btnDT.Size = new Size(126, 57);
            btnDT.TabIndex = 28;
            btnDT.Text = "Dien tich";
            btnDT.UseVisualStyleBackColor = true;
            btnDT.Click += btnDT_Click;
            // 
            // btnCV
            // 
            btnCV.Location = new Point(92, 329);
            btnCV.Name = "btnCV";
            btnCV.Size = new Size(126, 57);
            btnCV.TabIndex = 27;
            btnCV.Text = "Chu vi";
            btnCV.UseVisualStyleBackColor = true;
            btnCV.Click += btnCV_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(319, 13);
            label1.Name = "label1";
            label1.Size = new Size(207, 26);
            label1.TabIndex = 26;
            label1.Text = "HINH CHU NHAT";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtB);
            groupBox1.Controls.Add(txtA);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(238, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 234);
            groupBox1.TabIndex = 25;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThoat);
            Controls.Add(btnDCheo);
            Controls.Add(btnDT);
            Controls.Add(btnCV);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "bai 2.10";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThoat;
        private Button btnDCheo;
        private Button btnDT;
        private Button btnCV;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtB;
        private TextBox txtA;
        private Label label3;
        private Label label2;
    }
}
