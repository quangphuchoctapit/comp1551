namespace comp1551.Class
{
    partial class ClassDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassDetails));
            tableClass = new DataGridView();
            panel1 = new Panel();
            btnSearchClass = new Button();
            txtSearchClass = new TextBox();
            lblSearchClass = new Label();
            btnDeleteClass = new Button();
            btnEditClass = new Button();
            btnAddClass = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)tableClass).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableClass
            // 
            tableClass.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableClass.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tableClass.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableClass.Dock = DockStyle.Bottom;
            tableClass.Location = new Point(0, 247);
            tableClass.Name = "tableClass";
            tableClass.RowHeadersWidth = 62;
            tableClass.Size = new Size(1200, 353);
            tableClass.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSearchClass);
            panel1.Controls.Add(txtSearchClass);
            panel1.Controls.Add(lblSearchClass);
            panel1.Controls.Add(btnDeleteClass);
            panel1.Controls.Add(btnEditClass);
            panel1.Controls.Add(btnAddClass);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 116);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 131);
            panel1.TabIndex = 1;
            // 
            // btnSearchClass
            // 
            btnSearchClass.BackgroundImage = (Image)resources.GetObject("btnSearchClass.BackgroundImage");
            btnSearchClass.BackgroundImageLayout = ImageLayout.Zoom;
            btnSearchClass.Location = new Point(829, 33);
            btnSearchClass.Name = "btnSearchClass";
            btnSearchClass.Size = new Size(40, 40);
            btnSearchClass.TabIndex = 3;
            btnSearchClass.UseVisualStyleBackColor = true;
            btnSearchClass.Click += btnSearchClass_Click;
            // 
            // txtSearchClass
            // 
            txtSearchClass.Location = new Point(629, 35);
            txtSearchClass.Name = "txtSearchClass";
            txtSearchClass.Size = new Size(182, 31);
            txtSearchClass.TabIndex = 2;
            // 
            // lblSearchClass
            // 
            lblSearchClass.AutoSize = true;
            lblSearchClass.Location = new Point(510, 38);
            lblSearchClass.Name = "lblSearchClass";
            lblSearchClass.Size = new Size(113, 25);
            lblSearchClass.TabIndex = 1;
            lblSearchClass.Text = "Search Class:";
            // 
            // btnDeleteClass
            // 
            btnDeleteClass.Location = new Point(339, 12);
            btnDeleteClass.Name = "btnDeleteClass";
            btnDeleteClass.Size = new Size(140, 70);
            btnDeleteClass.TabIndex = 0;
            btnDeleteClass.Text = "Delete Class";
            btnDeleteClass.UseVisualStyleBackColor = true;
            btnDeleteClass.Click += btnDeleteClass_Click;
            // 
            // btnEditClass
            // 
            btnEditClass.Location = new Point(175, 12);
            btnEditClass.Name = "btnEditClass";
            btnEditClass.Size = new Size(140, 70);
            btnEditClass.TabIndex = 0;
            btnEditClass.Text = "Edit Class";
            btnEditClass.UseVisualStyleBackColor = true;
            btnEditClass.Click += btnEditClass_Click;
            // 
            // btnAddClass
            // 
            btnAddClass.Location = new Point(12, 12);
            btnAddClass.Name = "btnAddClass";
            btnAddClass.Size = new Size(140, 70);
            btnAddClass.TabIndex = 0;
            btnAddClass.Text = "Add Class";
            btnAddClass.UseVisualStyleBackColor = true;
            btnAddClass.Click += btnAddClass_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(546, 41);
            label1.Name = "label1";
            label1.Size = new Size(94, 45);
            label1.TabIndex = 2;
            label1.Text = "Class";
            // 
            // ClassDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 600);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(tableClass);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ClassDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClassDetails";
            Load += ClassDetails_Load;
            ((System.ComponentModel.ISupportInitialize)tableClass).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tableClass;
        private Panel panel1;
        private Button btnEditClass;
        private Button btnAddClass;
        private Button btnDeleteClass;
        private Button btnSearchClass;
        private TextBox txtSearchClass;
        private Label lblSearchClass;
        private Label label1;
    }
}