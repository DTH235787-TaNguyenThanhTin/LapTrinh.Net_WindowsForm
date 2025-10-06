namespace Buoi3_bai6
{
    public partial class lstTen : Form
    {
        public lstTen()
        {
            InitializeComponent();
        }

        private void txtChuoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstTen_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string input = txtChuoi.Text.Trim();
            if (!string.IsNullOrEmpty(input))
            {
                lstChuoi.Items.Add(input);
                txtChuoi.Clear();
                txtChuoi.Focus();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstChuoi.SelectedIndex != -1)
            {
                lstChuoi.Items.RemoveAt(lstChuoi.SelectedIndex);
                txtKq.Clear();
            }
        }

        private void lstChuoi_DoubleClick(object sender, EventArgs e)
        {
            if (lstChuoi.SelectedItem != null)
            {
                txtKq.Text = lstChuoi.SelectedItem.ToString();
            }
        }
        private void btnMauchu_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    txtKq.ForeColor = cd.Color; // đổi màu chữ
                }
            }
        }

        private void btnMaunen_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    txtKq.BackColor = cd.Color; // đổi màu nền
                }
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            using (FontDialog fd = new FontDialog())
            {
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    txtKq.Font = fd.Font; // đổi font
                }
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtKq_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
