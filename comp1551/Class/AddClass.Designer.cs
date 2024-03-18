namespace comp1551.Class
{
    partial class AddClass
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
            txtAddClassName = new TextBox();
            lblAddClass = new Label();
            lblAddClassMaxCapacity = new Label();
            txtAddClassMaxCapacity = new TextBox();
            btnAddClass = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(117, 119);
            label1.Name = "label1";
            label1.Size = new Size(68, 25);
            label1.TabIndex = 0;
            label1.Text = "Name: ";
            // 
            // txtAddClassName
            // 
            txtAddClassName.Location = new Point(204, 116);
            txtAddClassName.Name = "txtAddClassName";
            txtAddClassName.Size = new Size(167, 31);
            txtAddClassName.TabIndex = 1;
            // 
            // lblAddClass
            // 
            lblAddClass.AutoSize = true;
            lblAddClass.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddClass.Location = new Point(142, 39);
            lblAddClass.Name = "lblAddClass";
            lblAddClass.Size = new Size(183, 32);
            lblAddClass.TabIndex = 0;
            lblAddClass.Text = "Add New Class";
            // 
            // lblAddClassMaxCapacity
            // 
            lblAddClassMaxCapacity.AutoSize = true;
            lblAddClassMaxCapacity.Location = new Point(67, 190);
            lblAddClassMaxCapacity.Name = "lblAddClassMaxCapacity";
            lblAddClassMaxCapacity.Size = new Size(118, 25);
            lblAddClassMaxCapacity.TabIndex = 0;
            lblAddClassMaxCapacity.Text = "Max capacity:";
            // 
            // txtAddClassMaxCapacity
            // 
            txtAddClassMaxCapacity.Location = new Point(204, 190);
            txtAddClassMaxCapacity.Name = "txtAddClassMaxCapacity";
            txtAddClassMaxCapacity.Size = new Size(167, 31);
            txtAddClassMaxCapacity.TabIndex = 1;
            // 
            // btnAddClass
            // 
            btnAddClass.Location = new Point(67, 273);
            btnAddClass.Name = "btnAddClass";
            btnAddClass.Size = new Size(304, 63);
            btnAddClass.TabIndex = 2;
            btnAddClass.Text = "Add";
            btnAddClass.UseVisualStyleBackColor = true;
            btnAddClass.Click += btnAddClass_Click;
            // 
            // AddClass
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 450);
            Controls.Add(btnAddClass);
            Controls.Add(txtAddClassMaxCapacity);
            Controls.Add(txtAddClassName);
            Controls.Add(lblAddClassMaxCapacity);
            Controls.Add(lblAddClass);
            Controls.Add(label1);
            Name = "AddClass";
            Text = "AddClass";
            Load += AddClass_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAddClassName;
        private Label lblAddClass;
        private Label lblAddClassMaxCapacity;
        private TextBox txtAddClassMaxCapacity;
        private Button btnAddClass;
    }
}