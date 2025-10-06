namespace Buoi04_Bai_1
{

    public partial class form1 : Form
    {
        int n;

        public form1()
        {
            InitializeComponent();
        }

        private void form1_Load(object sender, EventArgs e)
        {
            this.n = 10; // hoặc lấy từ một TextBox nhập số lượng phần tử
        }
        // Khai báo biến 
        int[] a = new int[10];
        int sopt = 0;

        public string InMang()
        {
            String chuoi = "";
            for (int i = 0; i < sopt; i++)

                chuoi += a[i] + " ";
            return chuoi;
        }
        // phuong thuc tim max
        public int TimMax()
        {
            int max = a[0];
            for (int i = 1; i < sopt; i++)
                if (a[i] > max)
                    max = a[i];
            return max;
        }
        private void btnMax_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
                lblKQ.Text = "Phần tử lớn nhất trong mảng là: " + TimMax().ToString();
        }

        // phuong thuc tim min
        public int TimMin()
        {
            int min = a[0];
            for (int i = 1; i < sopt; i++)
                if (a[i] < min)
                    min = a[i];
            return min;
        }
        private void btnMin_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
                lblKQ.Text = "Phần tử nhỏ nhất trong mảng là: " + TimMin().ToString();
        }
        // phuong thuc tinh TB
        public double TinhTB()
        {
            int sum = 0;
            double tb;
            for (int i = 0; i < sopt; i++)
                sum += a[i];
            tb = (double)sum / (double)sopt;
            return tb;
        }
        // tinh trung binh
        private void btnTBMang_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
                lblKQ.Text = "Trung bình cộng các phần tử trong mảng là: " + TinhTB().ToString();
        }
        //phuong thuc sap xep tang
        public void SapXepTang()
        {
            Array.Sort(a, 0, sopt);
        }

        // sắp xếp mảng tăng dần
        private void btnSXTang_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
            {
                SapXepTang();
                this.lblKQ.Text = "Đã sắp xếp mảng tăng dần";

            }
        }
        //phuong thuc sap xep giam
        public void SapXepGiam()
        {
            Array.Sort(a, 0, sopt);
            Array.Reverse(a, 0, sopt);
        }

        // sắp xếp mảng giảm dần
        private void btnSXGiam_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
            {
                SapXepGiam();
                this.lblKQ.Text = "Đã sắp xếp mảng giảm dần";
            }
        }

        //phuong thuc tim UCLN cua 2 so
        public int timUCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (a != b)
            {
                if (a > b) a = a - b;
                else b = b - a;
            }
            return a;
        }
        //Uoc chung lon nhat
        private void btnUCLN_Click(object sender, EventArgs e)
        {
            lblKQ.Text = "Ước chung lớn nhất 2 phần tử đầu " + a[0] + " và " + a[1] + " là " + timUCLN(a[0], a[1]).ToString();
        }

        //phuong thuc kiem tra so nguyen to
        public Boolean kiemTraSNT(int so)
        {
            if (so <= 0)
                return false;
            else
            {
                for (int i = 2; i <= so / 2; i++)
                {
                    if (so % i == 0)
                        return false;
                }
            }
            return true;
        }
        //phuong thuc dem SNT
        public int demSNT()
        {
            int dem = 0;
            for (int i = 0; i < sopt; i++)
            {
                if (kiemTraSNT(a[i]))
                    dem++;
            }
            return dem;
        }
        //phuong thuc in SNT
        public String inSNT()
        {
            String chuoi = "";
            for (int i = 0; i < sopt; i++)
            {
                if (kiemTraSNT(a[i]))
                    chuoi += a[i] + " ";
            }
            return chuoi;
        }
        //Hien SoNT
        private void btnSoNguyenTo_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
                lblKQ.Text = "Mảng có " + demSNT().ToString() + " số nguyên tố là " + inSNT();

        }
        // dem so chan
        private void btnDemSoChan_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
            {
                int dem = 0;
                String chuoi = "";
                for (int i = 0; i < sopt; i++)
                {
                    if (a[i] % 2 == 0)
                        chuoi += a[i];
                        dem++;
                }
                lblKQ.Text = "Mảng có " + dem.ToString() + " số chẵn là "+chuoi;
            }
        }
        // đếm số lẻ
        private void btnDemSoLe_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
            {
                String chuoi = "";

                int dem = 0;
                for (int i = 0; i < sopt; i++)
                {
                    if (a[i] % 2 != 0)
                        chuoi += a[i];
                        dem++;
                }
                lblKQ.Text = "Mảng có " + dem.ToString() + " số lẻ là "+chuoi;
            }
        }

        // số hoàn hảo
        private void btnSHH_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
            {
                String chuoi = "";
                int dem = 0;
                for (int i = 0; i < sopt; i++)
                {
                    int sum = 0;
                    for (int j = 1; j <= a[i] / 2; j++)
                    {
                        if (a[i] % j == 0)
                            sum += j;
                    }
                    if (sum == a[i])
                    {
                        chuoi += a[i] + " ";
                        dem++;
                    }
                }
                if (dem == 0)
                    lblKQ.Text = "Mảng không có số hoàn hảo";
                else
                    lblKQ.Text = "Mảng có " + dem.ToString() + " số hoàn hảo là: " + chuoi;
            }
        }
        // tinh tong mang
        private void btnSum_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
            {
                int sum = 0;
                for (int i = 0; i < sopt; i++)
                    sum += a[i];
                lblKQ.Text = "Tổng các phần tử trong mảng là: " + sum.ToString();
            }
        }
        // Nhap Mang
        private void btnNhap_Click(object sender, EventArgs e)

        {
            if (this.sopt == this.n)
            {
                this.txtNhap.Text = "";
                MessageBox.Show("Mảng đầy", "Thông báo");
            }
            else
            {
                if (this.txtNhap.Text == "")
                    MessageBox.Show("Hãy nhập phần tử nảng", "Thông báo");
                else
                {
                    a[sopt] = int.Parse(this.txtNhap.Text);
                    sopt++;
                    this.lblKQ.Text += this.txtNhap.Text + " ";
                    this.txtNhap.Clear();
                    this.txtNhap.Focus();
                    if (sopt > 0)
                        this.btnIn.Enabled = true;
                }
            }
        }

        //xuat cac phan tu co trong mnag
        private void btnIn_Click(object sender, EventArgs e)
        {

            if (sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
                lblKQ.Text = "Các phần tử trong mảng là: \n\r" + InMang();
        }

        // thoat
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // xoa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
            {
                sopt--;
                lblKQ.Text = "Đã xóa phần tử cuối mảng";
            }
        }

        
    }
}

