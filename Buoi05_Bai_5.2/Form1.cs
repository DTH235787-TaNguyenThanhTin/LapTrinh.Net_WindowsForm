using System;
using System.Windows.Forms;

namespace Buoi05_Bai5_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Hàm kiểm tra số hoàn hảo
        private bool LaSoHoanHao(int n)
        {
            if (n <= 1) return false;
            int tong = 0;
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                    tong += i;
            }
            return tong == n;
        }

        // Nút Kiểm tra
        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtN.Text, out int n))
            {
                MessageBox.Show("Vui lòng nhập một số nguyên hợp lệ!", "Lỗi nhập liệu");
                return;
            }

            if (LaSoHoanHao(n))
                MessageBox.Show($"{n} là số hoàn hảo.", "Kết quả");
            else
                MessageBox.Show($"{n} không phải là số hoàn hảo.", "Kết quả");
        }
    }
}
