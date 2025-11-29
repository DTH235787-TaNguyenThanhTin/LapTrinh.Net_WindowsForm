using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace buoi07_bai_7._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            TreeNode rootNode = new TreeNode(@"C:\");
            rootNode.Tag = @"C:\";
            treeView1.Nodes.Add(rootNode);
            LoadDirectories(rootNode);
        }

        
        private void LoadDirectories(TreeNode node)
        {
            string path = node.Tag.ToString();
            try
            {
                string[] directories = Directory.GetDirectories(path);
                foreach (string dir in directories)
                {
                    TreeNode subNode = new TreeNode(Path.GetFileName(dir));
                    subNode.Tag = dir;
                    node.Nodes.Add(subNode);
                }
            }
            catch
            {
                
            }
        }

        
        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes.Count > 0 && e.Node.Nodes[0].Tag == null)
            {
                e.Node.Nodes.Clear();
                LoadDirectories(e.Node);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string selectedPath = e.Node.Tag.ToString();
            LoadImages(selectedPath);
        }

       
        private void LoadImages(string folderPath)
        {
            flowLayoutPanel1.Controls.Clear();
            string[] imageExtensions = { ".jpg", ".jpeg", ".png", ".bmp", ".gif" };

            try
            {
                string[] files = Directory.GetFiles(folderPath);
                foreach (string file in files)
                {
                    if (Array.Exists(imageExtensions, ext => file.EndsWith(ext, StringComparison.OrdinalIgnoreCase)))
                    {
                        PictureBox pic = new PictureBox();
                        pic.Image = Image.FromFile(file);
                        pic.SizeMode = PictureBoxSizeMode.StretchImage;
                        pic.Width = 120;
                        pic.Height = 80;
                        pic.Padding = new Padding(5);
                        pic.Tag = file;

                        
                        pic.Click += (s, e) =>
                        {
                            pictureBox1.Image = Image.FromFile((string)((PictureBox)s).Tag);
                            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                        };

                        flowLayoutPanel1.Controls.Add(pic);
                    }
                }
            }
            catch
            {
               
            }
        }
    }
}
