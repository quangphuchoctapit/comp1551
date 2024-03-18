namespace comp1551.Faculty
{
    partial class FacultyDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacultyDetails));
            tableFaculty = new DataGridView();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnSearchFaculty = new Button();
            txtSearchFaculty = new TextBox();
            lblSearchFaculty = new Label();
            btnDeleteFaculty = new Button();
            btnEditFaculty = new Button();
            btnAddFaculty = new Button();
            ((System.ComponentModel.ISupportInitialize)tableFaculty).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableFaculty
            // 
            tableFaculty.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableFaculty.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tableFaculty.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableFaculty.Dock = DockStyle.Bottom;
            tableFaculty.Location = new Point(0, 125);
            tableFaculty.Name = "tableFaculty";
            tableFaculty.RowHeadersWidth = 62;
            tableFaculty.Size = new Size(896, 325);
            tableFaculty.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnSearchFaculty);
            panel1.Controls.Add(txtSearchFaculty);
            panel1.Controls.Add(lblSearchFaculty);
            panel1.Controls.Add(btnDeleteFaculty);
            panel1.Controls.Add(btnEditFaculty);
            panel1.Controls.Add(btnAddFaculty);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(896, 98);
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
            // btnSearchFaculty
            // 
            btnSearchFaculty.Location = new Point(829, 33);
            btnSearchFaculty.Name = "btnSearchFaculty";
            btnSearchFaculty.Size = new Size(40, 40);
            btnSearchFaculty.TabIndex = 3;
            btnSearchFaculty.UseVisualStyleBackColor = true;
            btnSearchFaculty.Click += btnSearchFaculty_Click;
            // 
            // txtSearchFaculty
            // 
            txtSearchFaculty.Location = new Point(629, 35);
            txtSearchFaculty.Name = "txtSearchFaculty";
            txtSearchFaculty.Size = new Size(182, 31);
            txtSearchFaculty.TabIndex = 2;
            // 
            // lblSearchFaculty
            // 
            lblSearchFaculty.AutoSize = true;
            lblSearchFaculty.Location = new Point(496, 38);
            lblSearchFaculty.Name = "lblSearchFaculty";
            lblSearchFaculty.Size = new Size(127, 25);
            lblSearchFaculty.TabIndex = 1;
            lblSearchFaculty.Text = "Search Faculty:";
            // 
            // btnDeleteFaculty
            // 
            btnDeleteFaculty.Location = new Point(339, 12);
            btnDeleteFaculty.Name = "btnDeleteFaculty";
            btnDeleteFaculty.Size = new Size(140, 70);
            btnDeleteFaculty.TabIndex = 0;
            btnDeleteFaculty.Text = "Delete Faculty";
            btnDeleteFaculty.UseVisualStyleBackColor = true;
            btnDeleteFaculty.Click += btnDeleteFaculty_Click;
            // 
            // btnEditFaculty
            // 
            btnEditFaculty.Location = new Point(175, 12);
            btnEditFaculty.Name = "btnEditFaculty";
            btnEditFaculty.Size = new Size(140, 70);
            btnEditFaculty.TabIndex = 0;
            btnEditFaculty.Text = "Edit Faculty";
            btnEditFaculty.UseVisualStyleBackColor = true;
            btnEditFaculty.Click += btnEditFaculty_Click;
            // 
            // btnAddFaculty
            // 
            btnAddFaculty.Location = new Point(12, 12);
            btnAddFaculty.Name = "btnAddFaculty";
            btnAddFaculty.Size = new Size(140, 70);
            btnAddFaculty.TabIndex = 0;
            btnAddFaculty.Text = "Add Faculty";
            btnAddFaculty.UseVisualStyleBackColor = true;
            btnAddFaculty.Click += btnAddFaculty_Click;
            // 
            // FacultyDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 450);
            Controls.Add(tableFaculty);
            Controls.Add(panel1);
            Name = "FacultyDetails";
            Text = "FacultyDetails";
            Load += FacultyDetails_Load;
            ((System.ComponentModel.ISupportInitialize)tableFaculty).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tableFaculty;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnSearchFaculty;
        private TextBox txtSearchFaculty;
        private Label lblSearchFaculty;
        private Button btnDeleteFaculty;
        private Button btnEditFaculty;
        private Button btnAddFaculty;
    }
}