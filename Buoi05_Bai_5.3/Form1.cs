using System;
using System.Windows.Forms;

namespace Buoi05_Bai_5._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int UCLN(int a, int b)
        {
            if (b == 0) return Math.Abs(a);
            return UCLN(b, a % b);
        }

        
        private void RutGon(ref int tu, ref int mau)
        {
            int uc = UCLN(tu, mau);
            tu /= uc;
            mau /= uc;
            if (mau < 0)
            {
                tu = -tu;
                mau = -mau;
            }
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            int ts1 = int.Parse(txtTSA1.Text);
            int ms1 = int.Parse(txtMSA1.Text);
            int ts2 = int.Parse(txtTSA2.Text);
            int ms2 = int.Parse(txtMSA2.Text);

            int tu = ts1 * ms2 + ts2 * ms1;
            int mau = ms1 * ms2;
            RutGon(ref tu, ref mau);

            txtTSKQ.Text = tu.ToString();
            txtMSKQ.Text = mau.ToString();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            int ts1 = int.Parse(txtTSA1.Text);
            int ms1 = int.Parse(txtMSA1.Text);
            int ts2 = int.Parse(txtTSA2.Text);
            int ms2 = int.Parse(txtMSA2.Text);

            int tu = ts1 * ms2 - ts2 * ms1;
            int mau = ms1 * ms2;
            RutGon(ref tu, ref mau);

            txtTSKQ.Text = tu.ToString();
            txtMSKQ.Text = mau.ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            int ts1 = int.Parse(txtTSA1.Text);
            int ms1 = int.Parse(txtMSA1.Text);
            int ts2 = int.Parse(txtTSA2.Text);
            int ms2 = int.Parse(txtMSA2.Text);

            int tu = ts1 * ts2;
            int mau = ms1 * ms2;
            RutGon(ref tu, ref mau);

            txtTSKQ.Text = tu.ToString();
            txtMSKQ.Text = mau.ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            int ts1 = int.Parse(txtTSA1.Text);
            int ms1 = int.Parse(txtMSA1.Text);
            int ts2 = int.Parse(txtTSA2.Text);
            int ms2 = int.Parse(txtMSA2.Text);

            int tu = ts1 * ms2;
            int mau = ms1 * ts2;
            RutGon(ref tu, ref mau);

            txtTSKQ.Text = tu.ToString();
            txtMSKQ.Text = mau.ToString();
        }
    }
}
