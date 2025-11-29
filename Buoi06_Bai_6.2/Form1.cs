using System;
using System.Linq;
using System.Windows.Forms;

namespace Buoi06_Bai_6._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten = txtHoTen.Text.Trim();
            if (ten == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên sinh viên!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }

            if (rdLopA.Checked)
                lstA.Items.Add(ten);
            else if (rdLopB.Checked)
                lstB.Items.Add(ten);
            else
                MessageBox.Show("Vui lòng chọn lớp A hoặc lớp B!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtHoTen.Clear();
            txtHoTen.Focus();
        }

        private void btnASangB_Click(object sender, EventArgs e)
        {
            var selected = lstA.SelectedItems.Cast<string>().ToList();
            foreach (var item in selected)
            {
                lstB.Items.Add(item);
            }
            foreach (var item in selected)
            {
                lstA.Items.Remove(item);
            }
        }

       
        private void btnBSangA_Click(object sender, EventArgs e)
        {
            var selected = lstB.SelectedItems.Cast<string>().ToList();
            foreach (var item in selected)
            {
                lstA.Items.Add(item);
            }
            foreach (var item in selected)
            {
                lstB.Items.Remove(item);
            }
        }

        private void btnChuyenHetSangB_Click(object sender, EventArgs e)
        {
            foreach (var item in lstA.Items)
            {
                lstB.Items.Add(item);
            }
            lstA.Items.Clear();
        }

        
        private void btnChuyenHetSangA_Click(object sender, EventArgs e)
        {
            foreach (var item in lstB.Items)
            {
                lstA.Items.Add(item);
            }
            lstB.Items.Clear();
        }

      
        private void btnTong_Click(object sender, EventArgs e)
        {
            int tong = lstA.Items.Count + lstB.Items.Count;
            MessageBox.Show($"Tổng số sinh viên trong 2 lớp là: {tong}", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
