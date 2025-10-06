namespace Buoi04_Bai_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // khai bao bien
        int[] a;
        int n;
        private string chuoi;

        // phuong thuc tao mang
        public void TaoMang(int n)
        {
            a = new int[n];
            int num1;
            // TaoMang mang random
            Random rd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                num1 = rd.Next(0, 100);
                a[i] = num1;
            }
        }

        public void Inmang(int n)
        {
            String chuoi = "";
            for (int i = 0; i < a.Length; i++)
                chuoi += a[i] + " ";
            MessageBox.Show("Mảng gồm " + n + " phần tử là: " + chuoi, "Kết quả");

        }
        public void btnTaomang_Click(object sender, EventArgs e)
        {
            if (txtNhap.Text == "")
            {
                MessageBox.Show("Hãy nhập số phần tử mảng", "Thông báo");
                txtNhap.Focus();
            }
            else
            {
                n = Convert.ToInt32(txtNhap.Text);
                if (n < 0)
                {
                    MessageBox.Show("Bạn vừa nhập n = " + n + ". Số phần tử mảng phải > 0", "Thôngbáo");
                    txtNhap.Focus();
                }
                else
                {
                    TaoMang(n);
                    // Fix: Inmang(n) returns void, so call it directly instead of using its return value
                    Inmang(n);
                    btnTongmang.Enabled = true;
                    btnSoLonNhat.Enabled = true;
                }
            }
        }

        private void btnTongmang_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có muốn tiếp tục tính tổng mảng không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Form2 f2 = new Form2(a);
                f2.Show();
                f2.Hide();
            }
            else
            {
                MessageBox.Show("Đã quay lại Form1!");
            }
        }

        private void btnSoLonNhat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có muốn tiếp tục tính tổng mảng không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Form3 f3 = new Form3(a);
                f3.Show();
                f3.Hide();
            }
            else
            {
                MessageBox.Show("Đã quay lại Form1!");
            }
        }
    }
}

