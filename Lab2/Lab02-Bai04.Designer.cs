namespace Lab2
{
    partial class Lab02_Bai04
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
            txbAddName = new TextBox();
            txbAddID = new TextBox();
            txbAddPhone = new TextBox();
            txbAddCourse1 = new TextBox();
            txbAddCourse2 = new TextBox();
            txbAddCourse3 = new TextBox();
            txbAddAverage = new TextBox();
            btnAdd = new Button();
            btnWrite = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            rtbContent = new RichTextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            btnRead = new Button();
            txbReadName = new TextBox();
            txbReadID = new TextBox();
            txbReadPhone = new TextBox();
            txbReadCourse1 = new TextBox();
            txbReadCourse2 = new TextBox();
            txbReadCourse3 = new TextBox();
            txbReadAverage = new TextBox();
            btnBack = new Button();
            btnNext = new Button();
            lblPage = new Label();
            SuspendLayout();
            // 
            // txbAddName
            // 
            txbAddName.Location = new Point(84, 199);
            txbAddName.Name = "txbAddName";
            txbAddName.Size = new Size(220, 39);
            txbAddName.TabIndex = 0;
            // 
            // txbAddID
            // 
            txbAddID.Location = new Point(84, 307);
            txbAddID.Name = "txbAddID";
            txbAddID.Size = new Size(220, 39);
            txbAddID.TabIndex = 1;
            // 
            // txbAddPhone
            // 
            txbAddPhone.Location = new Point(84, 409);
            txbAddPhone.Name = "txbAddPhone";
            txbAddPhone.Size = new Size(220, 39);
            txbAddPhone.TabIndex = 2;
            // 
            // txbAddCourse1
            // 
            txbAddCourse1.Location = new Point(84, 509);
            txbAddCourse1.Name = "txbAddCourse1";
            txbAddCourse1.Size = new Size(220, 39);
            txbAddCourse1.TabIndex = 3;
            // 
            // txbAddCourse2
            // 
            txbAddCourse2.Location = new Point(84, 609);
            txbAddCourse2.Name = "txbAddCourse2";
            txbAddCourse2.Size = new Size(220, 39);
            txbAddCourse2.TabIndex = 4;
            // 
            // txbAddCourse3
            // 
            txbAddCourse3.Location = new Point(84, 705);
            txbAddCourse3.Name = "txbAddCourse3";
            txbAddCourse3.Size = new Size(220, 39);
            txbAddCourse3.TabIndex = 5;
            // 
            // txbAddAverage
            // 
            txbAddAverage.Location = new Point(84, 815);
            txbAddAverage.Name = "txbAddAverage";
            txbAddAverage.ReadOnly = true;
            txbAddAverage.Size = new Size(220, 39);
            txbAddAverage.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(84, 911);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(200, 72);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnWrite
            // 
            btnWrite.Location = new Point(26, 57);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(358, 74);
            btnWrite.TabIndex = 8;
            btnWrite.Text = "Write a File";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(402, 202);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 9;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(420, 307);
            label2.Name = "label2";
            label2.Size = new Size(37, 32);
            label2.TabIndex = 10;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(402, 409);
            label3.Name = "label3";
            label3.Size = new Size(82, 32);
            label3.TabIndex = 11;
            label3.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(402, 509);
            label4.Name = "label4";
            label4.Size = new Size(108, 32);
            label4.TabIndex = 12;
            label4.Text = "Course 1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(402, 609);
            label5.Name = "label5";
            label5.Size = new Size(108, 32);
            label5.TabIndex = 13;
            label5.Text = "Course 2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(402, 705);
            label6.Name = "label6";
            label6.Size = new Size(108, 32);
            label6.TabIndex = 14;
            label6.Text = "Course 3";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(402, 815);
            label7.Name = "label7";
            label7.Size = new Size(101, 32);
            label7.TabIndex = 15;
            label7.Text = "Average";
            // 
            // rtbContent
            // 
            rtbContent.Location = new Point(660, 24);
            rtbContent.Name = "rtbContent";
            rtbContent.ReadOnly = true;
            rtbContent.Size = new Size(518, 1014);
            rtbContent.TabIndex = 16;
            rtbContent.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1674, 199);
            label8.Name = "label8";
            label8.Size = new Size(78, 32);
            label8.TabIndex = 17;
            label8.Text = "Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1674, 310);
            label9.Name = "label9";
            label9.Size = new Size(37, 32);
            label9.TabIndex = 18;
            label9.Text = "ID";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1674, 409);
            label10.Name = "label10";
            label10.Size = new Size(82, 32);
            label10.TabIndex = 19;
            label10.Text = "Phone";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1674, 509);
            label11.Name = "label11";
            label11.Size = new Size(108, 32);
            label11.TabIndex = 20;
            label11.Text = "Course 1";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(1674, 609);
            label12.Name = "label12";
            label12.Size = new Size(108, 32);
            label12.TabIndex = 21;
            label12.Text = "Course 2";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(1674, 712);
            label13.Name = "label13";
            label13.Size = new Size(108, 32);
            label13.TabIndex = 22;
            label13.Text = "Course 3";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(1674, 815);
            label14.Name = "label14";
            label14.Size = new Size(101, 32);
            label14.TabIndex = 23;
            label14.Text = "Average";
            // 
            // btnRead
            // 
            btnRead.Location = new Point(1350, 55);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(422, 76);
            btnRead.TabIndex = 24;
            btnRead.Text = "Button to read a File";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // txbReadName
            // 
            txbReadName.Location = new Point(1315, 205);
            txbReadName.Name = "txbReadName";
            txbReadName.Size = new Size(270, 39);
            txbReadName.TabIndex = 25;
            // 
            // txbReadID
            // 
            txbReadID.Location = new Point(1315, 310);
            txbReadID.Name = "txbReadID";
            txbReadID.Size = new Size(270, 39);
            txbReadID.TabIndex = 26;
            // 
            // txbReadPhone
            // 
            txbReadPhone.Location = new Point(1315, 409);
            txbReadPhone.Name = "txbReadPhone";
            txbReadPhone.Size = new Size(270, 39);
            txbReadPhone.TabIndex = 27;
            // 
            // txbReadCourse1
            // 
            txbReadCourse1.Location = new Point(1315, 506);
            txbReadCourse1.Name = "txbReadCourse1";
            txbReadCourse1.Size = new Size(270, 39);
            txbReadCourse1.TabIndex = 28;
            // 
            // txbReadCourse2
            // 
            txbReadCourse2.Location = new Point(1315, 602);
            txbReadCourse2.Name = "txbReadCourse2";
            txbReadCourse2.Size = new Size(270, 39);
            txbReadCourse2.TabIndex = 29;
            // 
            // txbReadCourse3
            // 
            txbReadCourse3.Location = new Point(1315, 712);
            txbReadCourse3.Name = "txbReadCourse3";
            txbReadCourse3.Size = new Size(270, 39);
            txbReadCourse3.TabIndex = 30;
            // 
            // txbReadAverage
            // 
            txbReadAverage.Location = new Point(1315, 812);
            txbReadAverage.Name = "txbReadAverage";
            txbReadAverage.ReadOnly = true;
            txbReadAverage.Size = new Size(270, 39);
            txbReadAverage.TabIndex = 31;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(1259, 923);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(180, 70);
            btnBack.TabIndex = 32;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(1632, 923);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(180, 70);
            btnNext.TabIndex = 33;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // lblPage
            // 
            lblPage.AutoSize = true;
            lblPage.Location = new Point(1515, 942);
            lblPage.Name = "lblPage";
            lblPage.Size = new Size(27, 32);
            lblPage.TabIndex = 34;
            lblPage.Text = "1";
            // 
            // Lab02_Bai04
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1060);
            Controls.Add(lblPage);
            Controls.Add(btnNext);
            Controls.Add(btnBack);
            Controls.Add(txbReadAverage);
            Controls.Add(txbReadCourse3);
            Controls.Add(txbReadCourse2);
            Controls.Add(txbReadCourse1);
            Controls.Add(txbReadPhone);
            Controls.Add(txbReadID);
            Controls.Add(txbReadName);
            Controls.Add(btnRead);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(rtbContent);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnWrite);
            Controls.Add(btnAdd);
            Controls.Add(txbAddAverage);
            Controls.Add(txbAddCourse3);
            Controls.Add(txbAddCourse2);
            Controls.Add(txbAddCourse1);
            Controls.Add(txbAddPhone);
            Controls.Add(txbAddID);
            Controls.Add(txbAddName);
            Name = "Lab02_Bai04";
            Text = "Lab02_Bai04";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbAddName;
        private TextBox txbAddID;
        private TextBox txbAddPhone;
        private TextBox txbAddCourse1;
        private TextBox txbAddCourse2;
        private TextBox txbAddCourse3;
        private TextBox txbAddAverage;
        private Button btnAdd;
        private Button btnWrite;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private RichTextBox rtbContent;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Button btnRead;
        private TextBox txbReadName;
        private TextBox txbReadID;
        private TextBox txbReadPhone;
        private TextBox txbReadCourse1;
        private TextBox txbReadCourse2;
        private TextBox txbReadCourse3;
        private TextBox txbReadAverage;
        private Button btnBack;
        private Button btnNext;
        private Label lblPage;
    }
}