namespace Buoi02_Bai_4._1
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
            txtN = new TextBox();
            txtS = new TextBox();
            btnTinh = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(246, 190);
            label1.Name = "label1";
            label1.Size = new Size(22, 25);
            label1.TabIndex = 0;
            label1.Text = "n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(246, 251);
            label2.Name = "label2";
            label2.Size = new Size(22, 25);
            label2.TabIndex = 1;
            label2.Text = "S";
            // 
            // txtN
            // 
            txtN.Location = new Point(296, 184);
            txtN.Name = "txtN";
            txtN.Size = new Size(194, 31);
            txtN.TabIndex = 2;
            // 
            // txtS
            // 
            txtS.Location = new Point(296, 245);
            txtS.Name = "txtS";
            txtS.Size = new Size(194, 31);
            txtS.TabIndex = 3;
            // 
            // btnTinh
            // 
            btnTinh.Location = new Point(308, 310);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(156, 44);
            btnTinh.TabIndex = 4;
            btnTinh.Text = "Tính";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
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
            Text = "Cau Truc lap";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtN;
        private TextBox txtS;
        private Button btnTinh;
    }
}
