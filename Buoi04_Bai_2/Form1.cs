namespace Buoi04_Bai_2
{
    public partial class Form1 : Form
    {
        int[] a;
        int n;
        public Form1()
        {
            InitializeComponent();
        }
        // phuong thuc tao mang
        public void TaoMang(int n)
        {
            // khai bao mang cos n phan tu nhap tu textbox
            a = new int[n];
            // khoi tao gia tri random cho mang
            int num1;
            Random rd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                num1 = rd.Next(-10, 100);
                a[i] = num1;
            }
        }
        private void btnTaomang_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Bạn vừa nhập n = " + n + ". Số phần tử mảng phải > 0", "báo");
                    txtNhap.Focus();
                }
                else
                {
                    TaoMang(n);
                    lblKQ.Text = "Mảng với các phần tử phát sinh ngẫu nhiên vừa tạo xong";
                    btnInmang.Enabled = true;
                }
            }
        }
        // thoat
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // phuong thuc in 
        public string InMang()
        {
            String chuoi = "";
            for (int i = 0; i < a.Length; i++)
                chuoi += a[i] + " ";
            return chuoi;
        }
        private void btnInmang_Click(object sender, EventArgs e)
        {
            lblKQ.Text = "Các phần tử của mảng: " + InMang();
        }
    }
}
