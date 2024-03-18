namespace comp1551.Subject
{
    partial class AddSubject
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
            btnAddSubject = new Button();
            txtAddSubjectSubjectId = new TextBox();
            txtAddSubjectName = new TextBox();
            lblAddSubjectSubjectId = new Label();
            lblAddSubject = new Label();
            lblAddSubjectName = new Label();
            label1 = new Label();
            txtAddSubjectDescription = new TextBox();
            SuspendLayout();
            // 
            // btnAddSubject
            // 
            btnAddSubject.Location = new Point(353, 237);
            btnAddSubject.Name = "btnAddSubject";
            btnAddSubject.Size = new Size(282, 87);
            btnAddSubject.TabIndex = 23;
            btnAddSubject.Text = "Add";
            btnAddSubject.UseVisualStyleBackColor = true;
            btnAddSubject.Click += btnAddSubject_Click;
            // 
            // txtAddSubjectSubjectId
            // 
            txtAddSubjectSubjectId.Location = new Point(488, 110);
            txtAddSubjectSubjectId.Name = "txtAddSubjectSubjectId";
            txtAddSubjectSubjectId.Size = new Size(147, 31);
            txtAddSubjectSubjectId.TabIndex = 21;
            // 
            // txtAddSubjectName
            // 
            txtAddSubjectName.Location = new Point(169, 110);
            txtAddSubjectName.Name = "txtAddSubjectName";
            txtAddSubjectName.Size = new Size(147, 31);
            txtAddSubjectName.TabIndex = 22;
            // 
            // lblAddSubjectSubjectId
            // 
            lblAddSubjectSubjectId.AutoSize = true;
            lblAddSubjectSubjectId.Location = new Point(372, 113);
            lblAddSubjectSubjectId.Name = "lblAddSubjectSubjectId";
            lblAddSubjectSubjectId.Size = new Size(97, 25);
            lblAddSubjectSubjectId.TabIndex = 16;
            lblAddSubjectSubjectId.Text = "Subject ID:";
            // 
            // lblAddSubject
            // 
            lblAddSubject.AutoSize = true;
            lblAddSubject.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddSubject.Location = new Point(250, 26);
            lblAddSubject.Name = "lblAddSubject";
            lblAddSubject.Size = new Size(210, 32);
            lblAddSubject.TabIndex = 17;
            lblAddSubject.Text = "Add New Subject\r\n";
            // 
            // lblAddSubjectName
            // 
            lblAddSubjectName.AutoSize = true;
            lblAddSubjectName.Location = new Point(82, 113);
            lblAddSubjectName.Name = "lblAddSubjectName";
            lblAddSubjectName.Size = new Size(68, 25);
            lblAddSubjectName.TabIndex = 18;
            lblAddSubjectName.Text = "Name: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 178);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 24;
            label1.Text = "Description:";
            // 
            // txtAddSubjectDescription
            // 
            txtAddSubjectDescription.Location = new Point(169, 178);
            txtAddSubjectDescription.Multiline = true;
            txtAddSubjectDescription.Name = "txtAddSubjectDescription";
            txtAddSubjectDescription.Size = new Size(147, 146);
            txtAddSubjectDescription.TabIndex = 35;
            // 
            // AddSubject
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 393);
            Controls.Add(txtAddSubjectDescription);
            Controls.Add(label1);
            Controls.Add(btnAddSubject);
            Controls.Add(txtAddSubjectSubjectId);
            Controls.Add(txtAddSubjectName);
            Controls.Add(lblAddSubjectSubjectId);
            Controls.Add(lblAddSubject);
            Controls.Add(lblAddSubjectName);
            Name = "AddSubject";
            Text = "AddSubject";
            Load += AddSubject_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddSubject;
        private TextBox txtAddSubjectSubjectId;
        private TextBox txtAddSubjectName;
        private Label lblAddSubjectSubjectId;
        private Label lblAddSubject;
        private Label lblAddSubjectName;
        private Label label1;
        private TextBox txtAddSubjectDescription;
    }
}