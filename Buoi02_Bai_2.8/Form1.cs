namespace Buoi02_Bai_2._8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            double tong = a + b;
            txtKq.Text = tong.ToString();
        }

        private void btnHieu_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            double hieu = a - b;
            txtKq.Text = hieu.ToString();
        }

        private void btnTich_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            double tich = a * b;
            txtKq.Text = tich.ToString();
        }

        private void btnThuong_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text); 
            double b = double.Parse(txtB.Text);
            if (b != 0)
            {
                double thuong = a / b;
                txtKq.Text = thuong.ToString();
            }
            else
            {
                MessageBox.Show("Không thể chia cho 0!");
            }
        }
    }
}
