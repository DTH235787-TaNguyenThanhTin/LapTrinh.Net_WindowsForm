using System;
using System.Windows.Forms;

namespace Buoi06_Bai_6._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Khi Form Load
        private void Form1_Load(object sender, EventArgs e)
        {
            lstKetQua.View = View.Details;
            lstKetQua.FullRowSelect = true;
            lstKetQua.GridLines = true;

            lstKetQua.Columns.Add("Mã SV", 80);
            lstKetQua.Columns.Add("Họ Tên SV", 130);
            lstKetQua.Columns.Add("Địa Chỉ", 150);
            lstKetQua.Columns.Add("Ngày Sinh", 100);
            lstKetQua.Columns.Add("Lớp", 70);
        }

        // Thêm mới
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (txtMS.Text == "" || txtHoTen.Text == "" || txtDiaChi.Text == "" || lstLop.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string ma = txtMS.Text;
            string hoten = txtHoTen.Text;
            string diachi = txtDiaChi.Text;
            string ngaysinh = dtpTG.Value.ToShortDateString();
            string lop = lstLop.SelectedItem.ToString();

            ListViewItem item = new ListViewItem(ma);
            item.SubItems.Add(hoten);
            item.SubItems.Add(diachi);
            item.SubItems.Add(ngaysinh);
            item.SubItems.Add(lop);

            lstKetQua.Items.Add(item);

            txtMS.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            lstLop.ClearSelected();
            txtMS.Focus();
        }

        // Xóa
        private void btnXoaItem_Click(object sender, EventArgs e)
        {
            if (lstKetQua.SelectedItems.Count > 0)
            {
                lstKetQua.Items.Remove(lstKetQua.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Chọn sinh viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                this.Close();
        }
    }
}
