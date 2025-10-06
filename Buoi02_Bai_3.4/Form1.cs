namespace Buoi02_Bai_3._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            double c = double.Parse(txtC.Text);
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                        MessageBox.Show("Phương trình vô số nghiệm.");
                    else
                        MessageBox.Show("Phương trình vô nghiệm.");
                }
                else
                {
                    double x = -c / b;
                    MessageBox.Show($"Phương trình có một nghiệm: x = {x}");
                }
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    MessageBox.Show("Phương trình vô nghiệm.");
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    MessageBox.Show($"Phương trình có nghiệm kép: x1 = x2 = {x}");
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    MessageBox.Show($"Phương trình có hai nghiệm phân biệt: x1 = {x1}, x2 = {x2}");
                }
            }
        }
    }
}
