namespace comp1551.Salary
{
    partial class SalaryTeacherDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalaryTeacherDetails));
            tableSalary = new DataGridView();
            panel1 = new Panel();
            btnSearchSalary = new Button();
            txtSearchSalary = new TextBox();
            lblSearchSalary = new Label();
            btnEditSalary = new Button();
            btnAddSalary = new Button();
            ((System.ComponentModel.ISupportInitialize)tableSalary).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableSalary
            // 
            tableSalary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableSalary.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tableSalary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableSalary.Dock = DockStyle.Bottom;
            tableSalary.Location = new Point(0, 125);
            tableSalary.Name = "tableSalary";
            tableSalary.RowHeadersWidth = 62;
            tableSalary.Size = new Size(735, 325);
            tableSalary.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSearchSalary);
            panel1.Controls.Add(txtSearchSalary);
            panel1.Controls.Add(lblSearchSalary);
            panel1.Controls.Add(btnEditSalary);
            panel1.Controls.Add(btnAddSalary);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(735, 98);
            panel1.TabIndex = 3;
            // 
            // btnSearchSalary
            // 
            btnSearchSalary.BackgroundImage = (Image)resources.GetObject("btnSearchSalary.BackgroundImage");
            btnSearchSalary.BackgroundImageLayout = ImageLayout.Zoom;
            btnSearchSalary.Location = new Point(670, 30);
            btnSearchSalary.Name = "btnSearchSalary";
            btnSearchSalary.Size = new Size(40, 40);
            btnSearchSalary.TabIndex = 3;
            btnSearchSalary.UseVisualStyleBackColor = true;
            // 
            // txtSearchSalary
            // 
            txtSearchSalary.Location = new Point(470, 32);
            txtSearchSalary.Name = "txtSearchSalary";
            txtSearchSalary.Size = new Size(182, 31);
            txtSearchSalary.TabIndex = 2;
            // 
            // lblSearchSalary
            // 
            lblSearchSalary.AutoSize = true;
            lblSearchSalary.Location = new Point(351, 35);
            lblSearchSalary.Name = "lblSearchSalary";
            lblSearchSalary.Size = new Size(120, 25);
            lblSearchSalary.TabIndex = 1;
            lblSearchSalary.Text = "Search Salary:";
            // 
            // btnEditSalary
            // 
            btnEditSalary.Location = new Point(175, 12);
            btnEditSalary.Name = "btnEditSalary";
            btnEditSalary.Size = new Size(140, 70);
            btnEditSalary.TabIndex = 0;
            btnEditSalary.Text = "Edit Salary";
            btnEditSalary.UseVisualStyleBackColor = true;
            btnEditSalary.Click += btnEditSalary_Click;
            // 
            // btnAddSalary
            // 
            btnAddSalary.Location = new Point(12, 12);
            btnAddSalary.Name = "btnAddSalary";
            btnAddSalary.Size = new Size(140, 70);
            btnAddSalary.TabIndex = 0;
            btnAddSalary.Text = "Add Salary";
            btnAddSalary.UseVisualStyleBackColor = true;
            btnAddSalary.Click += btnAddSalary_Click;
            // 
            // SalaryTeacherDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 450);
            Controls.Add(tableSalary);
            Controls.Add(panel1);
            Name = "SalaryTeacherDetails";
            Text = "SalaryTeacherDetails";
            Load += SalaryTeacherDetails_Load;
            ((System.ComponentModel.ISupportInitialize)tableSalary).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tableSalary;
        private Panel panel1;
        private Button btnSearchSalary;
        private TextBox txtSearchSalary;
        private Label lblSearchSalary;
        private Button btnEditSalary;
        private Button btnAddSalary;
    }
}