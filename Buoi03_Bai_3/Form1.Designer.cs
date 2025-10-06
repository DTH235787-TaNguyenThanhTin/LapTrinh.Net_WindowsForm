namespace Buoi3_bai3
{
    partial class lstWeb
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
            listBox1 = new ListBox();
            btnOk = new Button();
            btnReset = new Button();
            txtKq = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Items.AddRange(new object[] { "Tuổi trẻ", "Thanh niên", "VNExpress", "Dân trí", "Công an" });
            listBox1.Location = new Point(46, 73);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(253, 179);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(46, 289);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(137, 51);
            btnOk.TabIndex = 1;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(224, 289);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(137, 51);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // txtKq
            // 
            txtKq.FormattingEnabled = true;
            txtKq.ItemHeight = 25;
            txtKq.Location = new Point(411, 73);
            txtKq.Name = "txtKq";
            txtKq.Size = new Size(253, 179);
            txtKq.TabIndex = 3;
            txtKq.SelectedIndexChanged += txtKq_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 26);
            label1.Name = "label1";
            label1.Size = new Size(142, 25);
            label1.TabIndex = 4;
            label1.Text = "Lien ket website ";
            // 
            // lstWeb
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtKq);
            Controls.Add(btnReset);
            Controls.Add(btnOk);
            Controls.Add(listBox1);
            Name = "lstWeb";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button btnOk;
        private Button btnReset;
        private ListBox txtKq;
        private Label label1;
    }
}
