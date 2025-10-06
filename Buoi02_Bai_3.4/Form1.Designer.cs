namespace Buoi02_Bai_3._4
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
            txtC = new TextBox();
            txtB = new TextBox();
            txtA = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            txtKq = new TextBox();
            btnGiai = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(249, 79);
            label1.Name = "label1";
            label1.Size = new Size(195, 25);
            label1.TabIndex = 0;
            label1.Text = "PHUONG TRINH BAC 2";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtC);
            groupBox1.Controls.Add(txtB);
            groupBox1.Controls.Add(txtA);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(178, 116);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(369, 225);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "phuong trinh";
            // 
            // txtC
            // 
            txtC.Location = new Point(100, 163);
            txtC.Name = "txtC";
            txtC.Size = new Size(150, 31);
            txtC.TabIndex = 5;
            // 
            // txtB
            // 
            txtB.Location = new Point(100, 103);
            txtB.Name = "txtB";
            txtB.Size = new Size(150, 31);
            txtB.TabIndex = 4;
            // 
            // txtA
            // 
            txtA.Location = new Point(100, 54);
            txtA.Name = "txtA";
            txtA.Size = new Size(150, 31);
            txtA.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 163);
            label4.Name = "label4";
            label4.Size = new Size(20, 25);
            label4.TabIndex = 2;
            label4.Text = "c";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 103);
            label3.Name = "label3";
            label3.Size = new Size(23, 25);
            label3.TabIndex = 1;
            label3.Text = "b";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 54);
            label2.Name = "label2";
            label2.Size = new Size(21, 25);
            label2.TabIndex = 0;
            label2.Text = "a";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(147, 374);
            label5.Name = "label5";
            label5.Size = new Size(71, 25);
            label5.TabIndex = 2;
            label5.Text = "ket qua";
            // 
            // txtKq
            // 
            txtKq.Location = new Point(251, 374);
            txtKq.Name = "txtKq";
            txtKq.Size = new Size(296, 31);
            txtKq.TabIndex = 3;
            // 
            // btnGiai
            // 
            btnGiai.Location = new Point(273, 448);
            btnGiai.Name = "btnGiai";
            btnGiai.Size = new Size(155, 54);
            btnGiai.TabIndex = 4;
            btnGiai.Text = "Giải";
            btnGiai.UseVisualStyleBackColor = true;
            btnGiai.Click += btnGiai_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 530);
            Controls.Add(btnGiai);
            Controls.Add(txtKq);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Bai  3.4";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtC;
        private TextBox txtB;
        private TextBox txtA;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private TextBox txtKq;
        private Button btnGiai;
    }
}
