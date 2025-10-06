namespace Buoi02_Bai_3._2
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
            txtMua = new TextBox();
            btnThongBao = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(298, 84);
            label1.Name = "label1";
            label1.Size = new Size(136, 25);
            label1.TabIndex = 0;
            label1.Text = "Mua trong nam";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(185, 195);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 1;
            label2.Text = "Thang";
            // 
            // txtMua
            // 
            txtMua.Location = new Point(311, 196);
            txtMua.Name = "txtMua";
            txtMua.Size = new Size(150, 31);
            txtMua.TabIndex = 2;
            // 
            // btnThongBao
            // 
            btnThongBao.Location = new Point(322, 285);
            btnThongBao.Name = "btnThongBao";
            btnThongBao.Size = new Size(112, 34);
            btnThongBao.TabIndex = 3;
            btnThongBao.Text = "Thông Báo";
            btnThongBao.UseVisualStyleBackColor = true;
            btnThongBao.Click += btnThongBao_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThongBao);
            Controls.Add(txtMua);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "bai 3.2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtMua;
        private Button btnThongBao;
    }
}
