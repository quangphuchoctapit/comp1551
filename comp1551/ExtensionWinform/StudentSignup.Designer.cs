namespace comp1551.ExtensionWinform
{
    partial class StudentSignup
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
            label3 = new Label();
            txtGrade = new TextBox();
            label4 = new Label();
            btnConfirm = new Button();
            listboxFaculties = new ListBox();
            listBoxClassName = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(218, 37);
            label1.Name = "label1";
            label1.Size = new Size(218, 38);
            label1.TabIndex = 0;
            label1.Text = "Student Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 128);
            label2.Name = "label2";
            label2.Size = new Size(70, 25);
            label2.TabIndex = 1;
            label2.Text = "Faculty:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(454, 128);
            label3.Name = "label3";
            label3.Size = new Size(56, 25);
            label3.TabIndex = 3;
            label3.Text = "Class:";
            // 
            // txtGrade
            // 
            txtGrade.Location = new Point(142, 305);
            txtGrade.Name = "txtGrade";
            txtGrade.Size = new Size(150, 31);
            txtGrade.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 305);
            label4.Name = "label4";
            label4.Size = new Size(63, 25);
            label4.TabIndex = 5;
            label4.Text = "Grade:";
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(532, 305);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(185, 67);
            btnConfirm.TabIndex = 7;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // listboxFaculties
            // 
            listboxFaculties.FormattingEnabled = true;
            listboxFaculties.ItemHeight = 25;
            listboxFaculties.Location = new Point(125, 128);
            listboxFaculties.Name = "listboxFaculties";
            listboxFaculties.Size = new Size(255, 129);
            listboxFaculties.TabIndex = 46;
            // 
            // listBoxClassName
            // 
            listBoxClassName.FormattingEnabled = true;
            listBoxClassName.ItemHeight = 25;
            listBoxClassName.Location = new Point(548, 128);
            listBoxClassName.Name = "listBoxClassName";
            listBoxClassName.Size = new Size(169, 129);
            listBoxClassName.TabIndex = 47;
            // 
            // StudentSignup
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 402);
            Controls.Add(listBoxClassName);
            Controls.Add(listboxFaculties);
            Controls.Add(btnConfirm);
            Controls.Add(txtGrade);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "StudentSignup";
            Text = "StudentSignup";
            Load += StudentSignup_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtGrade;
        private Label label4;
        private Button btnConfirm;
        private ListBox listboxFaculties;
        private ListBox listBoxClassName;
    }
}