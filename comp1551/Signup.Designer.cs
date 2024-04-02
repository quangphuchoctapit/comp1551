namespace comp1551
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            label4 = new Label();
            linkLabelLogin = new LinkLabel();
            btnSignup = new Button();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            panel1 = new Panel();
            txtPassword = new TextBox();
            label2 = new Label();
            txtTelephone = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dropdownRole = new ComboBox();
            label5 = new Label();
            pictureBox4 = new PictureBox();
            panel3 = new Panel();
            txtEmail = new TextBox();
            label6 = new Label();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            panel4 = new Panel();
            txtName = new TextBox();
            lblName = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(86, 484);
            label4.Name = "label4";
            label4.Size = new Size(213, 25);
            label4.TabIndex = 21;
            label4.Text = "Already have an account?";
            // 
            // linkLabelLogin
            // 
            linkLabelLogin.AutoSize = true;
            linkLabelLogin.Location = new Point(317, 484);
            linkLabelLogin.Name = "linkLabelLogin";
            linkLabelLogin.Size = new Size(67, 25);
            linkLabelLogin.TabIndex = 20;
            linkLabelLogin.TabStop = true;
            linkLabelLogin.Text = "Sign In";
            linkLabelLogin.LinkClicked += linkLabelLogin_LinkClicked_1;
            // 
            // btnSignup
            // 
            btnSignup.BackColor = Color.IndianRed;
            btnSignup.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignup.ForeColor = Color.White;
            btnSignup.Location = new Point(522, 387);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(306, 76);
            btnSignup.TabIndex = 19;
            btnSignup.Text = "SIGN UP";
            btnSignup.UseVisualStyleBackColor = false;
            btnSignup.Click += btnSignup_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Small Semibol", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(376, 128);
            label3.Name = "label3";
            label3.Size = new Size(128, 37);
            label3.TabIndex = 18;
            label3.Text = "SIGN UP";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(86, 401);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(20, 20);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(86, 207);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(20, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.IndianRed;
            panel2.Location = new Point(86, 439);
            panel2.Name = "panel2";
            panel2.Size = new Size(306, 2);
            panel2.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Location = new Point(86, 245);
            panel1.Name = "panel1";
            panel1.Size = new Size(306, 2);
            panel1.TabIndex = 15;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Control;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Location = new Point(195, 396);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(197, 30);
            txtPassword.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 396);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 10;
            label2.Text = "Password";
            // 
            // txtTelephone
            // 
            txtTelephone.BackColor = SystemColors.Control;
            txtTelephone.BorderStyle = BorderStyle.None;
            txtTelephone.Location = new Point(195, 202);
            txtTelephone.Multiline = true;
            txtTelephone.Name = "txtTelephone";
            txtTelephone.Size = new Size(197, 30);
            txtTelephone.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 202);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 11;
            label1.Text = "Phone";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(355, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(208, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // dropdownRole
            // 
            dropdownRole.FormattingEnabled = true;
            dropdownRole.Location = new Point(646, 308);
            dropdownRole.Name = "dropdownRole";
            dropdownRole.Size = new Size(182, 33);
            dropdownRole.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(495, 316);
            label5.Name = "label5";
            label5.Size = new Size(122, 25);
            label5.TabIndex = 23;
            label5.Text = "Who are you?";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(469, 321);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(20, 20);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 27;
            pictureBox4.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.IndianRed;
            panel3.Location = new Point(522, 245);
            panel3.Name = "panel3";
            panel3.Size = new Size(306, 2);
            panel3.TabIndex = 26;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.Control;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Location = new Point(631, 202);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(197, 30);
            txtEmail.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(548, 202);
            label6.Name = "label6";
            label6.Size = new Size(54, 25);
            label6.TabIndex = 24;
            label6.Text = "Email";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(510, 207);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(20, 20);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 28;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(86, 310);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(20, 20);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 32;
            pictureBox6.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.IndianRed;
            panel4.Location = new Point(86, 348);
            panel4.Name = "panel4";
            panel4.Size = new Size(306, 2);
            panel4.TabIndex = 31;
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.Control;
            txtName.BorderStyle = BorderStyle.None;
            txtName.Location = new Point(195, 305);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(197, 30);
            txtName.TabIndex = 30;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(112, 305);
            lblName.Name = "lblName";
            lblName.Size = new Size(59, 25);
            lblName.TabIndex = 29;
            lblName.Text = "Name";
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 571);
            Controls.Add(pictureBox6);
            Controls.Add(panel4);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(panel3);
            Controls.Add(txtEmail);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dropdownRole);
            Controls.Add(label4);
            Controls.Add(linkLabelLogin);
            Controls.Add(btnSignup);
            Controls.Add(label3);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtTelephone);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Signup";
            Text = "Signup";
            Load += Signup_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private LinkLabel linkLabelLogin;
        private Button btnSignup;
        private Label label3;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Panel panel1;
        private TextBox txtPassword;
        private Label label2;
        private TextBox txtTelephone;
        private Label label1;
        private PictureBox pictureBox1;
        private ComboBox dropdownRole;
        private Label label5;
        private PictureBox pictureBox4;
        private Panel panel3;
        private TextBox txtEmail;
        private Label label6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Panel panel4;
        private TextBox txtName;
        private Label lblName;
    }
}