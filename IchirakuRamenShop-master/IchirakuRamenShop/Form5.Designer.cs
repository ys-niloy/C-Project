﻿namespace IchirakuRamenShop
{
    partial class Form5
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            btnClose = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            cartTable = new DataGridView();
            dataGridViewProducts = new DataGridView();
            guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            btnexit = new Guna.UI2.WinForms.Guna2ControlBox();
            Image = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            PName = new DataGridViewTextBoxColumn();
            Pid = new DataGridViewTextBoxColumn();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cartTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            guna2Panel3.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(btnClose);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.Controls.Add(pictureBox1);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Dock = DockStyle.Left;
            guna2Panel1.FillColor = Color.FromArgb(255, 225, 130);
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Margin = new Padding(2, 2, 2, 2);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(240, 394);
            guna2Panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(47, 282);
            btnClose.Margin = new Padding(2, 2, 2, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 1;
            btnClose.Text = "button1";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bodoni MT", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 194);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(191, 68);
            label1.TabIndex = 1;
            label1.Text = "Order Your Fevorite Dish from Ichiraku Ramen";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.japanese_ramen_noodle_food_suitable_for_use_as_logo_posters_menus_etc_free_vector;
            pictureBox1.Location = new Point(47, 56);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(522, 380);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(125, 38);
            button1.TabIndex = 2;
            button1.Text = "Place Order";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnOrder_Click;
            // 
            // guna2Panel2
            // 
            guna2Panel2.Controls.Add(button1);
            guna2Panel2.Controls.Add(cartTable);
            guna2Panel2.Controls.Add(dataGridViewProducts);
            guna2Panel2.CustomizableEdges = customizableEdges3;
            guna2Panel2.Dock = DockStyle.Fill;
            guna2Panel2.Font = new Font("Segoe UI", 15F);
            guna2Panel2.Location = new Point(240, 0);
            guna2Panel2.Margin = new Padding(2, 2, 2, 2);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel2.Size = new Size(453, 394);
            guna2Panel2.TabIndex = 1;
            guna2Panel2.Paint += guna2Panel2_Paint;
            // 
            // cartTable
            // 
            cartTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cartTable.Location = new Point(482, 82);
            cartTable.Margin = new Padding(2, 2, 2, 2);
            cartTable.Name = "cartTable";
            cartTable.RowHeadersWidth = 82;
            cartTable.Size = new Size(264, 370);
            cartTable.TabIndex = 1;
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Columns.AddRange(new DataGridViewColumn[] { Pid, PName, Price, Image });
            dataGridViewProducts.Location = new Point(18, 82);
            dataGridViewProducts.Margin = new Padding(2, 2, 2, 2);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.RowHeadersWidth = 82;
            dataGridViewProducts.Size = new Size(449, 370);
            dataGridViewProducts.TabIndex = 0;
            dataGridViewProducts.CellContentClick += dataGridViewProducts_CellContentClick;
            // 
            // guna2Panel3
            // 
            guna2Panel3.Controls.Add(guna2ControlBox3);
            guna2Panel3.Controls.Add(guna2ControlBox2);
            guna2Panel3.Controls.Add(btnexit);
            guna2Panel3.CustomizableEdges = customizableEdges11;
            guna2Panel3.Dock = DockStyle.Top;
            guna2Panel3.FillColor = Color.Gainsboro;
            guna2Panel3.Location = new Point(240, 0);
            guna2Panel3.Margin = new Padding(2, 2, 2, 2);
            guna2Panel3.Name = "guna2Panel3";
            guna2Panel3.ShadowDecoration.CustomizableEdges = customizableEdges12;
            guna2Panel3.Size = new Size(453, 52);
            guna2Panel3.TabIndex = 1;
            // 
            // guna2ControlBox3
            // 
            guna2ControlBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            guna2ControlBox3.CustomIconSize = 15F;
            guna2ControlBox3.CustomizableEdges = customizableEdges5;
            guna2ControlBox3.FillColor = Color.FromArgb(139, 152, 166);
            guna2ControlBox3.IconColor = Color.White;
            guna2ControlBox3.Location = new Point(300, 6);
            guna2ControlBox3.Margin = new Padding(2, 2, 2, 2);
            guna2ControlBox3.Name = "guna2ControlBox3";
            guna2ControlBox3.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2ControlBox3.Size = new Size(32, 30);
            guna2ControlBox3.TabIndex = 2;
            // 
            // guna2ControlBox2
            // 
            guna2ControlBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            guna2ControlBox2.CustomIconSize = 15F;
            guna2ControlBox2.CustomizableEdges = customizableEdges7;
            guna2ControlBox2.FillColor = Color.FromArgb(139, 152, 166);
            guna2ControlBox2.IconColor = Color.White;
            guna2ControlBox2.Location = new Point(355, 6);
            guna2ControlBox2.Margin = new Padding(2, 2, 2, 2);
            guna2ControlBox2.Name = "guna2ControlBox2";
            guna2ControlBox2.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2ControlBox2.Size = new Size(32, 30);
            guna2ControlBox2.TabIndex = 1;
            // 
            // btnexit
            // 
            btnexit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnexit.CustomIconSize = 15F;
            btnexit.CustomizableEdges = customizableEdges9;
            btnexit.FillColor = Color.FromArgb(139, 152, 166);
            btnexit.Font = new Font("Segoe UI", 10F);
            btnexit.IconColor = Color.White;
            btnexit.Location = new Point(406, 6);
            btnexit.Margin = new Padding(2, 2, 2, 2);
            btnexit.Name = "btnexit";
            btnexit.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnexit.Size = new Size(32, 30);
            btnexit.TabIndex = 0;
            btnexit.Click += btnexit_Click;
            // 
            // Image
            // 
            Image.DataPropertyName = "IMAGE";
            Image.HeaderText = "IMAGE";
            Image.MinimumWidth = 10;
            Image.Name = "Image";
            Image.Width = 200;
            // 
            // Price
            // 
            Price.DataPropertyName = "PRICE";
            Price.HeaderText = "PRICE";
            Price.MinimumWidth = 10;
            Price.Name = "Price";
            Price.Width = 200;
            // 
            // PName
            // 
            PName.DataPropertyName = "PNAME";
            PName.HeaderText = "PNAME";
            PName.MinimumWidth = 10;
            PName.Name = "PName";
            PName.Width = 200;
            // 
            // Pid
            // 
            Pid.DataPropertyName = "PID";
            Pid.HeaderText = "PID";
            Pid.MinimumWidth = 10;
            Pid.Name = "Pid";
            Pid.Width = 200;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(693, 394);
            Controls.Add(guna2Panel3);
            Controls.Add(guna2Panel2);
            Controls.Add(guna2Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form5";
            Text = "Form5";
            WindowState = FormWindowState.Maximized;
            Load += Form5_Load;
            guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)cartTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            guna2Panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox btnexit;
        private Label label1;
        private PictureBox pictureBox1;
        private DataGridView dataGridViewProducts;
        private Button btnClose;
        private DataGridView cartTable;
        private Button button1;
        private DataGridViewTextBoxColumn Pid;
        private DataGridViewTextBoxColumn PName;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Image;
    }
}