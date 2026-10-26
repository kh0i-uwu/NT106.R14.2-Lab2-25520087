namespace Lab2
{
    partial class Lab02_Bai07
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tvDirectory = new TreeView();
            gbFileContent = new GroupBox();
            rtbPreview = new RichTextBox();
            picPreview = new PictureBox();
            gbFileContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPreview).BeginInit();
            SuspendLayout();
            // 
            // tvDirectory
            // 
            tvDirectory.Dock = DockStyle.Left;
            tvDirectory.Location = new Point(0, 0);
            tvDirectory.Name = "tvDirectory";
            tvDirectory.Size = new Size(304, 750);
            tvDirectory.TabIndex = 0;
            tvDirectory.BeforeExpand += tvDirectory_BeforeExpand;
            tvDirectory.AfterSelect += tvDirectory_AfterSelect;
            // 
            // gbFileContent
            // 
            gbFileContent.Controls.Add(rtbPreview);
            gbFileContent.Controls.Add(picPreview);
            gbFileContent.Dock = DockStyle.Fill;
            gbFileContent.Location = new Point(304, 0);
            gbFileContent.Name = "gbFileContent";
            gbFileContent.Size = new Size(1382, 750);
            gbFileContent.TabIndex = 1;
            gbFileContent.TabStop = false;
            gbFileContent.Text = "File Content";
            // 
            // rtbPreview
            // 
            rtbPreview.Dock = DockStyle.Fill;
            rtbPreview.Location = new Point(3, 35);
            rtbPreview.Name = "rtbPreview";
            rtbPreview.ReadOnly = true;
            rtbPreview.Size = new Size(1376, 712);
            rtbPreview.TabIndex = 1;
            rtbPreview.Text = "";
            // 
            // picPreview
            // 
            picPreview.Dock = DockStyle.Fill;
            picPreview.Location = new Point(3, 35);
            picPreview.Name = "picPreview";
            picPreview.Size = new Size(1376, 712);
            picPreview.SizeMode = PictureBoxSizeMode.Zoom;
            picPreview.TabIndex = 0;
            picPreview.TabStop = false;
            // 
            // Lab02_Bai07
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1686, 750);
            Controls.Add(gbFileContent);
            Controls.Add(tvDirectory);
            Name = "Lab02_Bai07";
            Text = "Lab02_Bai07";
            gbFileContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picPreview).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TreeView tvDirectory;
        private GroupBox gbFileContent;
        private RichTextBox rtbPreview;
        private PictureBox picPreview;
    }
}