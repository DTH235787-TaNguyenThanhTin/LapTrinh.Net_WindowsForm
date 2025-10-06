namespace Buoi02_Bai_2._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHien_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chao " + txtTen.Text);
        }
    }
}
