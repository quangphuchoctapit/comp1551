namespace comp1551.Faculty
{
    partial class AddFaculty
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
            txtAddFacultyDescription = new TextBox();
            label1 = new Label();
            btnAddFaculty = new Button();
            txtAddFacultyFacultyId = new TextBox();
            txtAddFacultyName = new TextBox();
            lblAddSubjectSubjectId = new Label();
            lblAddFaculty = new Label();
            lblAddSubjectName = new Label();
            lblAddFacultySubjects = new Label();
            listboxSubjects = new ListBox();
            SuspendLayout();
            // 
            // txtAddFacultyDescription
            // 
            txtAddFacultyDescription.Location = new Point(230, 228);
            txtAddFacultyDescription.Multiline = true;
            txtAddFacultyDescription.Name = "txtAddFacultyDescription";
            txtAddFacultyDescription.Size = new Size(147, 146);
            txtAddFacultyDescription.TabIndex = 43;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 228);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 42;
            label1.Text = "Description:";
            // 
            // btnAddFaculty
            // 
            btnAddFaculty.Location = new Point(596, 406);
            btnAddFaculty.Name = "btnAddFaculty";
            btnAddFaculty.Size = new Size(282, 87);
            btnAddFaculty.TabIndex = 41;
            btnAddFaculty.Text = "Add";
            btnAddFaculty.UseVisualStyleBackColor = true;
            btnAddFaculty.Click += btnAddFaculty_Click;
            // 
            // txtAddFacultyFacultyId
            // 
            txtAddFacultyFacultyId.Location = new Point(549, 160);
            txtAddFacultyFacultyId.Name = "txtAddFacultyFacultyId";
            txtAddFacultyFacultyId.Size = new Size(147, 31);
            txtAddFacultyFacultyId.TabIndex = 39;
            // 
            // txtAddFacultyName
            // 
            txtAddFacultyName.Location = new Point(230, 160);
            txtAddFacultyName.Name = "txtAddFacultyName";
            txtAddFacultyName.Size = new Size(147, 31);
            txtAddFacultyName.TabIndex = 40;
            // 
            // lblAddSubjectSubjectId
            // 
            lblAddSubjectSubjectId.AutoSize = true;
            lblAddSubjectSubjectId.Location = new Point(433, 163);
            lblAddSubjectSubjectId.Name = "lblAddSubjectSubjectId";
            lblAddSubjectSubjectId.Size = new Size(93, 25);
            lblAddSubjectSubjectId.TabIndex = 36;
            lblAddSubjectSubjectId.Text = "Faculty ID:";
            // 
            // lblAddFaculty
            // 
            lblAddFaculty.AutoSize = true;
            lblAddFaculty.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddFaculty.Location = new Point(390, 66);
            lblAddFaculty.Name = "lblAddFaculty";
            lblAddFaculty.Size = new Size(206, 32);
            lblAddFaculty.TabIndex = 37;
            lblAddFaculty.Text = "Add New Faculty";
            // 
            // lblAddSubjectName
            // 
            lblAddSubjectName.AutoSize = true;
            lblAddSubjectName.Location = new Point(143, 163);
            lblAddSubjectName.Name = "lblAddSubjectName";
            lblAddSubjectName.Size = new Size(68, 25);
            lblAddSubjectName.TabIndex = 38;
            lblAddSubjectName.Text = "Name: ";
            // 
            // lblAddFacultySubjects
            // 
            lblAddFacultySubjects.AutoSize = true;
            lblAddFacultySubjects.Location = new Point(433, 231);
            lblAddFacultySubjects.Name = "lblAddFacultySubjects";
            lblAddFacultySubjects.Size = new Size(82, 25);
            lblAddFacultySubjects.TabIndex = 44;
            lblAddFacultySubjects.Text = "Subjects:";
            // 
            // listboxSubjects
            // 
            listboxSubjects.FormattingEnabled = true;
            listboxSubjects.ItemHeight = 25;
            listboxSubjects.Location = new Point(551, 232);
            listboxSubjects.Name = "listboxSubjects";
            listboxSubjects.SelectionMode = SelectionMode.MultiSimple;
            listboxSubjects.Size = new Size(327, 129);
            listboxSubjects.TabIndex = 45;
            // 
            // AddFaculty
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 505);
            Controls.Add(listboxSubjects);
            Controls.Add(lblAddFacultySubjects);
            Controls.Add(txtAddFacultyDescription);
            Controls.Add(label1);
            Controls.Add(btnAddFaculty);
            Controls.Add(txtAddFacultyFacultyId);
            Controls.Add(txtAddFacultyName);
            Controls.Add(lblAddSubjectSubjectId);
            Controls.Add(lblAddFaculty);
            Controls.Add(lblAddSubjectName);
            Name = "AddFaculty";
            Text = "AddFaculty";
            Load += AddFaculty_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAddFacultyDescription;
        private Label label1;
        private Button btnAddFaculty;
        private TextBox txtAddFacultyFacultyId;
        private TextBox txtAddFacultyName;
        private Label lblAddSubjectSubjectId;
        private Label lblAddFaculty;
        private Label lblAddSubjectName;
        private Label lblAddFacultySubjects;
        private ListBox listboxSubjects;
    }
}