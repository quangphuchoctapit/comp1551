namespace comp1551.User
{
    partial class UserDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDetails));
            panel1 = new Panel();
            comboBoxFilter = new ComboBox();
            btnSearchUser = new Button();
            txtSearchUser = new TextBox();
            lblSearchClass = new Label();
            btnDeleteUser = new Button();
            btnEditUser = new Button();
            btnAddUser = new Button();
            tableUser = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableUser).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBoxFilter);
            panel1.Controls.Add(btnSearchUser);
            panel1.Controls.Add(txtSearchUser);
            panel1.Controls.Add(lblSearchClass);
            panel1.Controls.Add(btnDeleteUser);
            panel1.Controls.Add(btnEditUser);
            panel1.Controls.Add(btnAddUser);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1068, 98);
            panel1.TabIndex = 5;
            // 
            // comboBoxFilter
            // 
            comboBoxFilter.FormattingEnabled = true;
            comboBoxFilter.Location = new Point(640, 35);
            comboBoxFilter.Name = "comboBoxFilter";
            comboBoxFilter.Size = new Size(170, 33);
            comboBoxFilter.TabIndex = 4;
            comboBoxFilter.SelectedIndexChanged += comboBoxFilter_SelectedIndexChanged;
            // 
            // btnSearchUser
            // 
            btnSearchUser.BackColor = Color.White;
            btnSearchUser.BackgroundImage = (Image)resources.GetObject("btnSearchUser.BackgroundImage");
            btnSearchUser.BackgroundImageLayout = ImageLayout.Zoom;
            btnSearchUser.Location = new Point(1006, 33);
            btnSearchUser.Name = "btnSearchUser";
            btnSearchUser.Size = new Size(40, 40);
            btnSearchUser.TabIndex = 3;
            btnSearchUser.UseVisualStyleBackColor = false;
            btnSearchUser.Click += btnSearchUser_Click;
            // 
            // txtSearchUser
            // 
            txtSearchUser.Location = new Point(832, 35);
            txtSearchUser.Name = "txtSearchUser";
            txtSearchUser.Size = new Size(161, 31);
            txtSearchUser.TabIndex = 2;
            // 
            // lblSearchClass
            // 
            lblSearchClass.AutoSize = true;
            lblSearchClass.Location = new Point(510, 38);
            lblSearchClass.Name = "lblSearchClass";
            lblSearchClass.Size = new Size(108, 25);
            lblSearchClass.TabIndex = 1;
            lblSearchClass.Text = "Search User:";
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Location = new Point(339, 12);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(140, 70);
            btnDeleteUser.TabIndex = 0;
            btnDeleteUser.Text = "Delete User";
            btnDeleteUser.UseVisualStyleBackColor = true;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // btnEditUser
            // 
            btnEditUser.Location = new Point(175, 12);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new Size(140, 70);
            btnEditUser.TabIndex = 0;
            btnEditUser.Text = "Edit User";
            btnEditUser.UseVisualStyleBackColor = true;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(12, 12);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(140, 70);
            btnAddUser.TabIndex = 0;
            btnAddUser.Text = "Add User";
            btnAddUser.UseVisualStyleBackColor = true;
            // 
            // tableUser
            // 
            tableUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableUser.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tableUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableUser.Dock = DockStyle.Bottom;
            tableUser.Location = new Point(0, 125);
            tableUser.Name = "tableUser";
            tableUser.RowHeadersWidth = 62;
            tableUser.Size = new Size(1068, 325);
            tableUser.TabIndex = 4;
            // 
            // UserDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 450);
            Controls.Add(panel1);
            Controls.Add(tableUser);
            Name = "UserDetails";
            Text = "UserDetails";
            Load += UserDetails_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tableUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnSearchUser;
        private TextBox txtSearchUser;
        private Label lblSearchClass;
        private Button btnDeleteUser;
        private Button btnEditUser;
        private Button btnAddUser;
        private DataGridView tableUser;
        private ComboBox comboBoxFilter;
    }
}