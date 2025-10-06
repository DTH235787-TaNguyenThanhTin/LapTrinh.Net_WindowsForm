namespace Buoi02_Bai_4._7
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
                for (int i = 1; i <= n; i++)
                {
                    S *= i;
                }
                txtS.Text = S.ToString(); 
            }
            else
            {
                MessageBox.Show("Please enter a valid odd integer n ≥ 1.");
            }
        }
    }
}
