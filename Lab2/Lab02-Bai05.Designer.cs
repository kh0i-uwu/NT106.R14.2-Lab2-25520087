namespace Lab2
{
    partial class Lab02_Bai05
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
            btnDocFile = new Button();
            btnDatVe = new Button();
            btnXuatFile = new Button();
            cboPhim = new ComboBox();
            cboPhong = new ComboBox();
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // rtbContent
            // 
            rtbContent.Location = new Point(596, 462);
            rtbContent.Name = "rtbContent";
            rtbContent.ReadOnly = true;
            rtbContent.Size = new Size(1082, 224);
            rtbContent.TabIndex = 0;
            rtbContent.Text = "";
            // 
            // btnDocFile
            // 
            btnDocFile.Location = new Point(60, 728);
            btnDocFile.Name = "btnDocFile";
            btnDocFile.Size = new Size(152, 70);
            btnDocFile.TabIndex = 1;
            btnDocFile.Text = "Đọc File";
            btnDocFile.UseVisualStyleBackColor = true;
            btnDocFile.Click += button1_Click;
            // 
            // btnDatVe
            // 
            btnDatVe.Location = new Point(70, 285);
            btnDatVe.Name = "btnDatVe";
            btnDatVe.Size = new Size(320, 70);
            btnDatVe.TabIndex = 2;
            btnDatVe.Text = "Đặt vé";
            btnDatVe.UseVisualStyleBackColor = true;
            btnDatVe.Click += btnDatVe_Click;
            // 
            // btnXuatFile
            // 
            btnXuatFile.Location = new Point(352, 728);
            btnXuatFile.Name = "btnXuatFile";
            btnXuatFile.Size = new Size(152, 70);
            btnXuatFile.TabIndex = 3;
            btnXuatFile.Text = "Xuất File";
            btnXuatFile.UseVisualStyleBackColor = true;
            btnXuatFile.Click += btnXuatFile_Click;
            // 
            // cboPhim
            // 
            cboPhim.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPhim.FormattingEnabled = true;
            cboPhim.Location = new Point(456, 75);
            cboPhim.Name = "cboPhim";
            cboPhim.Size = new Size(510, 40);
            cboPhim.TabIndex = 4;
            cboPhim.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // cboPhong
            // 
            cboPhong.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPhong.FormattingEnabled = true;
            cboPhong.Location = new Point(1192, 75);
            cboPhong.Name = "cboPhong";
            cboPhong.Size = new Size(510, 40);
            cboPhong.TabIndex = 5;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(596, 728);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(1082, 242);
            progressBar1.TabIndex = 6;
            // 
            // Lab02_Bai05
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1852, 1042);
            Controls.Add(progressBar1);
            Controls.Add(cboPhong);
            Controls.Add(cboPhim);
            Controls.Add(btnXuatFile);
            Controls.Add(btnDatVe);
            Controls.Add(btnDocFile);
            Controls.Add(rtbContent);
            Name = "Lab02_Bai05";
            Text = "Lab02_Bai05";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtbContent;
        private Button btnDocFile;
        private Button btnDatVe;
        private Button btnXuatFile;
        private ComboBox cboPhim;
        private ComboBox cboPhong;
        private ProgressBar progressBar1;
    }
}