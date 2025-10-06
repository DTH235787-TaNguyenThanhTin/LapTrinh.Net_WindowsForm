namespace Buoi02_Bai_3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThongBao_Click(object sender, EventArgs e)
        {
            int thang;
            if (int.TryParse(txtMua.Text, out thang))
            {
                if (thang > 0 && thang <= 3)
                {
                    MessageBox.Show("XUAN");
                }
                else if (thang >= 4 && thang <= 6)
                {
                    MessageBox.Show("HA ");
                }
                else if (thang >= 7 && thang <= 9)
                {
                    MessageBox.Show("THU");
                }
                else if (thang >= 10 && thang <= 12)
                {
                    MessageBox.Show("DONG");
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập tháng hợp lệ (1-12)");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên cho tháng.");
            }
        }
    }
}
