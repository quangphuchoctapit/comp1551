namespace comp1551.ExtensionWinform
{
    partial class TeacherSignup
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
            listboxFaculties = new ListBox();
            btnConfirm = new Button();
            lblQualifications = new Label();
            label2 = new Label();
            lblTeacherSignup = new Label();
            txtQualifications = new TextBox();
            label1 = new Label();
            label4 = new Label();
            txtSubject1 = new TextBox();
            txtSubject2 = new TextBox();
            SuspendLayout();
            // 
            // listboxFaculties
            // 
            listboxFaculties.FormattingEnabled = true;
            listboxFaculties.ItemHeight = 25;
            listboxFaculties.Location = new Point(171, 141);
            listboxFaculties.Name = "listboxFaculties";
            listboxFaculties.Size = new Size(255, 129);
            listboxFaculties.TabIndex = 54;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(95, 443);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(331, 67);
            btnConfirm.TabIndex = 53;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // lblQualifications
            // 
            lblQualifications.AutoSize = true;
            lblQualifications.Location = new Point(42, 318);
            lblQualifications.Name = "lblQualifications";
            lblQualifications.Size = new Size(123, 25);
            lblQualifications.TabIndex = 51;
            lblQualifications.Text = "Qualifications:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 141);
            label2.Name = "label2";
            label2.Size = new Size(70, 25);
            label2.TabIndex = 49;
            label2.Text = "Faculty:";
            // 
            // lblTeacherSignup
            // 
            lblTeacherSignup.AutoSize = true;
            lblTeacherSignup.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTeacherSignup.Location = new Point(183, 55);
            lblTeacherSignup.Name = "lblTeacherSignup";
            lblTeacherSignup.Size = new Size(214, 38);
            lblTeacherSignup.TabIndex = 48;
            lblTeacherSignup.Text = "Teacher Details";
            // 
            // txtQualifications
            // 
            txtQualifications.Location = new Point(171, 315);
            txtQualifications.Multiline = true;
            txtQualifications.Name = "txtQualifications";
            txtQualifications.Size = new Size(255, 83);
            txtQualifications.TabIndex = 55;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(453, 141);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 56;
            label1.Text = "Subject 1:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(453, 245);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 57;
            label4.Text = "Subject 2:";
            // 
            // txtSubject1
            // 
            txtSubject1.Location = new Point(582, 141);
            txtSubject1.Name = "txtSubject1";
            txtSubject1.Size = new Size(150, 31);
            txtSubject1.TabIndex = 58;
            // 
            // txtSubject2
            // 
            txtSubject2.Location = new Point(582, 239);
            txtSubject2.Name = "txtSubject2";
            txtSubject2.Size = new Size(150, 31);
            txtSubject2.TabIndex = 59;
            // 
            // TeacherSignup
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 536);
            Controls.Add(txtSubject2);
            Controls.Add(txtSubject1);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(txtQualifications);
            Controls.Add(listboxFaculties);
            Controls.Add(btnConfirm);
            Controls.Add(lblQualifications);
            Controls.Add(label2);
            Controls.Add(lblTeacherSignup);
            Name = "TeacherSignup";
            Text = "TeacherSignup";
            Load += TeacherSignup_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxClassName;
        private ListBox listboxFaculties;
        private Button btnConfirm;
        private TextBox txtGrade;
        private Label lblQualifications;
        private Label label3;
        private Label label2;
        private Label lblTeacherSignup;
        private TextBox txtQualifications;
        private Label label1;
        private Label label4;
        private TextBox txtSubject1;
        private TextBox txtSubject2;
    }
}