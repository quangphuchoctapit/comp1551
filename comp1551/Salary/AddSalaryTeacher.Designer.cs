namespace comp1551.Salary
{
    partial class AddSalaryTeacher
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
            btnAddSalaryTeacher = new Button();
            txtAddSalaryTeacherSalary = new TextBox();
            lblAddSalaryTeacherAllowances = new Label();
            lblAddSalaryTeacherTeacherID = new Label();
            lblAddSalaryTeacher = new Label();
            listBoxAddSalaryTeacherTeacherId = new ListBox();
            SuspendLayout();
            // 
            // btnAddSalaryTeacher
            // 
            btnAddSalaryTeacher.Location = new Point(137, 329);
            btnAddSalaryTeacher.Name = "btnAddSalaryTeacher";
            btnAddSalaryTeacher.Size = new Size(257, 75);
            btnAddSalaryTeacher.TabIndex = 48;
            btnAddSalaryTeacher.Text = "Add";
            btnAddSalaryTeacher.UseVisualStyleBackColor = true;
            btnAddSalaryTeacher.Click += btnAddSalaryTeacher_Click;
            // 
            // txtAddSalaryTeacherSalary
            // 
            txtAddSalaryTeacherSalary.Location = new Point(202, 118);
            txtAddSalaryTeacherSalary.Name = "txtAddSalaryTeacherSalary";
            txtAddSalaryTeacherSalary.Size = new Size(192, 31);
            txtAddSalaryTeacherSalary.TabIndex = 44;
            // 
            // lblAddSalaryTeacherAllowances
            // 
            lblAddSalaryTeacherAllowances.AutoSize = true;
            lblAddSalaryTeacherAllowances.Location = new Point(137, 121);
            lblAddSalaryTeacherAllowances.Name = "lblAddSalaryTeacherAllowances";
            lblAddSalaryTeacherAllowances.Size = new Size(63, 25);
            lblAddSalaryTeacherAllowances.TabIndex = 39;
            lblAddSalaryTeacherAllowances.Text = "Salary:";
            // 
            // lblAddSalaryTeacherTeacherID
            // 
            lblAddSalaryTeacherTeacherID.AutoSize = true;
            lblAddSalaryTeacherTeacherID.Location = new Point(137, 169);
            lblAddSalaryTeacherTeacherID.Name = "lblAddSalaryTeacherTeacherID";
            lblAddSalaryTeacherTeacherID.Size = new Size(102, 25);
            lblAddSalaryTeacherTeacherID.TabIndex = 38;
            lblAddSalaryTeacherTeacherID.Text = "Teacher ID: ";
            // 
            // lblAddSalaryTeacher
            // 
            lblAddSalaryTeacher.AutoSize = true;
            lblAddSalaryTeacher.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddSalaryTeacher.Location = new Point(157, 36);
            lblAddSalaryTeacher.Name = "lblAddSalaryTeacher";
            lblAddSalaryTeacher.Size = new Size(196, 32);
            lblAddSalaryTeacher.TabIndex = 42;
            lblAddSalaryTeacher.Text = "Add New Salary";
            // 
            // listBoxAddSalaryTeacherTeacherId
            // 
            listBoxAddSalaryTeacherTeacherId.FormattingEnabled = true;
            listBoxAddSalaryTeacherTeacherId.ItemHeight = 25;
            listBoxAddSalaryTeacherTeacherId.Location = new Point(137, 197);
            listBoxAddSalaryTeacherTeacherId.Name = "listBoxAddSalaryTeacherTeacherId";
            listBoxAddSalaryTeacherTeacherId.Size = new Size(257, 104);
            listBoxAddSalaryTeacherTeacherId.TabIndex = 49;
            // 
            // AddSalaryTeacher
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 416);
            Controls.Add(listBoxAddSalaryTeacherTeacherId);
            Controls.Add(btnAddSalaryTeacher);
            Controls.Add(txtAddSalaryTeacherSalary);
            Controls.Add(lblAddSalaryTeacherAllowances);
            Controls.Add(lblAddSalaryTeacherTeacherID);
            Controls.Add(lblAddSalaryTeacher);
            Name = "AddSalaryTeacher";
            Text = "AddSalaryTeacher";
            Load += AddSalaryTeacher_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAddSalaryTeacher;
        private TextBox txtAddSalaryTeacherSalary;
        private Label lblAddSalaryTeacherAllowances;
        private Label lblAddSalaryTeacherTeacherID;
        private Label lblAddSalaryTeacher;
        private ListBox listBoxAddSalaryTeacherTeacherId;
    }
}