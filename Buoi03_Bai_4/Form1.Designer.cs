namespace Buoi3_bai4
{
    partial class txtHoTen
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
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            rdoChuthuong = new RadioButton();
            rdoChuhoa = new RadioButton();
            btnXoa = new Button();
            btnThoat = new Button();
            btnKq = new Button();
            textBox2 = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 59);
            label1.Name = "label1";
            label1.Size = new Size(116, 25);
            label1.TabIndex = 0;
            label1.Text = "Nhập họ tên ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(261, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(338, 31);
            textBox1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(rdoChuhoa);
            groupBox1.Controls.Add(rdoChuthuong);
            groupBox1.Location = new Point(116, 115);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(483, 237);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chọn kiểu chữ ";
            // 
            // rdoChuthuong
            // 
            rdoChuthuong.AutoSize = true;
            rdoChuthuong.Location = new Point(33, 87);
            rdoChuthuong.Name = "rdoChuthuong";
            rdoChuthuong.Size = new Size(133, 29);
            rdoChuthuong.TabIndex = 0;
            rdoChuthuong.TabStop = true;
            rdoChuthuong.Text = "Chữ thường";
            rdoChuthuong.UseVisualStyleBackColor = true;
            // 
            // rdoChuhoa
            // 
            rdoChuhoa.AutoSize = true;
            rdoChuhoa.Location = new Point(33, 150);
            rdoChuhoa.Name = "rdoChuhoa";
            rdoChuhoa.Size = new Size(104, 29);
            rdoChuhoa.TabIndex = 1;
            rdoChuhoa.TabStop = true;
            rdoChuhoa.Text = "Chữ hoa";
            rdoChuhoa.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(313, 87);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(313, 150);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(112, 34);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnKq
            // 
            btnKq.Location = new Point(116, 374);
            btnKq.Name = "btnKq";
            btnKq.Size = new Size(116, 41);
            btnKq.TabIndex = 3;
            btnKq.Text = "Kết quả";
            btnKq.UseVisualStyleBackColor = true;
            btnKq.Click += btnKq_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(261, 381);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(338, 31);
            textBox2.TabIndex = 4;
            // 
            // txtHoTen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(btnKq);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "txtHoTen";
            Text = "Form1";
            Load += txtHoTen_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private Button btnThoat;
        private Button btnXoa;
        private RadioButton rdoChuhoa;
        private RadioButton rdoChuthuong;
        private Button btnKq;
        private TextBox textBox2;
    }
}
