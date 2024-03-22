namespace comp1551
{
    partial class Main
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
            mainpanel = new Panel();
            btnStudent = new Button();
            btnTeacher = new Button();
            panel1 = new Panel();
            btnSetting = new Button();
            btnFaculty = new Button();
            btnClass = new Button();
            btnSubject = new Button();
            btnDashboard = new Button();
            lblHello = new Label();
            lblUsername = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // mainpanel
            // 
            mainpanel.Location = new Point(389, 70);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(1200, 600);
            mainpanel.TabIndex = 0;
            // 
            // btnStudent
            // 
            btnStudent.Location = new Point(0, 156);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new Size(225, 80);
            btnStudent.TabIndex = 1;
            btnStudent.Text = "Student";
            btnStudent.UseVisualStyleBackColor = true;
            btnStudent.Click += btnStudent_Click;
            // 
            // btnTeacher
            // 
            btnTeacher.Location = new Point(0, 242);
            btnTeacher.Name = "btnTeacher";
            btnTeacher.Size = new Size(225, 80);
            btnTeacher.TabIndex = 2;
            btnTeacher.Text = "Teacher";
            btnTeacher.UseVisualStyleBackColor = true;
            btnTeacher.Click += btnTeacher_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSetting);
            panel1.Controls.Add(btnFaculty);
            panel1.Controls.Add(btnClass);
            panel1.Controls.Add(btnSubject);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(btnStudent);
            panel1.Controls.Add(btnTeacher);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 731);
            panel1.TabIndex = 4;
            // 
            // btnSetting
            // 
            btnSetting.Location = new Point(0, 586);
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(225, 80);
            btnSetting.TabIndex = 9;
            btnSetting.Text = "Setting";
            btnSetting.UseVisualStyleBackColor = true;
            btnSetting.Click += btnSetting_Click;
            // 
            // btnFaculty
            // 
            btnFaculty.Location = new Point(0, 500);
            btnFaculty.Name = "btnFaculty";
            btnFaculty.Size = new Size(225, 80);
            btnFaculty.TabIndex = 8;
            btnFaculty.Text = "Faculty";
            btnFaculty.UseVisualStyleBackColor = true;
            btnFaculty.Click += btnFaculty_Click;
            // 
            // btnClass
            // 
            btnClass.Location = new Point(0, 414);
            btnClass.Name = "btnClass";
            btnClass.Size = new Size(225, 80);
            btnClass.TabIndex = 6;
            btnClass.Text = "Class";
            btnClass.UseVisualStyleBackColor = true;
            btnClass.Click += btnClass_Click;
            // 
            // btnSubject
            // 
            btnSubject.Location = new Point(0, 328);
            btnSubject.Name = "btnSubject";
            btnSubject.Size = new Size(225, 80);
            btnSubject.TabIndex = 6;
            btnSubject.Text = "Subject";
            btnSubject.UseVisualStyleBackColor = true;
            btnSubject.Click += btnSubject_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(0, 70);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(225, 80);
            btnDashboard.TabIndex = 4;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // lblHello
            // 
            lblHello.AutoSize = true;
            lblHello.Location = new Point(1180, 16);
            lblHello.Name = "lblHello";
            lblHello.Size = new Size(62, 25);
            lblHello.TabIndex = 5;
            lblHello.Text = "Hello, ";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.Chocolate;
            lblUsername.Location = new Point(1233, 12);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(70, 30);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "label1";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1754, 731);
            Controls.Add(lblUsername);
            Controls.Add(lblHello);
            Controls.Add(panel1);
            Controls.Add(mainpanel);
            Name = "Main";
            Text = "Main";
            Load += Main_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel mainpanel;
        private Button btnStudent;
        private Button btnTeacher;
        private Panel panel1;
        private Button btnDashboard;
        private Label lblUsername;
        private Label lblHello;
        private Button btnSetting;
        private Button btnFaculty;
        private Button btnClass;
        private Button btnSubject;
    }
}