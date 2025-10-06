namespace Buoi3_bai7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtKq_TextChanged(object sender, EventArgs e)
        {

        }

        private void tongToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            int kq = a + b;
            this.txtKq.Text = kq.ToString();
        }

        private void hieuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            int kq = a - b;
            this.txtKq.Text = kq.ToString();
        }

        private void tichToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            int kq = a * b;
            this.txtKq.Text = kq.ToString();
        }

        private void thuongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            int kq = (int)(a / (float)b);
            this.txtKq.Text = kq.ToString();
        }
    }
}

