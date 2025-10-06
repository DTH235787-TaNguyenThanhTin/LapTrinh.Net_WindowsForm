namespace Buoi02_Bai_4._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtN.Text, out int n))
            {
                int S = 0;
                for (int i = 1; i <= 2 * n; i += 2)
                {
                    S += i * 2;
                }
                txtS.Text = S.ToString();
            }
            else
            {
                MessageBox.Show("Vui long nhap lai n.");
            }
        }
    }
}
