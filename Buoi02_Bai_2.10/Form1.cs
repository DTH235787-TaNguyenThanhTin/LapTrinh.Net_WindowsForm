namespace Buoi02_Bai_2._10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCV_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            double cv = (a + b) * 2;
            MessageBox.Show("Chu vi hình chữ nhật là: " + cv.ToString());
        }

        private void btnDT_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            double dt = a * b;
            MessageBox.Show("Diện tích hình chữ nhật là: " + dt.ToString());
        }

        private void btnDCheo_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            double dcheo = Math.Sqrt(a * a + b * b);
            MessageBox.Show("Đường chéo hình chữ nhật là: " + dcheo.ToString());
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
