namespace comp1551.Account
{
    partial class AccountDetails
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
            txtAccountRole = new TextBox();
            label3 = new Label();
            txtAccountName = new TextBox();
            label4 = new Label();
            txtAccountId = new TextBox();
            label5 = new Label();
            txtAccountEmail = new TextBox();
            label6 = new Label();
            txtAccountTelephone = new TextBox();
            label7 = new Label();
            txtAccountPassword = new TextBox();
            btnEditAccount = new Button();
            linkLblAccountUpload = new LinkLabel();
            lblAccountAvatar = new Label();
            pictureboxAccount = new PictureBox();
            txtAccountSalary = new TextBox();
            label8 = new Label();
            label9 = new Label();
            txtAccountWorkingHours = new TextBox();
            label10 = new Label();
            comboBoxAccountFullTime = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureboxAccount).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(334, 40);
            label1.Name = "label1";
            label1.Size = new Size(152, 32);
            label1.TabIndex = 0;
            label1.Text = "My Account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 97);
            label2.Name = "label2";
            label2.Size = new Size(55, 25);
            label2.TabIndex = 1;
            label2.Text = "Role: ";
            // 
            // txtAccountRole
            // 
            txtAccountRole.Enabled = false;
            txtAccountRole.Location = new Point(188, 91);
            txtAccountRole.Name = "txtAccountRole";
            txtAccountRole.Size = new Size(150, 31);
            txtAccountRole.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(458, 94);
            label3.Name = "label3";
            label3.Size = new Size(68, 25);
            label3.TabIndex = 1;
            label3.Text = "Name: ";
            // 
            // txtAccountName
            // 
            txtAccountName.Location = new Point(532, 91);
            txtAccountName.Name = "txtAccountName";
            txtAccountName.Size = new Size(150, 31);
            txtAccountName.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(127, 151);
            label4.Name = "label4";
            label4.Size = new Size(39, 25);
            label4.TabIndex = 1;
            label4.Text = "ID: ";
            // 
            // txtAccountId
            // 
            txtAccountId.Enabled = false;
            txtAccountId.Location = new Point(188, 148);
            txtAccountId.Name = "txtAccountId";
            txtAccountId.Size = new Size(150, 31);
            txtAccountId.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(458, 154);
            label5.Name = "label5";
            label5.Size = new Size(58, 25);
            label5.TabIndex = 1;
            label5.Text = "Email:";
            // 
            // txtAccountEmail
            // 
            txtAccountEmail.Location = new Point(532, 151);
            txtAccountEmail.Name = "txtAccountEmail";
            txtAccountEmail.Size = new Size(150, 31);
            txtAccountEmail.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(65, 212);
            label6.Name = "label6";
            label6.Size = new Size(101, 25);
            label6.TabIndex = 1;
            label6.Text = "Telephone: ";
            // 
            // txtAccountTelephone
            // 
            txtAccountTelephone.Location = new Point(188, 209);
            txtAccountTelephone.Name = "txtAccountTelephone";
            txtAccountTelephone.Size = new Size(150, 31);
            txtAccountTelephone.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(425, 212);
            label7.Name = "label7";
            label7.Size = new Size(91, 25);
            label7.TabIndex = 1;
            label7.Text = "Password:";
            // 
            // txtAccountPassword
            // 
            txtAccountPassword.Location = new Point(532, 209);
            txtAccountPassword.Name = "txtAccountPassword";
            txtAccountPassword.Size = new Size(150, 31);
            txtAccountPassword.TabIndex = 2;
            // 
            // btnEditAccount
            // 
            btnEditAccount.Location = new Point(499, 408);
            btnEditAccount.Name = "btnEditAccount";
            btnEditAccount.Size = new Size(183, 64);
            btnEditAccount.TabIndex = 3;
            btnEditAccount.Text = "EDIT";
            btnEditAccount.UseVisualStyleBackColor = true;
            btnEditAccount.Click += btnEditAccount_Click;
            // 
            // linkLblAccountUpload
            // 
            linkLblAccountUpload.AutoSize = true;
            linkLblAccountUpload.Location = new Point(94, 393);
            linkLblAccountUpload.Name = "linkLblAccountUpload";
            linkLblAccountUpload.Size = new Size(70, 25);
            linkLblAccountUpload.TabIndex = 16;
            linkLblAccountUpload.TabStop = true;
            linkLblAccountUpload.Text = "Upload";
            linkLblAccountUpload.LinkClicked += linkLblAccountUpload_LinkClicked;
            // 
            // lblAccountAvatar
            // 
            lblAccountAvatar.AutoSize = true;
            lblAccountAvatar.Location = new Point(94, 356);
            lblAccountAvatar.Name = "lblAccountAvatar";
            lblAccountAvatar.Size = new Size(72, 25);
            lblAccountAvatar.TabIndex = 15;
            lblAccountAvatar.Text = "Avatar: ";
            // 
            // pictureboxAccount
            // 
            pictureboxAccount.BorderStyle = BorderStyle.Fixed3D;
            pictureboxAccount.Location = new Point(188, 336);
            pictureboxAccount.Name = "pictureboxAccount";
            pictureboxAccount.Size = new Size(150, 136);
            pictureboxAccount.TabIndex = 14;
            pictureboxAccount.TabStop = false;
            // 
            // txtAccountSalary
            // 
            txtAccountSalary.Location = new Point(532, 273);
            txtAccountSalary.Name = "txtAccountSalary";
            txtAccountSalary.Size = new Size(150, 31);
            txtAccountSalary.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(453, 273);
            label8.Name = "label8";
            label8.Size = new Size(63, 25);
            label8.TabIndex = 17;
            label8.Text = "Salary:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(81, 276);
            label9.Name = "label9";
            label9.Size = new Size(90, 25);
            label9.TabIndex = 19;
            label9.Text = "Full Time?";
            // 
            // txtAccountWorkingHours
            // 
            txtAccountWorkingHours.Location = new Point(532, 336);
            txtAccountWorkingHours.Name = "txtAccountWorkingHours";
            txtAccountWorkingHours.Size = new Size(150, 31);
            txtAccountWorkingHours.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(380, 336);
            label10.Name = "label10";
            label10.Size = new Size(136, 25);
            label10.TabIndex = 21;
            label10.Text = "Working Hours:";
            // 
            // comboBoxAccountFullTime
            // 
            comboBoxAccountFullTime.FormattingEnabled = true;
            comboBoxAccountFullTime.Items.AddRange(new object[] { "Yes", "No" });
            comboBoxAccountFullTime.Location = new Point(188, 276);
            comboBoxAccountFullTime.Name = "comboBoxAccountFullTime";
            comboBoxAccountFullTime.Size = new Size(150, 33);
            comboBoxAccountFullTime.TabIndex = 23;
            // 
            // AccountDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 551);
            ControlBox = false;
            Controls.Add(comboBoxAccountFullTime);
            Controls.Add(txtAccountWorkingHours);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtAccountSalary);
            Controls.Add(label8);
            Controls.Add(linkLblAccountUpload);
            Controls.Add(lblAccountAvatar);
            Controls.Add(pictureboxAccount);
            Controls.Add(btnEditAccount);
            Controls.Add(txtAccountName);
            Controls.Add(label3);
            Controls.Add(txtAccountPassword);
            Controls.Add(label7);
            Controls.Add(txtAccountEmail);
            Controls.Add(label5);
            Controls.Add(txtAccountTelephone);
            Controls.Add(label6);
            Controls.Add(txtAccountId);
            Controls.Add(label4);
            Controls.Add(txtAccountRole);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AccountDetails";
            Text = "AccountDetails";
            Load += AccountDetails_Load;
            ((System.ComponentModel.ISupportInitialize)pictureboxAccount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtAccountRole;
        private Label label3;
        private TextBox txtAccountName;
        private Label label4;
        private TextBox txtAccountId;
        private Label label5;
        private TextBox txtAccountEmail;
        private Label label6;
        private TextBox txtAccountTelephone;
        private Label label7;
        private TextBox txtAccountPassword;
        private Button btnEditAccount;
        private LinkLabel linkLblAccountUpload;
        private Label lblAccountAvatar;
        private PictureBox pictureboxAccount;
        private TextBox txtAccountSalary;
        private Label label8;
        private Label label9;
        private TextBox txtAccountWorkingHours;
        private Label label10;
        private ComboBox comboBoxAccountFullTime;
    }
}