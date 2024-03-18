namespace comp1551.Student
{
    partial class AddStudent
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
            btnAddStudent = new Button();
            txtAddStudentEmail = new TextBox();
            txtAddStudentName = new TextBox();
            lblAddStudentClassId = new Label();
            lblAddStudentEmail = new Label();
            lblAddStudent = new Label();
            lblAddStudentName = new Label();
            lblAddStudentTelephone = new Label();
            txtAddStudentTelephone = new TextBox();
            pictureboxAddStudent = new PictureBox();
            label2 = new Label();
            linkLblUpload = new LinkLabel();
            lblFaculty = new Label();
            listBoxFaculties = new ListBox();
            listBoxClassId = new ListBox();
            txtAddStudentSubject2 = new TextBox();
            txtAddStudentSubject1 = new TextBox();
            label1 = new Label();
            label3 = new Label();
            txtAddStudentPrevSubject2 = new TextBox();
            txtAddStudentPrevSubject1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureboxAddStudent).BeginInit();
            SuspendLayout();
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(637, 463);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(385, 76);
            btnAddStudent.TabIndex = 10;
            btnAddStudent.Text = "Add";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // txtAddStudentEmail
            // 
            txtAddStudentEmail.Location = new Point(168, 202);
            txtAddStudentEmail.Name = "txtAddStudentEmail";
            txtAddStudentEmail.Size = new Size(150, 31);
            txtAddStudentEmail.TabIndex = 8;
            // 
            // txtAddStudentName
            // 
            txtAddStudentName.Location = new Point(168, 137);
            txtAddStudentName.Name = "txtAddStudentName";
            txtAddStudentName.Size = new Size(150, 31);
            txtAddStudentName.TabIndex = 9;
            // 
            // lblAddStudentClassId
            // 
            lblAddStudentClassId.AutoSize = true;
            lblAddStudentClassId.Location = new Point(735, 137);
            lblAddStudentClassId.Name = "lblAddStudentClassId";
            lblAddStudentClassId.Size = new Size(79, 25);
            lblAddStudentClassId.TabIndex = 3;
            lblAddStudentClassId.Text = "Class ID:";
            // 
            // lblAddStudentEmail
            // 
            lblAddStudentEmail.AutoSize = true;
            lblAddStudentEmail.Location = new Point(81, 205);
            lblAddStudentEmail.Name = "lblAddStudentEmail";
            lblAddStudentEmail.Size = new Size(63, 25);
            lblAddStudentEmail.TabIndex = 4;
            lblAddStudentEmail.Text = "Email: ";
            // 
            // lblAddStudent
            // 
            lblAddStudent.AutoSize = true;
            lblAddStudent.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddStudent.Location = new Point(439, 42);
            lblAddStudent.Name = "lblAddStudent";
            lblAddStudent.Size = new Size(214, 32);
            lblAddStudent.TabIndex = 5;
            lblAddStudent.Text = "Add New Student";
            // 
            // lblAddStudentName
            // 
            lblAddStudentName.AutoSize = true;
            lblAddStudentName.Location = new Point(81, 140);
            lblAddStudentName.Name = "lblAddStudentName";
            lblAddStudentName.Size = new Size(68, 25);
            lblAddStudentName.TabIndex = 6;
            lblAddStudentName.Text = "Name: ";
            // 
            // lblAddStudentTelephone
            // 
            lblAddStudentTelephone.AutoSize = true;
            lblAddStudentTelephone.Location = new Point(43, 280);
            lblAddStudentTelephone.Name = "lblAddStudentTelephone";
            lblAddStudentTelephone.Size = new Size(101, 25);
            lblAddStudentTelephone.TabIndex = 4;
            lblAddStudentTelephone.Text = "Telephone: ";
            // 
            // txtAddStudentTelephone
            // 
            txtAddStudentTelephone.Location = new Point(168, 277);
            txtAddStudentTelephone.Name = "txtAddStudentTelephone";
            txtAddStudentTelephone.Size = new Size(150, 31);
            txtAddStudentTelephone.TabIndex = 8;
            // 
            // pictureboxAddStudent
            // 
            pictureboxAddStudent.BorderStyle = BorderStyle.Fixed3D;
            pictureboxAddStudent.Location = new Point(168, 333);
            pictureboxAddStudent.Name = "pictureboxAddStudent";
            pictureboxAddStudent.Size = new Size(135, 135);
            pictureboxAddStudent.TabIndex = 11;
            pictureboxAddStudent.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 367);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 12;
            label2.Text = "Avatar: ";
            // 
            // linkLblUpload
            // 
            linkLblUpload.AutoSize = true;
            linkLblUpload.Location = new Point(62, 424);
            linkLblUpload.Name = "linkLblUpload";
            linkLblUpload.Size = new Size(70, 25);
            linkLblUpload.TabIndex = 13;
            linkLblUpload.TabStop = true;
            linkLblUpload.Text = "Upload";
            linkLblUpload.LinkClicked += linkLblUpload_LinkClicked;
            // 
            // lblFaculty
            // 
            lblFaculty.AutoSize = true;
            lblFaculty.Location = new Point(363, 143);
            lblFaculty.Name = "lblFaculty";
            lblFaculty.Size = new Size(70, 25);
            lblFaculty.TabIndex = 14;
            lblFaculty.Text = "Faculty:";
            // 
            // listBoxFaculties
            // 
            listBoxFaculties.FormattingEnabled = true;
            listBoxFaculties.ItemHeight = 25;
            listBoxFaculties.Location = new Point(473, 143);
            listBoxFaculties.Name = "listBoxFaculties";
            listBoxFaculties.Size = new Size(180, 129);
            listBoxFaculties.TabIndex = 15;
            // 
            // listBoxClassId
            // 
            listBoxClassId.FormattingEnabled = true;
            listBoxClassId.ItemHeight = 25;
            listBoxClassId.Location = new Point(842, 137);
            listBoxClassId.Name = "listBoxClassId";
            listBoxClassId.Size = new Size(180, 129);
            listBoxClassId.TabIndex = 16;
            // 
            // txtAddStudentSubject2
            // 
            txtAddStudentSubject2.Location = new Point(471, 376);
            txtAddStudentSubject2.Name = "txtAddStudentSubject2";
            txtAddStudentSubject2.Size = new Size(150, 31);
            txtAddStudentSubject2.TabIndex = 19;
            // 
            // txtAddStudentSubject1
            // 
            txtAddStudentSubject1.Location = new Point(471, 311);
            txtAddStudentSubject1.Name = "txtAddStudentSubject1";
            txtAddStudentSubject1.Size = new Size(150, 31);
            txtAddStudentSubject1.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(363, 379);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 17;
            label1.Text = "Subject 2:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(363, 314);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 18;
            label3.Text = "Subject 1:";
            // 
            // txtAddStudentPrevSubject2
            // 
            txtAddStudentPrevSubject2.Location = new Point(872, 376);
            txtAddStudentPrevSubject2.Name = "txtAddStudentPrevSubject2";
            txtAddStudentPrevSubject2.Size = new Size(150, 31);
            txtAddStudentPrevSubject2.TabIndex = 23;
            // 
            // txtAddStudentPrevSubject1
            // 
            txtAddStudentPrevSubject1.Location = new Point(872, 311);
            txtAddStudentPrevSubject1.Name = "txtAddStudentPrevSubject1";
            txtAddStudentPrevSubject1.Size = new Size(150, 31);
            txtAddStudentPrevSubject1.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(687, 379);
            label4.Name = "label4";
            label4.Size = new Size(161, 25);
            label4.TabIndex = 21;
            label4.Text = "Previous Subject 2:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(687, 311);
            label5.Name = "label5";
            label5.Size = new Size(161, 25);
            label5.TabIndex = 22;
            label5.Text = "Previous Subject 1:";
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 573);
            Controls.Add(txtAddStudentPrevSubject2);
            Controls.Add(txtAddStudentPrevSubject1);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(txtAddStudentSubject2);
            Controls.Add(txtAddStudentSubject1);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(listBoxClassId);
            Controls.Add(listBoxFaculties);
            Controls.Add(lblFaculty);
            Controls.Add(linkLblUpload);
            Controls.Add(label2);
            Controls.Add(pictureboxAddStudent);
            Controls.Add(btnAddStudent);
            Controls.Add(txtAddStudentTelephone);
            Controls.Add(txtAddStudentEmail);
            Controls.Add(txtAddStudentName);
            Controls.Add(lblAddStudentTelephone);
            Controls.Add(lblAddStudentClassId);
            Controls.Add(lblAddStudentEmail);
            Controls.Add(lblAddStudent);
            Controls.Add(lblAddStudentName);
            Name = "AddStudent";
            Text = "AddStudent";
            Load += AddStudent_Load;
            ((System.ComponentModel.ISupportInitialize)pictureboxAddStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddStudent;
        private TextBox txtAddStudentEmail;
        private TextBox txtAddStudentName;
        private Label lblAddStudentClassId;
        private Label lblAddStudentEmail;
        private Label lblAddStudent;
        private Label lblAddStudentName;
        private Label lblAddStudentTelephone;
        private TextBox txtAddStudentTelephone;
        private PictureBox pictureboxAddStudent;
        private Label label2;
        private LinkLabel linkLblUpload;
        private Label lblFaculty;
        private ListBox listBoxFaculties;
        private ListBox listBoxClassId;
        private TextBox txtAddStudentSubject2;
        private TextBox txtAddStudentSubject1;
        private Label label1;
        private Label label3;
        private TextBox txtAddStudentPrevSubject2;
        private TextBox txtAddStudentPrevSubject1;
        private Label label4;
        private Label label5;
    }
}