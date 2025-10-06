namespace Buoi02_Bai_2._3
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
            btnHien = new Button();
            SuspendLayout();
            // 
            // btnHien
            // 
            btnHien.Location = new Point(311, 178);
            btnHien.Name = "btnHien";
            btnHien.Size = new Size(130, 55);
            btnHien.TabIndex = 0;
            btnHien.Text = "Hiển thị";
            btnHien.UseVisualStyleBackColor = true;
            btnHien.Click += btnHien_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHien);
            Name = "Form1";
            Text = "Bai 2.3";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnHien;
    }
}
