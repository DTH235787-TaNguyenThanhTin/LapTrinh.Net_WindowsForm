namespace Buoi02_Bai_3._3
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
            txtYear = new TextBox();
            txtMonth = new TextBox();
            txtDay = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnKiem = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(278, 100);
            label1.Name = "label1";
            label1.Size = new Size(176, 25);
            label1.TabIndex = 0;
            label1.Text = "Kiem tra ngay hop le";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtYear);
            groupBox1.Controls.Add(txtMonth);
            groupBox1.Controls.Add(txtDay);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(205, 144);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(360, 218);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "thong tin";
            // 
            // txtYear
            // 
            txtYear.Location = new Point(127, 149);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(150, 31);
            txtYear.TabIndex = 5;
            // 
            // txtMonth
            // 
            txtMonth.Location = new Point(127, 100);
            txtMonth.Name = "txtMonth";
            txtMonth.Size = new Size(150, 31);
            txtMonth.TabIndex = 4;
            txtMonth.TextChanged += txtMonth_TextChanged;
            // 
            // txtDay
            // 
            txtDay.Location = new Point(127, 57);
            txtDay.Name = "txtDay";
            txtDay.Size = new Size(150, 31);
            txtDay.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 152);
            label4.Name = "label4";
            label4.Size = new Size(47, 25);
            label4.TabIndex = 2;
            label4.Text = "nam";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 100);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 1;
            label3.Text = "thang";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 57);
            label2.Name = "label2";
            label2.Size = new Size(51, 25);
            label2.TabIndex = 0;
            label2.Text = "ngay";
            // 
            // btnKiem
            // 
            btnKiem.Location = new Point(332, 391);
            btnKiem.Name = "btnKiem";
            btnKiem.Size = new Size(112, 34);
            btnKiem.TabIndex = 2;
            btnKiem.Text = "Kiem Tra";
            btnKiem.UseVisualStyleBackColor = true;
            btnKiem.Click += btnKiem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnKiem);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Bai  3.3";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private TextBox txtMonth;
        private TextBox txtDay;
        private Label label4;
        private TextBox txtYear;
        private Button btnKiem;
    }
}
