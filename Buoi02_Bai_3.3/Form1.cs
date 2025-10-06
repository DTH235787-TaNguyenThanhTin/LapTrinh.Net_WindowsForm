namespace Buoi02_Bai_3._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtMonth_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKiem_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtDay.Text, out int ngay) ||
                !int.TryParse(txtMonth.Text, out int thang) ||
                !int.TryParse(txtYear.Text, out int nam))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ cho ngày, tháng, năm.");
                return;
            }

            bool hopLe = false;
            try
            {
                DateTime dt = new DateTime(nam, thang, ngay);
                hopLe = true;
            }
            catch
            {
                hopLe = false;
            }

            if (hopLe)
                MessageBox.Show("Ngày tháng năm hợp lệ.");
            else
                MessageBox.Show("Ngày tháng năm không hợp lệ.");
        }
    }
}

