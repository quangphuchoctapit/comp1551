namespace comp1551
{
    partial class ChoosingSalaryModal
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
            label1 = new Label();
            label2 = new Label();
            btnTeacherSalary = new Button();
            btnAdminSalary = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(542, 48);
            label1.Name = "label1";
            label1.Size = new Size(123, 38);
            label1.TabIndex = 0;
            label1.Text = "SALARY";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(207, 93);
            label2.Name = "label2";
            label2.Size = new Size(147, 32);
            label2.TabIndex = 1;
            label2.Text = "Choose one:";
            // 
            // btnTeacherSalary
            // 
            btnTeacherSalary.BackColor = Color.LightGray;
            btnTeacherSalary.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTeacherSalary.Location = new Point(446, 158);
            btnTeacherSalary.Name = "btnTeacherSalary";
            btnTeacherSalary.Size = new Size(300, 100);
            btnTeacherSalary.TabIndex = 2;
            btnTeacherSalary.Text = "Teacher Salary";
            btnTeacherSalary.UseVisualStyleBackColor = false;
            btnTeacherSalary.Click += btnTeacherSalary_Click;
            // 
            // btnAdminSalary
            // 
            btnAdminSalary.BackColor = Color.LightGray;
            btnAdminSalary.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminSalary.Location = new Point(446, 309);
            btnAdminSalary.Name = "btnAdminSalary";
            btnAdminSalary.Size = new Size(300, 100);
            btnAdminSalary.TabIndex = 3;
            btnAdminSalary.Text = "Admin Salary";
            btnAdminSalary.UseVisualStyleBackColor = false;
            btnAdminSalary.Click += btnAdminSalary_Click;
            // 
            // ChoosingSalaryModal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 600);
            ControlBox = false;
            Controls.Add(btnAdminSalary);
            Controls.Add(btnTeacherSalary);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChoosingSalaryModal";
            Text = "ChoosingModal";
            Load += ChoosingSalaryModal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnTeacherSalary;
        private Button btnAdminSalary;
    }
}