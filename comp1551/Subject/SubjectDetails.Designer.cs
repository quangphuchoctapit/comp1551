namespace comp1551.Subject
{
    partial class SubjectDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubjectDetails));
            panel1 = new Panel();
            btnSearchSubject = new Button();
            txtSearchSubject = new TextBox();
            lblSearchSubject = new Label();
            btnDeleteSubject = new Button();
            btnEditSubject = new Button();
            btnAddSubject = new Button();
            tableSubject = new DataGridView();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableSubject).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSearchSubject);
            panel1.Controls.Add(txtSearchSubject);
            panel1.Controls.Add(lblSearchSubject);
            panel1.Controls.Add(btnDeleteSubject);
            panel1.Controls.Add(btnEditSubject);
            panel1.Controls.Add(btnAddSubject);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(985, 98);
            panel1.TabIndex = 5;
            // 
            // btnSearchSubject
            // 
            btnSearchSubject.BackgroundImage = (Image)resources.GetObject("btnSearchSubject.BackgroundImage");
            btnSearchSubject.BackgroundImageLayout = ImageLayout.Zoom;
            btnSearchSubject.Location = new Point(829, 33);
            btnSearchSubject.Name = "btnSearchSubject";
            btnSearchSubject.Size = new Size(40, 40);
            btnSearchSubject.TabIndex = 3;
            btnSearchSubject.UseVisualStyleBackColor = true;
            btnSearchSubject.Click += btnSearchSubject_Click;
            // 
            // txtSearchSubject
            // 
            txtSearchSubject.Location = new Point(650, 35);
            txtSearchSubject.Name = "txtSearchSubject";
            txtSearchSubject.Size = new Size(161, 31);
            txtSearchSubject.TabIndex = 2;
            // 
            // lblSearchSubject
            // 
            lblSearchSubject.AutoSize = true;
            lblSearchSubject.Location = new Point(510, 38);
            lblSearchSubject.Name = "lblSearchSubject";
            lblSearchSubject.Size = new Size(131, 25);
            lblSearchSubject.TabIndex = 1;
            lblSearchSubject.Text = "Search Subject:";
            // 
            // btnDeleteSubject
            // 
            btnDeleteSubject.Location = new Point(339, 12);
            btnDeleteSubject.Name = "btnDeleteSubject";
            btnDeleteSubject.Size = new Size(140, 70);
            btnDeleteSubject.TabIndex = 0;
            btnDeleteSubject.Text = "Delete Subject";
            btnDeleteSubject.UseVisualStyleBackColor = true;
            btnDeleteSubject.Click += btnDeleteSubject_Click;
            // 
            // btnEditSubject
            // 
            btnEditSubject.Location = new Point(175, 12);
            btnEditSubject.Name = "btnEditSubject";
            btnEditSubject.Size = new Size(140, 70);
            btnEditSubject.TabIndex = 0;
            btnEditSubject.Text = "Edit Subject";
            btnEditSubject.UseVisualStyleBackColor = true;
            btnEditSubject.Click += btnEditSubject_Click;
            // 
            // btnAddSubject
            // 
            btnAddSubject.Location = new Point(12, 12);
            btnAddSubject.Name = "btnAddSubject";
            btnAddSubject.Size = new Size(140, 70);
            btnAddSubject.TabIndex = 0;
            btnAddSubject.Text = "Add Subject";
            btnAddSubject.UseVisualStyleBackColor = true;
            btnAddSubject.Click += btnAddSubject_Click;
            // 
            // tableSubject
            // 
            tableSubject.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableSubject.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tableSubject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableSubject.Dock = DockStyle.Bottom;
            tableSubject.Location = new Point(0, 164);
            tableSubject.Name = "tableSubject";
            tableSubject.RowHeadersWidth = 62;
            tableSubject.Size = new Size(985, 325);
            tableSubject.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(429, 9);
            label1.Name = "label1";
            label1.Size = new Size(130, 45);
            label1.TabIndex = 6;
            label1.Text = "Subject";
            // 
            // SubjectDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 489);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(tableSubject);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SubjectDetails";
            Text = "SubjectDetails";
            Load += SubjectDetails_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tableSubject).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnSearchSubject;
        private TextBox txtSearchSubject;
        private Label lblSearchSubject;
        private Button btnDeleteSubject;
        private Button btnEditSubject;
        private Button btnAddSubject;
        private DataGridView tableSubject;
        private Label label1;
    }
}