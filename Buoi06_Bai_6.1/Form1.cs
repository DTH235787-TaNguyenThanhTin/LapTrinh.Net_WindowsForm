using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Buoi06_Bai_6._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận",
                                             MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                Application.Exit();
        }

       
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Lưu file văn bản";
            save.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            save.FileName = "vanban.txt";

            if (save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(save.FileName, txtKetQua.Text);
                    MessageBox.Show("Đã lưu thành công!", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu file: " + ex.Message);
                }
            }
        }

       
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Mở file văn bản";
            open.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (open.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txtKetQua.Text = File.ReadAllText(open.FileName);
                    MessageBox.Show("Đã mở file thành công!", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi mở file: " + ex.Message);
                }
            }
        }

        
        private void btnChonMau_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                txtKetQua.ForeColor = colorDialog.Color;
            }
        }

        
        private void btnDoiFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowColor = false;
            fontDialog.Font = txtKetQua.Font;

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                txtKetQua.Font = fontDialog.Font;
            }
        }
    }
}
