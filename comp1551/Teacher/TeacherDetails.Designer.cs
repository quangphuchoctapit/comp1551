namespace comp1551.Teacher
{
    partial class TeacherDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherDetails));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnSearchTeacher = new Button();
            txtSearchTeacher = new TextBox();
            lblSearchTeacher = new Label();
            btnDeleteTeacher = new Button();
            btnEditTeacher = new Button();
            btnAddTeacher = new Button();
            tableTeacher = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tableTeacher).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnSearchTeacher);
            panel1.Controls.Add(txtSearchTeacher);
            panel1.Controls.Add(lblSearchTeacher);
            panel1.Controls.Add(btnDeleteTeacher);
            panel1.Controls.Add(btnEditTeacher);
            panel1.Controls.Add(btnAddTeacher);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(985, 98);
            panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(839, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnSearchTeacher
            // 
            btnSearchTeacher.Location = new Point(829, 33);
            btnSearchTeacher.Name = "btnSearchTeacher";
            btnSearchTeacher.Size = new Size(40, 40);
            btnSearchTeacher.TabIndex = 3;
            btnSearchTeacher.UseVisualStyleBackColor = true;
            btnSearchTeacher.Click += btnSearchTeacher_Click;
            // 
            // txtSearchTeacher
            // 
            txtSearchTeacher.Location = new Point(650, 35);
            txtSearchTeacher.Name = "txtSearchTeacher";
            txtSearchTeacher.Size = new Size(161, 31);
            txtSearchTeacher.TabIndex = 2;
            // 
            // lblSearchTeacher
            // 
            lblSearchTeacher.AutoSize = true;
            lblSearchTeacher.Location = new Point(510, 38);
            lblSearchTeacher.Name = "lblSearchTeacher";
            lblSearchTeacher.Size = new Size(131, 25);
            lblSearchTeacher.TabIndex = 1;
            lblSearchTeacher.Text = "Search Teacher:";
            // 
            // btnDeleteTeacher
            // 
            btnDeleteTeacher.Location = new Point(339, 12);
            btnDeleteTeacher.Name = "btnDeleteTeacher";
            btnDeleteTeacher.Size = new Size(140, 70);
            btnDeleteTeacher.TabIndex = 0;
            btnDeleteTeacher.Text = "Delete Teacher";
            btnDeleteTeacher.UseVisualStyleBackColor = true;
            btnDeleteTeacher.Click += btnDeleteTeacher_Click;
            // 
            // btnEditTeacher
            // 
            btnEditTeacher.Location = new Point(175, 12);
            btnEditTeacher.Name = "btnEditTeacher";
            btnEditTeacher.Size = new Size(140, 70);
            btnEditTeacher.TabIndex = 0;
            btnEditTeacher.Text = "Edit Teacher";
            btnEditTeacher.UseVisualStyleBackColor = true;
            btnEditTeacher.Click += btnEditTeacher_Click;
            // 
            // btnAddTeacher
            // 
            btnAddTeacher.Location = new Point(12, 12);
            btnAddTeacher.Name = "btnAddTeacher";
            btnAddTeacher.Size = new Size(140, 70);
            btnAddTeacher.TabIndex = 0;
            btnAddTeacher.Text = "Add Teacher";
            btnAddTeacher.UseVisualStyleBackColor = true;
            btnAddTeacher.Click += btnAddTeacher_Click;
            // 
            // tableTeacher
            // 
            tableTeacher.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableTeacher.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tableTeacher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableTeacher.Dock = DockStyle.Bottom;
            tableTeacher.Location = new Point(0, 125);
            tableTeacher.Name = "tableTeacher";
            tableTeacher.RowHeadersWidth = 62;
            tableTeacher.Size = new Size(985, 325);
            tableTeacher.TabIndex = 4;
            // 
            // TeacherDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 450);
            Controls.Add(panel1);
            Controls.Add(tableTeacher);
            Name = "TeacherDetails";
            Text = "TeacherDetails";
            Load += TeacherDetails_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tableTeacher).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnSearchTeacher;
        private TextBox txtSearchTeacher;
        private Label lblSearchTeacher;
        private Button btnDeleteTeacher;
        private Button btnEditTeacher;
        private Button btnAddTeacher;
        private DataGridView tableTeacher;
    }
}