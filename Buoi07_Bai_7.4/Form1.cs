using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace buoi07_bai_7._4
{
    public partial class Form1 : Form
    {
        const int SoGhe = 30;
        const int GiaVe = 100000;
        List<Label> danhSachGhe = new List<Label>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TaoSoDoGhe();
        }

        private void TaoSoDoGhe()
        {
            int x = 30, y = 60;
            int dem = 0;

            for (int i = 1; i <= SoGhe; i++)
            {
                Label ghe = new Label();
                ghe.Text = i.ToString();
                ghe.Size = new Size(40, 40);
                ghe.Location = new Point(x, y);
                ghe.BackColor = Color.White;
                ghe.TextAlign = ContentAlignment.MiddleCenter;
                ghe.BorderStyle = BorderStyle.FixedSingle;
                ghe.Font = new Font("Arial", 9, FontStyle.Bold);
                ghe.ForeColor = Color.Red;
                ghe.Click += Ghe_Click;

                danhSachGhe.Add(ghe);
                this.Controls.Add(ghe);

                x += 50;
                dem++;

                if (dem == 9)
                {
                    dem = 0;
                    x = 30;
                    y += 50;
                }
            }

            lblThanhTien.Text = "0 VND";
        }

        private void Ghe_Click(object sender, EventArgs e)
        {
            Label ghe = sender as Label;

            if (ghe.BackColor == Color.Yellow)
            {
                MessageBox.Show("Ghế này đã bán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (ghe.BackColor == Color.White)
            {
                ghe.BackColor = Color.Blue;
            }
            else if (ghe.BackColor == Color.Blue)
            {
                ghe.BackColor = Color.White;
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            int dem = 0;
            foreach (Label ghe in danhSachGhe)
            {
                if (ghe.BackColor == Color.Blue)
                {
                    ghe.BackColor = Color.Yellow;
                    dem++;
                }
            }
            int thanhTien = dem * GiaVe;
            lblThanhTien.Text = $"{thanhTien:N0} VND";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            foreach (Label ghe in danhSachGhe)
            {
                if (ghe.BackColor == Color.Blue)
                    ghe.BackColor = Color.White;
            }
            lblThanhTien.Text = "0 VND";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
