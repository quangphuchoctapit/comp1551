namespace comp1551.Salary
{
    partial class SalaryAdminDetails
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
            btnConfirmAdminSalary = new Button();
            txtAdminSalary = new TextBox();
            lblAddSalaryTeacherAllowances = new Label();
            lblSalaryAdmin = new Label();
            SuspendLayout();
            // 
            // btnConfirmAdminSalary
            // 
            btnConfirmAdminSalary.Location = new Point(105, 199);
            btnConfirmAdminSalary.Name = "btnConfirmAdminSalary";
            btnConfirmAdminSalary.Size = new Size(257, 75);
            btnConfirmAdminSalary.TabIndex = 54;
            btnConfirmAdminSalary.Text = "Update";
            btnConfirmAdminSalary.UseVisualStyleBackColor = true;
            btnConfirmAdminSalary.Click += btnConfirmAdminSalary_Click;
            // 
            // txtAdminSalary
            // 
            txtAdminSalary.Location = new Point(170, 118);
            txtAdminSalary.Name = "txtAdminSalary";
            txtAdminSalary.Size = new Size(192, 31);
            txtAdminSalary.TabIndex = 53;
            // 
            // lblAddSalaryTeacherAllowances
            // 
            lblAddSalaryTeacherAllowances.AutoSize = true;
            lblAddSalaryTeacherAllowances.Location = new Point(105, 121);
            lblAddSalaryTeacherAllowances.Name = "lblAddSalaryTeacherAllowances";
            lblAddSalaryTeacherAllowances.Size = new Size(63, 25);
            lblAddSalaryTeacherAllowances.TabIndex = 51;
            lblAddSalaryTeacherAllowances.Text = "Salary:";
            // 
            // lblSalaryAdmin
            // 
            lblSalaryAdmin.AutoSize = true;
            lblSalaryAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalaryAdmin.Location = new Point(157, 32);
            lblSalaryAdmin.Name = "lblSalaryAdmin";
            lblSalaryAdmin.Size = new Size(127, 32);
            lblSalaryAdmin.TabIndex = 52;
            lblSalaryAdmin.Text = "My Salary";
            // 
            // SalaryAdminDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 342);
            Controls.Add(btnConfirmAdminSalary);
            Controls.Add(txtAdminSalary);
            Controls.Add(lblAddSalaryTeacherAllowances);
            Controls.Add(lblSalaryAdmin);
            Name = "SalaryAdminDetails";
            Text = "SalaryAdminDetails";
            Load += SalaryAdminDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirmAdminSalary;
        private TextBox txtAdminSalary;
        private Label lblAddSalaryTeacherAllowances;
        private Label lblSalaryAdmin;
    }
}