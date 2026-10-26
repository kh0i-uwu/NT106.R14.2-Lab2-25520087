using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Lab02_Bai02 : Form
    {
        public Lab02_Bai02()
        {
            InitializeComponent();
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);

            string content = sr.ReadToEnd();
            rtbContent.Text = content;

            txbFileName.Text = ofd.SafeFileName.ToString();
            txbUrl.Text = fs.Name;

            FileInfo fi = new FileInfo(ofd.FileName);
            txbSize.Text = fi.Length.ToString();

            txbCharactercount.Text = content.Length.ToString();

            txbLinecount.Text = content.Split('\n').Length.ToString();

            char[] separetors = new char[] { ' ', '\t', '\n', '\r' };
            int wordCount = content.Split(separetors, StringSplitOptions.RemoveEmptyEntries).Count();
            txbWordcount.Text = wordCount.ToString();

            fs.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
