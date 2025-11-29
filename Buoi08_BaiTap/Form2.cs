using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi08_Bai_Tap
{
    public partial class Form2 : Form
    {
        // Biến public để nhận dữ liệu từ Form1
        public double canha;

        public Form2()
        {
            InitializeComponent();
        }

        // Hàm tính toán
        public double TinhDienTich()
        {
            return canha * canha;
        }

        public double TinhChuVi()
        {
            return canha * 4;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Hiển thị kết quả ngay khi Form load lên
            txtDientich.Text = TinhDienTich().ToString();
            txtChuvi.Text = TinhChuVi().ToString();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}