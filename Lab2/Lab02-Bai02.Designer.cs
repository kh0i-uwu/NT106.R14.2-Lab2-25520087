namespace Lab2
{
    partial class Lab02_Bai02
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
            btnThoat = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txbFileName = new TextBox();
            txbSize = new TextBox();
            txbUrl = new TextBox();
            txbLinecount = new TextBox();
            txbWordcount = new TextBox();
            txbCharactercount = new TextBox();
            SuspendLayout();
            // 
            // rtbContent
            // 
            rtbContent.Location = new Point(792, 12);
            rtbContent.Name = "rtbContent";
            rtbContent.Size = new Size(1010, 732);
            rtbContent.TabIndex = 0;
            rtbContent.Text = "";
            // 
            // btnDoc
            // 
            btnDoc.BackColor = Color.Gray;
            btnDoc.Location = new Point(25, 601);
            btnDoc.Name = "btnDoc";
            btnDoc.Size = new Size(202, 76);
            btnDoc.TabIndex = 1;
            btnDoc.Text = "Đọc File";
            btnDoc.UseVisualStyleBackColor = false;
            btnDoc.Click += btnDoc_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Gray;
            btnThoat.ForeColor = SystemColors.ControlText;
            btnThoat.Location = new Point(454, 601);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(202, 76);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 47);
            label1.Name = "label1";
            label1.Size = new Size(122, 32);
            label1.TabIndex = 3;
            label1.Text = "File Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 129);
            label2.Name = "label2";
            label2.Size = new Size(57, 32);
            label2.TabIndex = 4;
            label2.Text = "Size";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 209);
            label3.Name = "label3";
            label3.Size = new Size(55, 32);
            label3.TabIndex = 5;
            label3.Text = "URL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 287);
            label4.Name = "label4";
            label4.Size = new Size(126, 32);
            label4.TabIndex = 6;
            label4.Text = "Line count";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 373);
            label5.Name = "label5";
            label5.Size = new Size(149, 32);
            label5.TabIndex = 7;
            label5.Text = "Words count";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 461);
            label6.Name = "label6";
            label6.Size = new Size(183, 32);
            label6.TabIndex = 8;
            label6.Text = "Character count";
            // 
            // txbFileName
            // 
            txbFileName.Location = new Point(277, 47);
            txbFileName.Name = "txbFileName";
            txbFileName.ReadOnly = true;
            txbFileName.Size = new Size(468, 39);
            txbFileName.TabIndex = 9;
            // 
            // txbSize
            // 
            txbSize.Location = new Point(277, 129);
            txbSize.Name = "txbSize";
            txbSize.ReadOnly = true;
            txbSize.Size = new Size(468, 39);
            txbSize.TabIndex = 10;
            // 
            // txbUrl
            // 
            txbUrl.Location = new Point(277, 209);
            txbUrl.Name = "txbUrl";
            txbUrl.ReadOnly = true;
            txbUrl.Size = new Size(468, 39);
            txbUrl.TabIndex = 11;
            // 
            // txbLinecount
            // 
            txbLinecount.Location = new Point(277, 287);
            txbLinecount.Name = "txbLinecount";
            txbLinecount.ReadOnly = true;
            txbLinecount.Size = new Size(468, 39);
            txbLinecount.TabIndex = 12;
            // 
            // txbWordcount
            // 
            txbWordcount.Location = new Point(277, 373);
            txbWordcount.Name = "txbWordcount";
            txbWordcount.ReadOnly = true;
            txbWordcount.Size = new Size(468, 39);
            txbWordcount.TabIndex = 13;
            // 
            // txbCharactercount
            // 
            txbCharactercount.Location = new Point(277, 461);
            txbCharactercount.Name = "txbCharactercount";
            txbCharactercount.ReadOnly = true;
            txbCharactercount.Size = new Size(468, 39);
            txbCharactercount.TabIndex = 14;
            // 
            // Lab02_Bai02
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1814, 766);
            Controls.Add(txbCharactercount);
            Controls.Add(txbWordcount);
            Controls.Add(txbLinecount);
            Controls.Add(txbUrl);
            Controls.Add(txbSize);
            Controls.Add(txbFileName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnThoat);
            Controls.Add(btnDoc);
            Controls.Add(rtbContent);
            Name = "Lab02_Bai02";
            Text = "Lab02_Bai02";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtbContent;
        private Button btnDoc;
        private Button btnThoat;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txbFileName;
        private TextBox txbSize;
        private TextBox txbUrl;
        private TextBox txbLinecount;
        private TextBox txbWordcount;
        private TextBox txbCharactercount;
    }
}