using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Windows.Forms;

namespace Buoi05_Bai_5._6
{
    public partial class Form1 : Form
    {
        int[] arr;

        public Form1()
        {
            InitializeComponent();
        }

        // 🔹 Tạo mảng ngẫu nhiên
        private void btnNhapMang_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rd.Next(1, 100);

            txtMang.Text = string.Join(", ", arr);
            txtKetQua.Clear();
        }

        // 🔹 Xuất mảng
        private void btnXuatMang_Click(object sender, EventArgs e)
        {
            if (arr == null)
            {
                MessageBox.Show("Vui lòng tạo mảng trước!");
                return;
            }

            txtKetQua.Text = "Mảng: " + string.Join(", ", arr);
        }

        // 🔹 Kiểm tra số nguyên tố
        bool LaSoNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0)
                    return false;
            return true;
        }

        // 🔹 Thực hiện xử lý theo RadioButton
        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if (arr == null)
            {
                MessageBox.Show("Vui lòng nhập mảng trước!");
                return;
            }

            if (rdoMin.Checked)
            {
                txtKetQua.Text = $"Giá trị nhỏ nhất: {arr.Min()}";
            }
            else if (rdoChan.Checked)
            {
                var chan = arr.Where(x => x % 2 == 0).ToArray();
                txtKetQua.Text = "Các giá trị chẵn: " + string.Join(", ", chan);
            }
            else if (rdoChanCuoi.Checked)
            {
                int chanCuoi = arr.LastOrDefault(x => x % 2 == 0);
                txtKetQua.Text = chanCuoi != 0 ? $"Số chẵn cuối cùng: {chanCuoi}" : "Không có số chẵn nào";
            }
            else if (rdoTongLe.Checked)
            {
                txtKetQua.Text = $"Tổng các giá trị lẻ: {arr.Where(x => x % 2 != 0).Sum()}";
            }
            else if (rdoTongChan.Checked)
            {
                txtKetQua.Text = $"Tổng các giá trị chẵn: {arr.Where(x => x % 2 == 0).Sum()}";
            }
            else if (rdoDemChan.Checked)
            {
                txtKetQua.Text = $"Số lượng giá trị chẵn: {arr.Count(x => x % 2 == 0)}";
            }
            else if (rdoDemLe.Checked)
            {
                txtKetQua.Text = $"Số lượng giá trị lẻ: {arr.Count(x => x % 2 != 0)}";
            }
            else if (rdoNguyenTo.Checked)
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox("Nhập số nguyên n:", "Kiểm tra số nguyên tố");
                if (int.TryParse(input, out int n))
                {
                    string kq = LaSoNguyenTo(n)
                        ? $"{n} là số nguyên tố."
                        : $"{n} không phải là số nguyên tố.";
                    List<int> ds = new List<int>();
                    for (int i = 2; i < n; i++)
                        if (LaSoNguyenTo(i)) ds.Add(i);
                    txtKetQua.Text = $"{kq}\r\nCác số nguyên tố nhỏ hơn {n}: {string.Join(", ", ds)}";
                }
                else
                {
                    txtKetQua.Text = "Giá trị nhập không hợp lệ!";
                }
            }
        }

        // 🔹 Làm lại
        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtMang.Clear();
            txtKetQua.Clear();
            arr = null;
            foreach (var rdo in groupBoxChucNang.Controls.OfType<RadioButton>())
                rdo.Checked = false;
        }

        // 🔹 Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
