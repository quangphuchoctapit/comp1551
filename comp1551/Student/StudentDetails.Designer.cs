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
            btnSearchStudent = new Button();
            txtSearchStudent = new TextBox();
            lblSearchClass = new Label();
            btnDeleteStudent = new Button();
            btnEditStudent = new Button();
            btnAddStudent = new Button();
            tableStudent = new DataGridView();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableStudent).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSearchStudent);
            panel1.Controls.Add(txtSearchStudent);
            panel1.Controls.Add(lblSearchClass);
            panel1.Controls.Add(btnDeleteStudent);
            panel1.Controls.Add(btnEditStudent);
            panel1.Controls.Add(btnAddStudent);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // btnSearchStudent
            // 
            resources.ApplyResources(btnSearchStudent, "btnSearchStudent");
            btnSearchStudent.Name = "btnSearchStudent";
            btnSearchStudent.UseVisualStyleBackColor = true;
            btnSearchStudent.Click += btnSearchStudent_Click;
            // 
            // txtSearchStudent
            // 
            resources.ApplyResources(txtSearchStudent, "txtSearchStudent");
            txtSearchStudent.Name = "txtSearchStudent";
            // 
            // lblSearchClass
            // 
            resources.ApplyResources(lblSearchClass, "lblSearchClass");
            lblSearchClass.Name = "lblSearchClass";
            // 
            // btnDeleteStudent
            // 
            resources.ApplyResources(btnDeleteStudent, "btnDeleteStudent");
            btnDeleteStudent.Name = "btnDeleteStudent";
            btnDeleteStudent.UseVisualStyleBackColor = true;
            btnDeleteStudent.Click += btnDeleteStudent_Click;
            // 
            // btnEditStudent
            // 
            resources.ApplyResources(btnEditStudent, "btnEditStudent");
            btnEditStudent.Name = "btnEditStudent";
            btnEditStudent.UseVisualStyleBackColor = true;
            btnEditStudent.Click += btnEditStudent_Click;
            // 
            // btnAddStudent
            // 
            resources.ApplyResources(btnAddStudent, "btnAddStudent");
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // tableStudent
            // 
            tableStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableStudent.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tableStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(tableStudent, "tableStudent");
            tableStudent.Name = "tableStudent";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // StudentDetails
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(tableStudent);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentDetails";
            Load += StudentDetails_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tableStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnSearchStudent;
        private TextBox txtSearchStudent;
        private Label lblSearchClass;
        private Button btnDeleteStudent;
        private Button btnEditStudent;
        private Button btnAddStudent;
        private DataGridView tableStudent;
        private Label label1;
    }
}