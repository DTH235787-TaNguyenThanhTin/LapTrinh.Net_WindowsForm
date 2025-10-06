namespace Buoi3_bai3
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
            txtKq = new ListBox();
            btnReset = new Button();
            btnOk = new Button();
            lstWeb = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 68);
            label1.Name = "label1";
            label1.Size = new Size(142, 25);
            label1.TabIndex = 9;
            label1.Text = "Lien ket website ";
            // 
            // txtKq
            // 
            txtKq.FormattingEnabled = true;
            txtKq.ItemHeight = 25;
            txtKq.Location = new Point(456, 115);
            txtKq.Name = "txtKq";
            txtKq.Size = new Size(253, 179);
            txtKq.TabIndex = 8;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(269, 331);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(137, 51);
            btnReset.TabIndex = 7;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(91, 331);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(137, 51);
            btnOk.TabIndex = 6;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // lstWeb
            // 
            lstWeb.FormattingEnabled = true;
            lstWeb.ItemHeight = 25;
            lstWeb.Items.AddRange(new object[] { "Tuổi trẻ", "Thanh niên", "VNExpress", "Dân trí", "Công an" });
            lstWeb.Location = new Point(91, 115);
            lstWeb.Name = "lstWeb";
            lstWeb.Size = new Size(253, 179);
            lstWeb.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtKq);
            Controls.Add(btnReset);
            Controls.Add(btnOk);
            Controls.Add(lstWeb);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox txtKq;
        private Button btnReset;
        private Button btnOk;
        private ListBox lstWeb;
    }
}
