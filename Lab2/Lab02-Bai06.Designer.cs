namespace Lab2
{
    partial class Lab02_Bai06
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
            lvMonAn = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            btnRandom = new Button();
            picMonAn = new PictureBox();
            lblTenMonAn = new Label();
            lblNguoiDongGop = new Label();
            ((System.ComponentModel.ISupportInitialize)picMonAn).BeginInit();
            SuspendLayout();
            // 
            // lvMonAn
            // 
            lvMonAn.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvMonAn.FullRowSelect = true;
            lvMonAn.Location = new Point(171, 78);
            lvMonAn.Name = "lvMonAn";
            lvMonAn.Size = new Size(622, 412);
            lvMonAn.TabIndex = 0;
            lvMonAn.UseCompatibleStateImageBehavior = false;
            lvMonAn.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "IDMA";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên món ăn";
            columnHeader2.Width = 180;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Hình ảnh";
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Người đóng góp";
            columnHeader4.Width = 150;
            // 
            // btnRandom
            // 
            btnRandom.Location = new Point(347, 604);
            btnRandom.Name = "btnRandom";
            btnRandom.Size = new Size(240, 80);
            btnRandom.TabIndex = 1;
            btnRandom.Text = "Ăn gì hôm nay?";
            btnRandom.UseVisualStyleBackColor = true;
            btnRandom.Click += btnRandom_Click;
            // 
            // picMonAn
            // 
            picMonAn.Location = new Point(1132, 116);
            picMonAn.Name = "picMonAn";
            picMonAn.Size = new Size(622, 508);
            picMonAn.SizeMode = PictureBoxSizeMode.StretchImage;
            picMonAn.TabIndex = 2;
            picMonAn.TabStop = false;
            // 
            // lblTenMonAn
            // 
            lblTenMonAn.AutoSize = true;
            lblTenMonAn.Location = new Point(879, 424);
            lblTenMonAn.Name = "lblTenMonAn";
            lblTenMonAn.Size = new Size(145, 32);
            lblTenMonAn.TabIndex = 3;
            lblTenMonAn.Text = "Tên Món Ăn";
            // 
            // lblNguoiDongGop
            // 
            lblNguoiDongGop.AutoSize = true;
            lblNguoiDongGop.Location = new Point(879, 242);
            lblNguoiDongGop.Name = "lblNguoiDongGop";
            lblNguoiDongGop.Size = new Size(192, 32);
            lblNguoiDongGop.TabIndex = 4;
            lblNguoiDongGop.Text = "Người đóng góp";
            // 
            // Lab02_Bai06
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1872, 1000);
            Controls.Add(lblNguoiDongGop);
            Controls.Add(lblTenMonAn);
            Controls.Add(picMonAn);
            Controls.Add(btnRandom);
            Controls.Add(lvMonAn);
            Name = "Lab02_Bai06";
            Text = "Lab02_Bai06";
            ((System.ComponentModel.ISupportInitialize)picMonAn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvMonAn;
        private Button btnRandom;
        private PictureBox picMonAn;
        private Label lblTenMonAn;
        private Label lblNguoiDongGop;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}