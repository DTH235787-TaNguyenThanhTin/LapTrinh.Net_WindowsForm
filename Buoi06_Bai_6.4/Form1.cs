using System;
using System.Windows.Forms;

namespace Buoi06_Bai_6._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdoNam.Checked = true;
        }

        
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Họ tên không được để trống!", "Thông báo");
                return;
            }

            string ma = txtMaSV.Text;
            string hoten = txtHoTen.Text;
            string ngaysinh = dtpNgaySinh.Value.ToShortDateString();
            string phai = rdoNam.Checked ? "Nam" : "Nữ";
            string dienthoai = txtDienThoai.Text;
            string quequan = cboQueQuan.Text;

            ListViewItem item = new ListViewItem(ma);
            item.SubItems.Add(hoten);
            item.SubItems.Add(ngaysinh);
            item.SubItems.Add(phai);
            item.SubItems.Add(dienthoai);
            item.SubItems.Add(quequan);

            lvSinhVien.Items.Add(item);
            ClearFields();
        }

      
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Chọn 1 dòng để xóa!", "Thông báo");
                return;
            }
            lvSinhVien.Items.Remove(lvSinhVien.SelectedItems[0]);
        }

       
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Chọn 1 dòng để sửa!", "Thông báo");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Họ tên không được để trống!", "Thông báo");
                return;
            }

            ListViewItem item = lvSinhVien.SelectedItems[0];
            item.SubItems[0].Text = txtMaSV.Text;
            item.SubItems[1].Text = txtHoTen.Text;
            item.SubItems[2].Text = dtpNgaySinh.Value.ToShortDateString();
            item.SubItems[3].Text = rdoNam.Checked ? "Nam" : "Nữ";
            item.SubItems[4].Text = txtDienThoai.Text;
            item.SubItems[5].Text = cboQueQuan.Text;
        }

       
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
                this.Close();
        }

        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count == 0) return;
            ListViewItem item = lvSinhVien.SelectedItems[0];
            txtMaSV.Text = item.SubItems[0].Text;
            txtHoTen.Text = item.SubItems[1].Text;
            dtpNgaySinh.Text = item.SubItems[2].Text;
            if (item.SubItems[3].Text == "Nam") rdoNam.Checked = true;
            else rdoNu.Checked = true;
            txtDienThoai.Text = item.SubItems[4].Text;
            cboQueQuan.Text = item.SubItems[5].Text;
        }

        private void ClearFields()
        {
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtDienThoai.Clear();
            cboQueQuan.SelectedIndex = -1;
            txtMaSV.Focus();
        }
    }
}
