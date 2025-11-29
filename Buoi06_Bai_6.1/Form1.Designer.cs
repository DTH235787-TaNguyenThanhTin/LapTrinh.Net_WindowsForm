namespace Buoi06_Bai_6._1
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
            txtKetQua = new TextBox();
            btnDoiFont = new Button();
            btnChonMau = new Button();
            btnOpen = new Button();
            btnSave = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 38);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 0;
            label1.Text = "Nhập đoạn văn bản:";
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(127, 56);
            txtKetQua.Multiline = true;
            txtKetQua.Name = "txtKetQua";
            txtKetQua.Size = new Size(394, 108);
            txtKetQua.TabIndex = 1;
            // 
            // btnDoiFont
            // 
            btnDoiFont.Location = new Point(161, 180);
            btnDoiFont.Name = "btnDoiFont";
            btnDoiFont.Size = new Size(75, 23);
            btnDoiFont.TabIndex = 2;
            btnDoiFont.Text = "Đổi font";
            btnDoiFont.UseVisualStyleBackColor = true;
            btnDoiFont.Click += btnDoiFont_Click;
            // 
            // btnChonMau
            // 
            btnChonMau.Location = new Point(242, 180);
            btnChonMau.Name = "btnChonMau";
            btnChonMau.Size = new Size(75, 23);
            btnChonMau.TabIndex = 3;
            btnChonMau.Text = "Chọn màu";
            btnChonMau.UseVisualStyleBackColor = true;
            btnChonMau.Click += btnChonMau_Click;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(323, 180);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(75, 23);
            btnOpen.TabIndex = 4;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(404, 180);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(276, 219);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThoat);
            Controls.Add(btnSave);
            Controls.Add(btnOpen);
            Controls.Add(btnChonMau);
            Controls.Add(btnDoiFont);
            Controls.Add(txtKetQua);
            Controls.Add(label1);
            Name = "Form1";
            Text = "CommonDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtKetQua;
        private Button btnDoiFont;
        private Button btnChonMau;
        private Button btnOpen;
        private Button btnSave;
        private Button btnThoat;
    }
}
