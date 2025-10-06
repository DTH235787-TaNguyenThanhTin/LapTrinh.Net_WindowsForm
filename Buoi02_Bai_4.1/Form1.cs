namespace Buoi02_Bai_4._1
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
                for (int i = 0; i <= n; i++)
                {
                    S += i;
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
