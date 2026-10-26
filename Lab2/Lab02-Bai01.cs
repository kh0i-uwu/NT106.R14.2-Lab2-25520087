using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Lab02_Bai01 : Form
    {
        public Lab02_Bai01()
        {
            InitializeComponent();
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            rtbContent.Text = sr.ReadToEnd();
            fs.Close();
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();
            FileStream fs = new FileStream(sfd.FileName, FileMode.Create);
            StreamWriter sr = new StreamWriter(fs);
            string content = rtbContent.Text.ToUpper();
            sr.Write(content);

            sr.Close();
        }
    }
}
