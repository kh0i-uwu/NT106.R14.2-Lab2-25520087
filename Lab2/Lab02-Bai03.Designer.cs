namespace Lab2
{
    partial class Lab02_Bai03
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
            rtbContent = new RichTextBox();
            btnDoc = new Button();
            btnGhi = new Button();
            SuspendLayout();
            // 
            // rtbContent
            // 
            rtbContent.Location = new Point(708, 12);
            rtbContent.Name = "rtbContent";
            rtbContent.Size = new Size(1144, 850);
            rtbContent.TabIndex = 0;
            rtbContent.Text = "";
            // 
            // btnDoc
            // 
            btnDoc.Location = new Point(148, 192);
            btnDoc.Name = "btnDoc";
            btnDoc.Size = new Size(416, 104);
            btnDoc.TabIndex = 1;
            btnDoc.Text = "Đọc File";
            btnDoc.UseVisualStyleBackColor = true;
            btnDoc.Click += btnDoc_Click;
            // 
            // btnGhi
            // 
            btnGhi.Location = new Point(148, 451);
            btnGhi.Name = "btnGhi";
            btnGhi.Size = new Size(416, 104);
            btnGhi.TabIndex = 2;
            btnGhi.Text = "Ghi File";
            btnGhi.UseVisualStyleBackColor = true;
            btnGhi.Click += btnGhi_Click;
            // 
            // Lab02_Bai03
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1882, 886);
            Controls.Add(btnGhi);
            Controls.Add(btnDoc);
            Controls.Add(rtbContent);
            Name = "Lab02_Bai03";
            Text = "Lab02_Bai03";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtbContent;
        private Button btnDoc;
        private Button btnGhi;
    }
}