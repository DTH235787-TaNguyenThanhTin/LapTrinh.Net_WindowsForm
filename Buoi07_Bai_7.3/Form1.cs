using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace buoi07_bai_7._3
{
    public partial class Form1 : Form
    {
        private List<string> dsHinh = new List<string>(); // Danh sách hình ảnh
        private int chiSo = 0;                            // Chỉ số hình hiện tại
        private System.Windows.Forms.Timer timer;          // Hẹn giờ cho slideshow

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 2000; // 2 giây đổi hình
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (dsHinh.Count == 0) return;
            chiSo = (chiSo + 1) % dsHinh.Count;
            pictureBox1.Image = Image.FromFile(dsHinh[chiSo]);
        }

        private void btnMoDanhSach_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog
            {
                Title = "Chọn các hình ảnh",
                Filter = "File hình|*.jpg;*.jpeg;*.png;*.bmp;*.gif",
                Multiselect = true
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                dsHinh.Clear();
                dsHinh.AddRange(dlg.FileNames);
                chiSo = 0;
                if (dsHinh.Count > 0)
                    pictureBox1.Image = Image.FromFile(dsHinh[0]);
            }
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            if (dsHinh.Count == 0) return;
            chiSo = (chiSo + 1) % dsHinh.Count;
            pictureBox1.Image = Image.FromFile(dsHinh[chiSo]);
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            if (dsHinh.Count == 0) return;
            chiSo = (chiSo - 1 + dsHinh.Count) % dsHinh.Count;
            pictureBox1.Image = Image.FromFile(dsHinh[chiSo]);
        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                timer.Stop();
                btnBatDau.Text = "Bắt đầu";
            }
            else
            {
                if (dsHinh.Count > 0)
                {
                    timer.Start();
                    btnBatDau.Text = "Dừng";
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
