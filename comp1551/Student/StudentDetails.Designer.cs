namespace comp1551.Student
{
    partial class StudentDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentDetails));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnSearchStudent = new Button();
            txtSearchStudent = new TextBox();
            lblSearchClass = new Label();
            btnDeleteStudent = new Button();
            btnEditStudent = new Button();
            btnAddStudent = new Button();
            tableStudent = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tableStudent).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnSearchStudent);
            panel1.Controls.Add(txtSearchStudent);
            panel1.Controls.Add(lblSearchClass);
            panel1.Controls.Add(btnDeleteStudent);
            panel1.Controls.Add(btnEditStudent);
            panel1.Controls.Add(btnAddStudent);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1094, 98);
            panel1.TabIndex = 3;
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
            // btnSearchStudent
            // 
            btnSearchStudent.Location = new Point(829, 33);
            btnSearchStudent.Name = "btnSearchStudent";
            btnSearchStudent.Size = new Size(40, 40);
            btnSearchStudent.TabIndex = 3;
            btnSearchStudent.UseVisualStyleBackColor = true;
            btnSearchStudent.Click += btnSearchStudent_Click;
            // 
            // txtSearchStudent
            // 
            txtSearchStudent.Location = new Point(650, 35);
            txtSearchStudent.Name = "txtSearchStudent";
            txtSearchStudent.Size = new Size(161, 31);
            txtSearchStudent.TabIndex = 2;
            // 
            // lblSearchClass
            // 
            lblSearchClass.AutoSize = true;
            lblSearchClass.Location = new Point(510, 38);
            lblSearchClass.Name = "lblSearchClass";
            lblSearchClass.Size = new Size(134, 25);
            lblSearchClass.TabIndex = 1;
            lblSearchClass.Text = "Search Student:";
            // 
            // btnDeleteStudent
            // 
            btnDeleteStudent.Location = new Point(339, 12);
            btnDeleteStudent.Name = "btnDeleteStudent";
            btnDeleteStudent.Size = new Size(140, 70);
            btnDeleteStudent.TabIndex = 0;
            btnDeleteStudent.Text = "Delete Student";
            btnDeleteStudent.UseVisualStyleBackColor = true;
            btnDeleteStudent.Click += btnDeleteStudent_Click;
            // 
            // btnEditStudent
            // 
            btnEditStudent.Location = new Point(175, 12);
            btnEditStudent.Name = "btnEditStudent";
            btnEditStudent.Size = new Size(140, 70);
            btnEditStudent.TabIndex = 0;
            btnEditStudent.Text = "Edit Student";
            btnEditStudent.UseVisualStyleBackColor = true;
            btnEditStudent.Click += btnEditStudent_Click;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(12, 12);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(140, 70);
            btnAddStudent.TabIndex = 0;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // tableStudent
            // 
            tableStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableStudent.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tableStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableStudent.Dock = DockStyle.Bottom;
            tableStudent.Location = new Point(0, 125);
            tableStudent.Name = "tableStudent";
            tableStudent.RowHeadersWidth = 62;
            tableStudent.Size = new Size(1094, 325);
            tableStudent.TabIndex = 2;
            // 
            // StudentDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 450);
            Controls.Add(panel1);
            Controls.Add(tableStudent);
            Name = "StudentDetails";
            Text = "StudentDetails";
            Load += StudentDetails_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tableStudent).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnSearchStudent;
        private TextBox txtSearchStudent;
        private Label lblSearchClass;
        private Button btnDeleteStudent;
        private Button btnEditStudent;
        private Button btnAddStudent;
        private DataGridView tableStudent;
    }
}