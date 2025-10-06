namespace Buoi3_bai3
{
    public partial class lstWeb : Form
    {
        public lstWeb()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtKq.ClearSelected();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.txtKq.Text = "B?n dã ch?n website ";
            this.txtKq.Text += this.listBox1.SelectedItem.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtKq_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
