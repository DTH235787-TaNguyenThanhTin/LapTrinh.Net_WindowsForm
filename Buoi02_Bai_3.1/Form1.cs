namespace Buoi02_Bai_3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(txtX.Text, out float x))
            {
                MessageBox.Show("Vui lòng nhập một số thực hợp lệ cho x.");
                return;
            }

            float result;

            if (x >= 2)
            {
                result = -8 * x * x * x - 12 * x - 1;
            }
            else if (x > 1)
            {
                result = x * x - 6 * x - 19;
            }
            else // x <= 1
            {
                result = 7 * x;
            }

            txtF.Text = result.ToString();
        }
    }
}
