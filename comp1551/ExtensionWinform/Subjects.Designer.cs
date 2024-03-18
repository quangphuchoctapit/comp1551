namespace comp1551.ExtensionWinform
{
    partial class Subjects
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
            lblCurrentSubject1 = new Label();
            txtCurrentSubject1 = new TextBox();
            txtCurrentSubject2 = new TextBox();
            lblCurrentSubject2 = new Label();
            txtPrevSubject2 = new TextBox();
            lblPrevSubject2 = new Label();
            txtPrevSubject1 = new TextBox();
            lblPrevSubject1 = new Label();
            txtSubject2 = new TextBox();
            lblSubject2 = new Label();
            txtSubject1 = new TextBox();
            lblSubject1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(293, 47);
            label1.Name = "label1";
            label1.Size = new Size(199, 38);
            label1.TabIndex = 0;
            label1.Text = "MY SUBJECTS";
            // 
            // lblCurrentSubject1
            // 
            lblCurrentSubject1.AutoSize = true;
            lblCurrentSubject1.Location = new Point(63, 138);
            lblCurrentSubject1.Name = "lblCurrentSubject1";
            lblCurrentSubject1.Size = new Size(152, 25);
            lblCurrentSubject1.TabIndex = 1;
            lblCurrentSubject1.Text = "Current Subject 1:";
            // 
            // txtCurrentSubject1
            // 
            txtCurrentSubject1.Location = new Point(221, 135);
            txtCurrentSubject1.Name = "txtCurrentSubject1";
            txtCurrentSubject1.Size = new Size(150, 31);
            txtCurrentSubject1.TabIndex = 2;
            // 
            // txtCurrentSubject2
            // 
            txtCurrentSubject2.Location = new Point(577, 135);
            txtCurrentSubject2.Name = "txtCurrentSubject2";
            txtCurrentSubject2.Size = new Size(150, 31);
            txtCurrentSubject2.TabIndex = 4;
            // 
            // lblCurrentSubject2
            // 
            lblCurrentSubject2.AutoSize = true;
            lblCurrentSubject2.Location = new Point(419, 138);
            lblCurrentSubject2.Name = "lblCurrentSubject2";
            lblCurrentSubject2.Size = new Size(152, 25);
            lblCurrentSubject2.TabIndex = 3;
            lblCurrentSubject2.Text = "Current Subject 2:";
            // 
            // txtPrevSubject2
            // 
            txtPrevSubject2.Location = new Point(577, 209);
            txtPrevSubject2.Name = "txtPrevSubject2";
            txtPrevSubject2.Size = new Size(150, 31);
            txtPrevSubject2.TabIndex = 8;
            // 
            // lblPrevSubject2
            // 
            lblPrevSubject2.AutoSize = true;
            lblPrevSubject2.Location = new Point(405, 212);
            lblPrevSubject2.Name = "lblPrevSubject2";
            lblPrevSubject2.Size = new Size(161, 25);
            lblPrevSubject2.TabIndex = 7;
            lblPrevSubject2.Text = "Previous Subject 2:";
            // 
            // txtPrevSubject1
            // 
            txtPrevSubject1.Location = new Point(221, 209);
            txtPrevSubject1.Name = "txtPrevSubject1";
            txtPrevSubject1.Size = new Size(150, 31);
            txtPrevSubject1.TabIndex = 6;
            // 
            // lblPrevSubject1
            // 
            lblPrevSubject1.AutoSize = true;
            lblPrevSubject1.Location = new Point(63, 212);
            lblPrevSubject1.Name = "lblPrevSubject1";
            lblPrevSubject1.Size = new Size(161, 25);
            lblPrevSubject1.TabIndex = 5;
            lblPrevSubject1.Text = "Previous Subject 1:";
            // 
            // txtSubject2
            // 
            txtSubject2.Location = new Point(577, 282);
            txtSubject2.Name = "txtSubject2";
            txtSubject2.Size = new Size(150, 31);
            txtSubject2.TabIndex = 12;
            // 
            // lblSubject2
            // 
            lblSubject2.AutoSize = true;
            lblSubject2.Location = new Point(477, 285);
            lblSubject2.Name = "lblSubject2";
            lblSubject2.Size = new Size(89, 25);
            lblSubject2.TabIndex = 11;
            lblSubject2.Text = "Subject 2:";
            // 
            // txtSubject1
            // 
            txtSubject1.Location = new Point(221, 282);
            txtSubject1.Name = "txtSubject1";
            txtSubject1.Size = new Size(150, 31);
            txtSubject1.TabIndex = 10;
            // 
            // lblSubject1
            // 
            lblSubject1.AutoSize = true;
            lblSubject1.Location = new Point(121, 282);
            lblSubject1.Name = "lblSubject1";
            lblSubject1.Size = new Size(89, 25);
            lblSubject1.TabIndex = 9;
            lblSubject1.Text = "Subject 1:";
            // 
            // Subjects
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 396);
            Controls.Add(txtSubject2);
            Controls.Add(lblSubject2);
            Controls.Add(txtSubject1);
            Controls.Add(lblSubject1);
            Controls.Add(txtPrevSubject2);
            Controls.Add(lblPrevSubject2);
            Controls.Add(txtPrevSubject1);
            Controls.Add(lblPrevSubject1);
            Controls.Add(txtCurrentSubject2);
            Controls.Add(lblCurrentSubject2);
            Controls.Add(txtCurrentSubject1);
            Controls.Add(lblCurrentSubject1);
            Controls.Add(label1);
            Name = "Subjects";
            Text = "Subjects";
            Load += Subjects_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblCurrentSubject1;
        private TextBox txtCurrentSubject1;
        private TextBox txtCurrentSubject2;
        private Label lblCurrentSubject2;
        private TextBox txtPrevSubject2;
        private Label lblPrevSubject2;
        private TextBox txtPrevSubject1;
        private Label lblPrevSubject1;
        private TextBox txtSubject2;
        private Label lblSubject2;
        private TextBox txtSubject1;
        private Label lblSubject1;
    }
}