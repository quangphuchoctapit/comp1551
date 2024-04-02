namespace comp1551
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtTelephone = new TextBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            txtPassword = new TextBox();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            btnLogin = new Button();
            linkLabelSignUp = new LinkLabel();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(143, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(198, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 191);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 1;
            label1.Text = "Phone";
            // 
            // txtTelephone
            // 
            txtTelephone.BackColor = SystemColors.Control;
            txtTelephone.BorderStyle = BorderStyle.None;
            txtTelephone.Location = new Point(198, 191);
            txtTelephone.Name = "txtTelephone";
            txtTelephone.Size = new Size(197, 24);
            txtTelephone.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Location = new Point(89, 234);
            panel1.Name = "panel1";
            panel1.Size = new Size(306, 2);
            panel1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(89, 196);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(20, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(115, 285);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Control;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Location = new Point(198, 285);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(197, 24);
            txtPassword.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.IndianRed;
            panel2.Location = new Point(89, 328);
            panel2.Name = "panel2";
            panel2.Size = new Size(306, 2);
            panel2.TabIndex = 3;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(89, 290);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(20, 20);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Small Semibol", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(182, 118);
            label3.Name = "label3";
            label3.Size = new Size(109, 37);
            label3.TabIndex = 5;
            label3.Text = "LOG IN";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.IndianRed;
            btnLogin.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(89, 364);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(306, 76);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "LOG IN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // linkLabelSignUp
            // 
            linkLabelSignUp.AutoSize = true;
            linkLabelSignUp.Location = new Point(320, 473);
            linkLabelSignUp.Name = "linkLabelSignUp";
            linkLabelSignUp.Size = new Size(75, 25);
            linkLabelSignUp.TabIndex = 7;
            linkLabelSignUp.TabStop = true;
            linkLabelSignUp.Text = "Sign Up";
            linkLabelSignUp.LinkClicked += linkLabelSignUp_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(89, 473);
            label4.Name = "label4";
            label4.Size = new Size(197, 25);
            label4.TabIndex = 8;
            label4.Text = "Don't have an account?";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 532);
            Controls.Add(label4);
            Controls.Add(linkLabelSignUp);
            Controls.Add(btnLogin);
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
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtPhone;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label2;
        private TextBox txtPassword;
        private Panel panel2;
        private PictureBox pictureBox3;
        private Label label3;
        private Button btnLogin;
        private TextBox txtTelephone;
        private LinkLabel linkLabelSignUp;
        private Label label4;
    }
}