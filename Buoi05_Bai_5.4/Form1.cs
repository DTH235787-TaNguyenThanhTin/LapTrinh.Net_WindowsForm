using System;
using System.Windows.Forms;

namespace buoi05_bai_5._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HideAllInputs();
        }

        private void HideAllInputs()
        {
            lblCanhA.Visible = false; txtA.Visible = false;
            lblCanhB.Visible = false; txtB.Visible = false;
            lblCanhC.Visible = false; txtC.Visible = false;
        }

        private void rdoTron_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTron.Checked)
            {
                HideAllInputs();
                lblCanhA.Text = "Bán kính:";
                lblCanhA.Visible = txtA.Visible = true;
            }
        }

        private void rdoVuong_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoVuong.Checked)
            {
                HideAllInputs();
                lblCanhA.Text = "Cạnh:";
                lblCanhA.Visible = txtA.Visible = true;
            }
        }

        private void rdoChuNhat_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoChuNhat.Checked)
            {
                HideAllInputs();
                lblCanhA.Text = "Chiều dài:";
                lblCanhB.Text = "Chiều rộng:";
                lblCanhA.Visible = txtA.Visible = true;
                lblCanhB.Visible = txtB.Visible = true;
            }
        }

        private void rdoTamGiac_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTamGiac.Checked)
            {
                lblCanhA.Text = "Cạnh a:";
                lblCanhB.Text = "Cạnh b:";
                lblCanhC.Text = "Cạnh c:";
                lblCanhA.Visible = txtA.Visible = true;
                lblCanhB.Visible = txtB.Visible = true;
                lblCanhC.Visible = txtC.Visible = true;
            }
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            double a, b, c, cv = 0, dt = 0;
            try
            {
                if (rdoTron.Checked)
                {
                    a = double.Parse(txtA.Text);
                    cv = 2 * Math.PI * a;
                    dt = Math.PI * a * a;
                }
                else if (rdoVuong.Checked)
                {
                    a = double.Parse(txtA.Text);
                    cv = 4 * a;
                    dt = a * a;
                }
                else if (rdoChuNhat.Checked)
                {
                    a = double.Parse(txtA.Text);
                    b = double.Parse(txtB.Text);
                    cv = 2 * (a + b);
                    dt = a * b;
                }
                else if (rdoTamGiac.Checked)
                {
                    a = double.Parse(txtA.Text);
                    b = double.Parse(txtB.Text);
                    c = double.Parse(txtC.Text);
                    cv = a + b + c;
                    double p = cv / 2;
                    dt = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                }

                lblChuVi.Text = "Chu vi: " + cv.ToString("0.##");
                lblDienTich.Text = "Diện tích: " + dt.ToString("0.##");
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đúng số hợp lệ!");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtA.Clear(); txtB.Clear(); txtC.Clear();
            lblChuVi.Text = "Chu vi:";
            lblDienTich.Text = "Diện tích:";
            HideAllInputs();
            rdoTron.Checked = rdoVuong.Checked = rdoChuNhat.Checked = rdoTamGiac.Checked = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
