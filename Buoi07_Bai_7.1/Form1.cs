using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace buoi07_bai_7._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            for (char c = 'A'; c <= 'Z'; c++)
            {
                treeView1.Nodes.Add(c.ToString());
            }

            // Mở rộng tất cả các node
            treeView1.ExpandAll();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten = txtTen.Text.Trim();
            string ho = txtHo.Text.Trim();

            if (string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(ho))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ họ và tên!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

          
            char kyTuDau = char.ToUpper(ten[0]);

           
            TreeNode node = null;
            foreach (TreeNode n in treeView1.Nodes)
            {
                if (n.Text == kyTuDau.ToString())
                {
                    node = n;
                    break;
                }
            }

            if (node != null)
            {
                // Thêm họ tên vào node đó
                node.Nodes.Add($"{ho}, {ten}");
                node.Expand();
            }

            
            txtTen.Clear();
            txtHo.Clear();
            txtTen.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
