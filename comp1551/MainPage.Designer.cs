namespace comp1551
{
    partial class MainPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMainPage = new Label();
            btnStudent = new Button();
            btnClass = new Button();
            btnTest = new Button();
            btnFaculty = new Button();
            btnTeacher = new Button();
            btnSubject = new Button();
            btnSetting = new Button();
            btnSalary = new Button();
            linkLabelUsers = new LinkLabel();
            SuspendLayout();
            // 
            // lblMainPage
            // 
            lblMainPage.AutoSize = true;
            lblMainPage.BackColor = Color.Transparent;
            lblMainPage.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMainPage.Location = new Point(445, 40);
            lblMainPage.Name = "lblMainPage";
            lblMainPage.Size = new Size(351, 37);
            lblMainPage.TabIndex = 1;
            lblMainPage.Text = "University of Greenwich";
            // 
            // btnStudent
            // 
            btnStudent.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudent.Location = new Point(296, 172);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new Size(180, 120);
            btnStudent.TabIndex = 2;
            btnStudent.Text = "STUDENT";
            btnStudent.UseVisualStyleBackColor = true;
            btnStudent.Click += btnStudent_Click;
            // 
            // btnClass
            // 
            btnClass.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClass.Location = new Point(625, 172);
            btnClass.Name = "btnClass";
            btnClass.Size = new Size(130, 120);
            btnClass.TabIndex = 3;
            btnClass.Text = "CLASS";
            btnClass.UseVisualStyleBackColor = true;
            btnClass.Click += btnClass_Click;
            // 
            // btnTest
            // 
            btnTest.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTest.Location = new Point(296, 298);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(130, 120);
            btnTest.TabIndex = 4;
            btnTest.Text = "TEST";
            btnTest.UseVisualStyleBackColor = true;
            // 
            // btnFaculty
            // 
            btnFaculty.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFaculty.Location = new Point(625, 298);
            btnFaculty.Name = "btnFaculty";
            btnFaculty.Size = new Size(140, 120);
            btnFaculty.TabIndex = 5;
            btnFaculty.Text = "FACULTY";
            btnFaculty.UseVisualStyleBackColor = true;
            btnFaculty.Click += btnFaculty_Click;
            // 
            // btnTeacher
            // 
            btnTeacher.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTeacher.Location = new Point(432, 298);
            btnTeacher.Name = "btnTeacher";
            btnTeacher.Size = new Size(190, 120);
            btnTeacher.TabIndex = 6;
            btnTeacher.Text = "TEACHER";
            btnTeacher.UseVisualStyleBackColor = true;
            btnTeacher.Click += btnTeacher_Click;
            // 
            // btnSubject
            // 
            btnSubject.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubject.Location = new Point(482, 172);
            btnSubject.Name = "btnSubject";
            btnSubject.Size = new Size(140, 120);
            btnSubject.TabIndex = 7;
            btnSubject.Text = "SUBJECT";
            btnSubject.UseVisualStyleBackColor = true;
            btnSubject.Click += btnSubject_Click;
            // 
            // btnSetting
            // 
            btnSetting.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSetting.Location = new Point(771, 298);
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(180, 120);
            btnSetting.TabIndex = 8;
            btnSetting.Text = "SETTING";
            btnSetting.UseVisualStyleBackColor = true;
            btnSetting.Click += btnSetting_Click;
            // 
            // btnSalary
            // 
            btnSalary.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalary.Location = new Point(761, 172);
            btnSalary.Name = "btnSalary";
            btnSalary.Size = new Size(190, 120);
            btnSalary.TabIndex = 9;
            btnSalary.Text = "SALARY";
            btnSalary.UseVisualStyleBackColor = true;
            btnSalary.Click += btnSalary_Click;
            // 
            // linkLabelUsers
            // 
            linkLabelUsers.AutoSize = true;
            linkLabelUsers.Location = new Point(296, 115);
            linkLabelUsers.Name = "linkLabelUsers";
            linkLabelUsers.Size = new Size(86, 25);
            linkLabelUsers.TabIndex = 10;
            linkLabelUsers.TabStop = true;
            linkLabelUsers.Text = "List Users";
            linkLabelUsers.LinkClicked += linkLabelUsers_LinkClicked;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1200, 600);
            ControlBox = false;
            Controls.Add(linkLabelUsers);
            Controls.Add(btnSalary);
            Controls.Add(btnSetting);
            Controls.Add(btnSubject);
            Controls.Add(btnTeacher);
            Controls.Add(btnFaculty);
            Controls.Add(btnTest);
            Controls.Add(btnClass);
            Controls.Add(btnStudent);
            Controls.Add(lblMainPage);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblMainPage;
        private Button btnStudent;
        private Button btnClass;
        private Button btnTest;
        private Button btnFaculty;
        private Button btnTeacher;
        private Button btnSubject;
        private Button btnSetting;
        private Button btnSalary;
        private LinkLabel linkLabelUsers;
    }
}
