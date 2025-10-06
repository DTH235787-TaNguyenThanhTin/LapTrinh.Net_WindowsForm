namespace Buoi3_bai7
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
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            tongToolStripMenuItem = new ToolStripMenuItem();
            hieuToolStripMenuItem = new ToolStripMenuItem();
            tichToolStripMenuItem = new ToolStripMenuItem();
            thuongToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtB = new TextBox();
            txtA = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtKq = new TextBox();
            label4 = new Label();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "Tinh toan";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { tongToolStripMenuItem, hieuToolStripMenuItem, tichToolStripMenuItem, thuongToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(103, 29);
            toolStripMenuItem1.Text = "Tinh Toan";
            // 
            // tongToolStripMenuItem
            // 
            tongToolStripMenuItem.Name = "tongToolStripMenuItem";
            tongToolStripMenuItem.Size = new Size(270, 34);
            tongToolStripMenuItem.Text = "Tong";
            tongToolStripMenuItem.Click += tongToolStripMenuItem_Click_1;
            // 
            // hieuToolStripMenuItem
            // 
            hieuToolStripMenuItem.Name = "hieuToolStripMenuItem";
            hieuToolStripMenuItem.Size = new Size(270, 34);
            hieuToolStripMenuItem.Text = "Hieu";
            hieuToolStripMenuItem.Click += hieuToolStripMenuItem_Click;
            // 
            // tichToolStripMenuItem
            // 
            tichToolStripMenuItem.Name = "tichToolStripMenuItem";
            tichToolStripMenuItem.Size = new Size(270, 34);
            tichToolStripMenuItem.Text = "Tich";
            tichToolStripMenuItem.Click += tichToolStripMenuItem_Click;
            // 
            // thuongToolStripMenuItem
            // 
            thuongToolStripMenuItem.Name = "thuongToolStripMenuItem";
            thuongToolStripMenuItem.Size = new Size(270, 34);
            thuongToolStripMenuItem.Text = "Thuong";
            thuongToolStripMenuItem.Click += thuongToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(289, 79);
            label1.Name = "label1";
            label1.Size = new Size(173, 25);
            label1.TabIndex = 1;
            label1.Text = "Phep Toan Don Gian";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtB);
            groupBox1.Controls.Add(txtA);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(255, 171);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 150);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtB
            // 
            txtB.Location = new Point(118, 97);
            txtB.Name = "txtB";
            txtB.Size = new Size(150, 31);
            txtB.TabIndex = 3;
            // 
            // txtA
            // 
            txtA.Location = new Point(118, 55);
            txtA.Name = "txtA";
            txtA.Size = new Size(150, 31);
            txtA.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 103);
            label3.Name = "label3";
            label3.Size = new Size(71, 25);
            label3.TabIndex = 1;
            label3.Text = "Nhập b";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 55);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 0;
            label2.Text = "Nhập a";
            // 
            // txtKq
            // 
            txtKq.Location = new Point(373, 360);
            txtKq.Name = "txtKq";
            txtKq.Size = new Size(150, 31);
            txtKq.TabIndex = 3;
            txtKq.TextChanged += txtKq_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(283, 365);
            label4.Name = "label4";
            label4.Size = new Size(72, 25);
            label4.TabIndex = 4;
            label4.Text = "Kết quả";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(txtKq);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Name = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem tongToolStripMenuItem;
        private ToolStripMenuItem hieuToolStripMenuItem;
        private ToolStripMenuItem tichToolStripMenuItem;
        private ToolStripMenuItem thuongToolStripMenuItem;
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
