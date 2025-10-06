namespace Buoi3_bai3
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnOk = new Button();
            btnReset = new Button();
            txtKq = new ListBox();
            cboWeb = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 68);
            label1.Name = "label1";
            label1.Size = new Size(142, 25);
            label1.TabIndex = 14;
            label1.Text = "Lien ket website ";
            // 
            // btnOk
            // 
            btnOk.Location = new Point(91, 222);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(137, 51);
            btnOk.TabIndex = 11;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(251, 222);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(137, 51);
            btnReset.TabIndex = 12;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // txtKq
            // 
            txtKq.FormattingEnabled = true;
            txtKq.ItemHeight = 25;
            txtKq.Location = new Point(456, 115);
            txtKq.Name = "txtKq";
            txtKq.Size = new Size(253, 179);
            txtKq.TabIndex = 13;
            // 
            // cboWeb
            // 
            cboWeb.FormattingEnabled = true;
            cboWeb.Items.AddRange(new object[] { "lien ket website" });
            cboWeb.Location = new Point(91, 115);
            cboWeb.Name = "cboWeb";
            cboWeb.Size = new Size(182, 33);
            cboWeb.TabIndex = 15;
            cboWeb.SelectedIndexChanged += cboWeb_SelectedIndexChanged;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cboWeb);
            Controls.Add(label1);
            Controls.Add(txtKq);
            Controls.Add(btnReset);
            Controls.Add(btnOk);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnOk;
        private Button btnReset;
        private ListBox txtKq;
        private ComboBox cboWeb;
    }
}