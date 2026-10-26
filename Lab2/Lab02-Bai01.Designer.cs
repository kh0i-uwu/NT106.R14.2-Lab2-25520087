namespace Lab2
{
    partial class Lab02_Bai01
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
            btnDoc = new Button();
            btnGhi = new Button();
            rtbContent = new RichTextBox();
            SuspendLayout();
            // 
            // btnDoc
            // 
            btnDoc.BackColor = SystemColors.ActiveBorder;
            btnDoc.Location = new Point(171, 112);
            btnDoc.Name = "btnDoc";
            btnDoc.Size = new Size(280, 106);
            btnDoc.TabIndex = 0;
            btnDoc.Text = "Đọc File";
            btnDoc.UseVisualStyleBackColor = false;
            btnDoc.Click += btnDoc_Click;
            // 
            // btnGhi
            // 
            btnGhi.BackColor = SystemColors.ActiveBorder;
            btnGhi.Location = new Point(171, 368);
            btnGhi.Name = "btnGhi";
            btnGhi.Size = new Size(280, 106);
            btnGhi.TabIndex = 1;
            btnGhi.Text = "Ghi FIle";
            btnGhi.UseVisualStyleBackColor = false;
            btnGhi.Click += btnGhi_Click;
            // 
            // rtbContent
            // 
            rtbContent.Location = new Point(519, 28);
            rtbContent.Name = "rtbContent";
            rtbContent.Size = new Size(1258, 700);
            rtbContent.TabIndex = 2;
            rtbContent.Text = "";
            // 
            // Lab02_Bai01
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1820, 758);
            Controls.Add(rtbContent);
            Controls.Add(btnGhi);
            Controls.Add(btnDoc);
            Name = "Lab02_Bai01";
            Text = "Lab02_Bai01";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDoc;
        private Button btnGhi;
        private RichTextBox rtbContent;
    }
}