namespace Buoi3_bai4
{
    public partial class txtHoTen : Form
    {
        public txtHoTen()
        {
            InitializeComponent();
        }

        private void txtHoTen_Load(object sender, EventArgs e)
        {

        }
        private void btnKq_Click(object sender, EventArgs e)
        {
            if (rdoChuhoa.Checked == true)
            {
                textBox2.Text = textBox1.Text.ToUpper();
            }
            else if (rdoChuthuong.Checked == true)
            {
                textBox2.Text = textBox1.Text.ToLower();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn kiểu chữ");
            }
        }

    }
}
