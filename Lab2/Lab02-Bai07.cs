using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Lab02_Bai07 : Form
    {
        public Lab02_Bai07()
        {
            InitializeComponent();
            LoadDrives();
        }

        private void LoadDrives()
        {
            tvDirectory.Nodes.Clear();

            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady)
                {
                    TreeNode node = new TreeNode(drive.Name);
                    node.Tag = drive.RootDirectory.FullName; 
                    node.Nodes.Add("..."); 
                    tvDirectory.Nodes.Add(node);
                }
            }
        }

       
        private void tvDirectory_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode currentNode = e.Node;

           
            if (currentNode.Nodes.Count == 1 && currentNode.Nodes[0].Text == "...")
            {
                currentNode.Nodes.Clear();
                string path = currentNode.Tag.ToString();

                try
                {
                    DirectoryInfo dir = new DirectoryInfo(path);

                   
                    foreach (DirectoryInfo subDir in dir.GetDirectories())
                    {
                       
                        if ((subDir.Attributes & FileAttributes.Hidden) != 0 ||
                            (subDir.Attributes & FileAttributes.System) != 0)
                            continue;

                        TreeNode subNode = new TreeNode(subDir.Name);
                        subNode.Tag = subDir.FullName;
                        subNode.Nodes.Add("..."); 
                        currentNode.Nodes.Add(subNode);
                    }

                    
                    foreach (FileInfo file in dir.GetFiles())
                    {
                        if ((file.Attributes & FileAttributes.Hidden) != 0) continue;

                        TreeNode fileNode = new TreeNode(file.Name);
                        fileNode.Tag = file.FullName;
                        currentNode.Nodes.Add(fileNode);
                    }
                }
                catch (UnauthorizedAccessException)
                {
                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể đọc thư mục: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

       
        private void tvDirectory_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node == null || e.Node.Tag == null) return;

            string filePath = e.Node.Tag.ToString();

           
            if (File.Exists(filePath))
            {
                HienThiNoiDungFile(filePath);
            }
        }

       
        private void HienThiNoiDungFile(string filePath)
        {
            string ext = Path.GetExtension(filePath).ToLower();

            try
            {
                
                if (ext == ".jpg" || ext == ".png" || ext == ".bmp" || ext == ".gif" || ext == ".jpeg")
                {
                    rtbPreview.Visible = false;
                    picPreview.Visible = true;

                   
                    if (picPreview.Image != null)
                    {
                        picPreview.Image.Dispose();
                        picPreview.Image = null;
                    }

                   
                    using (FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                    {
                        picPreview.Image = Image.FromStream(stream);
                    }
                }
                
                else if (ext == ".txt" || ext == ".cs" || ext == ".json" || ext == ".xml" || ext == ".log" || ext == ".md")
                {
                    picPreview.Visible = false;
                    rtbPreview.Visible = true;
                    rtbPreview.Text = File.ReadAllText(filePath);
                }
                else
                {
                    picPreview.Visible = false;
                    rtbPreview.Visible = true;
                    rtbPreview.Text = $"[Định dạng file '{ext}' chưa hỗ trợ xem trước nội dung trực tiếp]";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc file: " + ex.Message, "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
