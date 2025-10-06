using System;

namespace Buoi3_bai9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnHien_Click(object sender, EventArgs e)
        {
            string hoten = txtTen.Text;
            string gioitinh = rdNam.Checked ? "Nam" : "Nữ";
            string ngaysinh = Time.Text; // nếu bạn dùng DateTimePicker
            string diachi = txtDiachi.Text;
            string dienthoai = txtDienthoai.Text;
            string email = txtEmail.Text;
            string tinhtrang = chkHoc.Checked ? "Đang đi học" : "Đang đi làm";

            string thongtin = "Ho ten: " + hoten + Environment.NewLine;
            thongtin += "Gioi tinh: " + gioitinh + Environment.NewLine;
            thongtin += "Ngay sinh: " + ngaysinh + Environment.NewLine;
            thongtin += "Dia chi: " + diachi + Environment.NewLine;
            thongtin += "Dien thoai: " + dienthoai + Environment.NewLine;
            thongtin += "Email: " + email + Environment.NewLine;
            thongtin += "Tinh trang: " + tinhtrang;

            MessageBox.Show(thongtin, "Thong tin ca nhan");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
    

