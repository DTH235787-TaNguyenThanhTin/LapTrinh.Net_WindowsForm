namespace Buoi3_bai8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHien_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xin chào " +this.cboTen.SelectedItem.ToString()+"Chúc một ngày vui vẻ");
        }
    }
}
