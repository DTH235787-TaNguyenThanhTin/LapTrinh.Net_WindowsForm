using System;
using System.Linq;
using System.Windows.Forms;

namespace Buoi05_Bai_5._5
{
    public partial class Form1 : Form
    {
        int[] arr;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnXuatMang_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rd.Next(1, 100);
            txtNhap.Text = string.Join(", ", arr);
            txtKetQua.Clear();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            if (arr == null) return;
            int min = arr.Min();
            txtKetQua.Text = $"Phần tử nhỏ nhất: {min}";
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            if (arr == null) return;
            int tong = arr.Sum();
            txtKetQua.Text = $"Tổng giá trị mảng: {tong}";
        }

        private void btnTang2_Click(object sender, EventArgs e)
        {
            if (arr == null) return;
            arr = arr.Select(x => x + 2).ToArray();
            txtNhap.Text = string.Join(", ", arr);
            txtKetQua.Text = "Đã tăng mỗi phần tử lên 2.";
        }

        private void btnDemLe_Click(object sender, EventArgs e)
        {
            if (arr == null) return;
            int dem = arr.Count(x => x % 2 != 0);
            txtKetQua.Text = $"Số phần tử lẻ: {dem}";
        }

        private void btnSapTang_Click(object sender, EventArgs e)
        {
            if (arr == null) return;
            Array.Sort(arr);
            txtNhap.Text = string.Join(", ", arr);
            txtKetQua.Text = "Mảng đã sắp tăng dần.";
        }

        private void btnTongLe_Click(object sender, EventArgs e)
        {
            if (arr == null) return;
            int tongLe = arr.Where(x => x % 2 != 0).Sum();
            txtKetQua.Text = $"Tổng phần tử lẻ: {tongLe}";
        }

        private void btnSapGiam_Click(object sender, EventArgs e)
        {
            if (arr == null) return;
            arr = arr.OrderByDescending(x => x).ToArray();
            txtNhap.Text = string.Join(", ", arr);
            txtKetQua.Text = "Mảng đã sắp giảm dần.";
        }
    }
}
