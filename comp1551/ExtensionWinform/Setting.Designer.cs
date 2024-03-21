namespace comp1551.ExtensionWinform
{
    partial class Setting
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
            btnAccount = new Button();
            btnSubject = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(319, 22);
            label1.Name = "label1";
            label1.Size = new Size(132, 38);
            label1.TabIndex = 0;
            label1.Text = "SETTING";
            // 
            // btnAccount
            // 
            btnAccount.Location = new Point(187, 75);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(400, 100);
            btnAccount.TabIndex = 1;
            btnAccount.Text = "Account";
            btnAccount.UseVisualStyleBackColor = true;
            btnAccount.Click += btnAccount_Click;
            // 
            // btnSubject
            // 
            btnSubject.Location = new Point(187, 204);
            btnSubject.Name = "btnSubject";
            btnSubject.Size = new Size(400, 100);
            btnSubject.TabIndex = 2;
            btnSubject.Text = "My Subjects";
            btnSubject.UseVisualStyleBackColor = true;
            btnSubject.Click += btnSubject_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(187, 332);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(400, 100);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // Setting
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 450);
            ControlBox = false;
            Controls.Add(btnLogout);
            Controls.Add(btnSubject);
            Controls.Add(btnAccount);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Setting";
            Text = "Setting";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAccount;
        private Button btnSubject;
        private Button btnLogout;
    }
}