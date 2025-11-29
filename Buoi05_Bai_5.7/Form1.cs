using System;
using System.Windows.Forms;

namespace Buoi05_Bai_5._7
{
    public partial class Form1 : Form
    {
        int[] a = new int[100];
        int n = 0;
        bool flag = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Nhap()
        {
            string str = txtNhap.Text.Trim();
            if (string.IsNullOrEmpty(str))
            {
                MessageBox.Show("Vui lòng nhập mảng số nguyên!");
                return;
            }

            string[] ptu = str.Split(new char[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
            n = ptu.Length;
            for (int i = 0; i < n; i++)
                a[i] = int.Parse(ptu[i]);
        }

        private void Xuat()
        {
            txtKQ.Clear();
            for (int i = 0; i < n; i++)
                txtKQ.AppendText(a[i] + " ");
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            if (!flag)
            {
                Nhap();
                flag = true;
            }
            Xuat();
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtNhap.Clear();
            txtKQ.Clear();
            txtMax.Clear();
            txtMin.Clear();
            txtTongChan.Clear();
            txtTongLe.Clear();
            txtTongMang.Clear();
            txtViTri.Clear();
            txtSoThay.Clear();
            rdoTang.Checked = false;
            rdoGiam.Checked = false;
            flag = false;
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            if (!flag) { Nhap(); flag = true; }

            int tong = 0, tongChan = 0, tongLe = 0;
            for (int i = 0; i < n; i++)
            {
                tong += a[i];
                if (a[i] % 2 == 0) tongChan += a[i];
                else tongLe += a[i];
            }

            txtTongMang.Text = tong.ToString();
            txtTongChan.Text = tongChan.ToString();
            txtTongLe.Text = tongLe.ToString();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (!flag) { Nhap(); flag = true; }

            int max = a[0], min = a[0];
            for (int i = 1; i < n; i++)
            {
                if (a[i] > max) max = a[i];
                if (a[i] < min) min = a[i];
            }

            txtMax.Text = max.ToString();
            txtMin.Text = min.ToString();
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            if (!flag) { Nhap(); flag = true; }

            if (rdoTang.Checked)
            {
                for (int i = 0; i < n - 1; i++)
                    for (int j = i + 1; j < n; j++)
                        if (a[i] > a[j]) (a[i], a[j]) = (a[j], a[i]);
            }
            else if (rdoGiam.Checked)
            {
                for (int i = 0; i < n - 1; i++)
                    for (int j = i + 1; j < n; j++)
                        if (a[i] < a[j]) (a[i], a[j]) = (a[j], a[i]);
            }
            else
            {
                MessageBox.Show("Chọn kiểu sắp xếp!");
                return;
            }

            Xuat();
        }

        private void btnThayThe_Click(object sender, EventArgs e)
        {
            if (!flag) { Nhap(); flag = true; }

            try
            {
                int vt = int.Parse(txtViTri.Text);
                int x = int.Parse(txtSoThay.Text);
                if (vt < 1 || vt > n)
                {
                    MessageBox.Show("Vị trí không hợp lệ!");
                    return;
                }

                a[vt - 1] = x;
                Xuat();
            }
            catch
            {
                MessageBox.Show("Nhập đúng vị trí và số thay!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
