namespace Buoi02_Bai_4._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtN.Text, out int n) && n >= 1)
            {
                double S = 0;
                for (int i = 1; i <= n; i += 2)
                {
                    S += 1.0 / i;
                }
                txtS.Text = S.ToString("F4"); // Shows 4 decimal places
            }
            else
            {
                MessageBox.Show("Please enter a valid odd integer n ≥ 1.");
            }
        }
    }
}
