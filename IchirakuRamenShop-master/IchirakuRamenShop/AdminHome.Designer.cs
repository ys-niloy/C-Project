namespace IchirakuRamenShop
{
    partial class AdminHome
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
            panel1 = new Panel();
            label1 = new Label();
            btnDelete = new Button();
            btnAdd = new Button();
            dgvUser = new DataGridView();
            Uid = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            Role = new DataGridViewTextBoxColumn();
            NameColumn = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(dgvUser);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(597, 384);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(238, 9);
            label1.Name = "label1";
            label1.Size = new Size(103, 30);
            label1.TabIndex = 3;
            label1.Text = "User Info";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(310, 312);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete User";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(134, 312);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add User";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvUser
            // 
            dgvUser.AllowUserToDeleteRows = false;
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.Columns.AddRange(new DataGridViewColumn[] { Uid, Username, Role, NameColumn });
            dgvUser.Location = new Point(59, 96);
            dgvUser.Name = "dgvUser";
            dgvUser.Size = new Size(443, 150);
            dgvUser.TabIndex = 0;
            // 
            // Uid
            // 
            Uid.DataPropertyName = "Uid";
            Uid.HeaderText = "Uid";
            Uid.Name = "Uid";
            // 
            // Username
            // 
            Username.DataPropertyName = "Username";
            Username.HeaderText = "Username";
            Username.Name = "Username";
            // 
            // Role
            // 
            Role.DataPropertyName = "Role";
            Role.HeaderText = "Role";
            Role.Name = "Role";
            // 
            // NameColumn
            // 
            NameColumn.DataPropertyName = "Name";
            NameColumn.HeaderText = "Name";
            NameColumn.Name = "NameColumn";
            // 
            // AdminHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 384);
            Controls.Add(panel1);
            Name = "AdminHome";
            Text = "AdminHome";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvUser;
        private Button btnAdd;
        private Button btnDelete;
        private DataGridViewTextBoxColumn Uid;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Role;
        private DataGridViewTextBoxColumn NameColumn;
        private Label label1;
    }
}
