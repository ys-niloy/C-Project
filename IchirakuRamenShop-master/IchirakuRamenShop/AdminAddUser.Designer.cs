namespace IchirakuRamenShop
{
    partial class AdminAddUser
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
            btnCancel = new Button();
            txtPassword = new TextBox();
            txtName = new TextBox();
            txtRole = new TextBox();
            txtUsername = new TextBox();
            txtUid = new TextBox();
            btnAdd = new Button();
            lblPassword = new Label();
            lblName = new Label();
            lblRole = new Label();
            lblUsername = new Label();
            lblUid = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(txtRole);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(txtUid);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(lblRole);
            panel1.Controls.Add(lblUsername);
            panel1.Controls.Add(lblUid);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(626, 440);
            panel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(328, 377);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(271, 297);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(214, 23);
            txtPassword.TabIndex = 10;
            // 
            // txtName
            // 
            txtName.Location = new Point(271, 253);
            txtName.Name = "txtName";
            txtName.Size = new Size(214, 23);
            txtName.TabIndex = 9;
            // 
            // txtRole
            // 
            txtRole.Location = new Point(271, 203);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(214, 23);
            txtRole.TabIndex = 8;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(271, 154);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(214, 23);
            txtUsername.TabIndex = 7;
            // 
            // txtUid
            // 
            txtUid.Location = new Point(271, 102);
            txtUid.Name = "txtUid";
            txtUid.Size = new Size(214, 23);
            txtUid.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(162, 377);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add User";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click_2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(105, 299);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(79, 21);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(105, 255);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 21);
            lblName.TabIndex = 3;
            lblName.Text = "Name";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRole.Location = new Point(105, 203);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(41, 21);
            lblRole.TabIndex = 2;
            lblRole.Text = "Role";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(105, 152);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(81, 21);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // lblUid
            // 
            lblUid.AutoSize = true;
            lblUid.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUid.Location = new Point(105, 100);
            lblUid.Name = "lblUid";
            lblUid.Size = new Size(41, 21);
            lblUid.TabIndex = 0;
            lblUid.Text = "Uid: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(235, 21);
            label1.Name = "label1";
            label1.Size = new Size(119, 32);
            label1.TabIndex = 12;
            label1.Text = "Add User";
            // 
            // AdminAddUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 440);
            Controls.Add(panel1);
            Name = "AdminAddUser";
            Text = "AdminAddUser";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblPassword;
        private Label lblName;
        private Label lblRole;
        private Label lblUsername;
        private Label lblUid;
        private Button btnCancel;
        private TextBox txtPassword;
        private TextBox txtName;
        private TextBox txtRole;
        private TextBox txtUsername;
        private TextBox txtUid;
        private Button btnAdd;
        private Label label1;
    }
}