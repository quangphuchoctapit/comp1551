namespace comp1551.Teacher
{
    partial class AddTeacher
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
            btnAddTeacher = new Button();
            txtAddTeacherEmail = new TextBox();
            txtAddTeacherName = new TextBox();
            lblAddTeacherTelephone = new Label();
            lblAddTeacherMajor = new Label();
            lblAddTeacherEmail = new Label();
            lblAddTeacher = new Label();
            lblAddTeacherName = new Label();
            txtAddTeacherTelephone = new TextBox();
            lblAddTeacherDescription = new Label();
            txtAddTeacherQualifications = new TextBox();
            linkLblAddTeacherUpload = new LinkLabel();
            lblAddTeacherAvatar = new Label();
            pictureboxAddTeacher = new PictureBox();
            listBoxFaculties = new ListBox();
            txtAddTeacherSubject1 = new TextBox();
            label1 = new Label();
            txtAddTeacherSubject2 = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureboxAddTeacher).BeginInit();
            SuspendLayout();
            // 
            // btnAddTeacher
            // 
            btnAddTeacher.Location = new Point(675, 515);
            btnAddTeacher.Name = "btnAddTeacher";
            btnAddTeacher.Size = new Size(205, 75);
            btnAddTeacher.TabIndex = 33;
            btnAddTeacher.Text = "Add";
            btnAddTeacher.UseVisualStyleBackColor = true;
            btnAddTeacher.Click += btnAddTeacher_Click;
            // 
            // txtAddTeacherEmail
            // 
            txtAddTeacherEmail.Location = new Point(168, 199);
            txtAddTeacherEmail.Name = "txtAddTeacherEmail";
            txtAddTeacherEmail.Size = new Size(150, 31);
            txtAddTeacherEmail.TabIndex = 31;
            // 
            // txtAddTeacherName
            // 
            txtAddTeacherName.Location = new Point(168, 134);
            txtAddTeacherName.Name = "txtAddTeacherName";
            txtAddTeacherName.Size = new Size(150, 31);
            txtAddTeacherName.TabIndex = 32;
            // 
            // lblAddTeacherTelephone
            // 
            lblAddTeacherTelephone.AutoSize = true;
            lblAddTeacherTelephone.Location = new Point(38, 274);
            lblAddTeacherTelephone.Name = "lblAddTeacherTelephone";
            lblAddTeacherTelephone.Size = new Size(101, 25);
            lblAddTeacherTelephone.TabIndex = 25;
            lblAddTeacherTelephone.Text = "Telephone: ";
            // 
            // lblAddTeacherMajor
            // 
            lblAddTeacherMajor.AutoSize = true;
            lblAddTeacherMajor.Location = new Point(382, 137);
            lblAddTeacherMajor.Name = "lblAddTeacherMajor";
            lblAddTeacherMajor.Size = new Size(75, 25);
            lblAddTeacherMajor.TabIndex = 24;
            lblAddTeacherMajor.Text = "Majors: ";
            // 
            // lblAddTeacherEmail
            // 
            lblAddTeacherEmail.AutoSize = true;
            lblAddTeacherEmail.Location = new Point(81, 202);
            lblAddTeacherEmail.Name = "lblAddTeacherEmail";
            lblAddTeacherEmail.Size = new Size(58, 25);
            lblAddTeacherEmail.TabIndex = 26;
            lblAddTeacherEmail.Text = "Email:";
            // 
            // lblAddTeacher
            // 
            lblAddTeacher.AutoSize = true;
            lblAddTeacher.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddTeacher.Location = new Point(307, 54);
            lblAddTeacher.Name = "lblAddTeacher";
            lblAddTeacher.Size = new Size(213, 32);
            lblAddTeacher.TabIndex = 27;
            lblAddTeacher.Text = "Add New Teacher";
            // 
            // lblAddTeacherName
            // 
            lblAddTeacherName.AutoSize = true;
            lblAddTeacherName.Location = new Point(81, 137);
            lblAddTeacherName.Name = "lblAddTeacherName";
            lblAddTeacherName.Size = new Size(68, 25);
            lblAddTeacherName.TabIndex = 28;
            lblAddTeacherName.Text = "Name: ";
            // 
            // txtAddTeacherTelephone
            // 
            txtAddTeacherTelephone.Location = new Point(168, 274);
            txtAddTeacherTelephone.Name = "txtAddTeacherTelephone";
            txtAddTeacherTelephone.Size = new Size(150, 31);
            txtAddTeacherTelephone.TabIndex = 29;
            // 
            // lblAddTeacherDescription
            // 
            lblAddTeacherDescription.AutoSize = true;
            lblAddTeacherDescription.Location = new Point(26, 332);
            lblAddTeacherDescription.Name = "lblAddTeacherDescription";
            lblAddTeacherDescription.Size = new Size(123, 25);
            lblAddTeacherDescription.TabIndex = 26;
            lblAddTeacherDescription.Text = "Qualifications:";
            // 
            // txtAddTeacherQualifications
            // 
            txtAddTeacherQualifications.Location = new Point(168, 344);
            txtAddTeacherQualifications.Multiline = true;
            txtAddTeacherQualifications.Name = "txtAddTeacherQualifications";
            txtAddTeacherQualifications.Size = new Size(377, 125);
            txtAddTeacherQualifications.TabIndex = 34;
            // 
            // linkLblAddTeacherUpload
            // 
            linkLblAddTeacherUpload.AutoSize = true;
            linkLblAddTeacherUpload.Location = new Point(658, 222);
            linkLblAddTeacherUpload.Name = "linkLblAddTeacherUpload";
            linkLblAddTeacherUpload.Size = new Size(70, 25);
            linkLblAddTeacherUpload.TabIndex = 37;
            linkLblAddTeacherUpload.TabStop = true;
            linkLblAddTeacherUpload.Text = "Upload";
            linkLblAddTeacherUpload.LinkClicked += linkLblAddTeacherUpload_LinkClicked;
            // 
            // lblAddTeacherAvatar
            // 
            lblAddTeacherAvatar.AutoSize = true;
            lblAddTeacherAvatar.Location = new Point(658, 175);
            lblAddTeacherAvatar.Name = "lblAddTeacherAvatar";
            lblAddTeacherAvatar.Size = new Size(72, 25);
            lblAddTeacherAvatar.TabIndex = 36;
            lblAddTeacherAvatar.Text = "Avatar: ";
            // 
            // pictureboxAddTeacher
            // 
            pictureboxAddTeacher.BorderStyle = BorderStyle.Fixed3D;
            pictureboxAddTeacher.Location = new Point(745, 131);
            pictureboxAddTeacher.Name = "pictureboxAddTeacher";
            pictureboxAddTeacher.Size = new Size(135, 135);
            pictureboxAddTeacher.TabIndex = 35;
            pictureboxAddTeacher.TabStop = false;
            // 
            // listBoxFaculties
            // 
            listBoxFaculties.FormattingEnabled = true;
            listBoxFaculties.ItemHeight = 25;
            listBoxFaculties.Location = new Point(463, 134);
            listBoxFaculties.Name = "listBoxFaculties";
            listBoxFaculties.Size = new Size(180, 179);
            listBoxFaculties.TabIndex = 38;
            // 
            // txtAddTeacherSubject1
            // 
            txtAddTeacherSubject1.Location = new Point(730, 344);
            txtAddTeacherSubject1.Name = "txtAddTeacherSubject1";
            txtAddTeacherSubject1.Size = new Size(150, 31);
            txtAddTeacherSubject1.TabIndex = 40;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(600, 344);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 39;
            label1.Text = "Subject 1:";
            // 
            // txtAddTeacherSubject2
            // 
            txtAddTeacherSubject2.Location = new Point(730, 412);
            txtAddTeacherSubject2.Name = "txtAddTeacherSubject2";
            txtAddTeacherSubject2.Size = new Size(150, 31);
            txtAddTeacherSubject2.TabIndex = 42;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(600, 412);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 41;
            label2.Text = "Subject 2:";
            // 
            // AddTeacher
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 634);
            Controls.Add(txtAddTeacherSubject2);
            Controls.Add(label2);
            Controls.Add(txtAddTeacherSubject1);
            Controls.Add(label1);
            Controls.Add(listBoxFaculties);
            Controls.Add(linkLblAddTeacherUpload);
            Controls.Add(lblAddTeacherAvatar);
            Controls.Add(pictureboxAddTeacher);
            Controls.Add(txtAddTeacherQualifications);
            Controls.Add(btnAddTeacher);
            Controls.Add(txtAddTeacherTelephone);
            Controls.Add(txtAddTeacherEmail);
            Controls.Add(txtAddTeacherName);
            Controls.Add(lblAddTeacherTelephone);
            Controls.Add(lblAddTeacherDescription);
            Controls.Add(lblAddTeacherMajor);
            Controls.Add(lblAddTeacherEmail);
            Controls.Add(lblAddTeacher);
            Controls.Add(lblAddTeacherName);
            Name = "AddTeacher";
            Text = "AddTeacher";
            Load += AddTeacher_Load;
            ((System.ComponentModel.ISupportInitialize)pictureboxAddTeacher).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddTeacher;
        private TextBox txtAddTeacherEmail;
        private TextBox txtAddTeacherName;
        private Label lblAddTeacherTelephone;
        private Label lblAddTeacherMajor;
        private Label lblAddTeacherEmail;
        private Label lblAddTeacher;
        private Label lblAddTeacherName;
        private TextBox txtAddTeacherTelephone;
        private Label lblAddTeacherDescription;
        private TextBox txtAddTeacherQualifications;
        private LinkLabel linkLblAddTeacherUpload;
        private Label lblAddTeacherAvatar;
        private PictureBox pictureboxAddTeacher;
        private ListBox listBoxFaculties;
        private TextBox txtAddTeacherSubject1;
        private Label label1;
        private TextBox txtAddTeacherSubject2;
        private Label label2;
    }
}