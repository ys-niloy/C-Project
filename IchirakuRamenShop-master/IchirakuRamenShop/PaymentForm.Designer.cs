namespace IchirakuRamenShop
{
    partial class PaymentForm
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
            Cancel = new Button();
            Pay = new Button();
            txtSecurityCode = new TextBox();
            txtNumber = new TextBox();
            txtName = new TextBox();
            lblSecurityCode = new Label();
            lblNumber = new Label();
            lblName = new Label();
            txtAmount = new TextBox();
            lblPaymentAmount = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Cancel);
            panel1.Controls.Add(Pay);
            panel1.Controls.Add(txtSecurityCode);
            panel1.Controls.Add(txtNumber);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(lblSecurityCode);
            panel1.Controls.Add(lblNumber);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(txtAmount);
            panel1.Controls.Add(lblPaymentAmount);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(679, 417);
            panel1.TabIndex = 0;
            // 
            // Cancel
            // 
            Cancel.Location = new Point(372, 341);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(75, 23);
            Cancel.TabIndex = 9;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = true;
            // 
            // Pay
            // 
            Pay.Location = new Point(185, 341);
            Pay.Name = "Pay";
            Pay.Size = new Size(75, 23);
            Pay.TabIndex = 8;
            Pay.Text = "Pay";
            Pay.UseVisualStyleBackColor = true;
            Pay.Click += Pay_Click;
            // 
            // txtSecurityCode
            // 
            txtSecurityCode.Location = new Point(319, 250);
            txtSecurityCode.Name = "txtSecurityCode";
            txtSecurityCode.Size = new Size(205, 23);
            txtSecurityCode.TabIndex = 7;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(319, 195);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(205, 23);
            txtNumber.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Location = new Point(319, 142);
            txtName.Name = "txtName";
            txtName.Size = new Size(205, 23);
            txtName.TabIndex = 5;
            // 
            // lblSecurityCode
            // 
            lblSecurityCode.AutoSize = true;
            lblSecurityCode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSecurityCode.Location = new Point(130, 248);
            lblSecurityCode.Name = "lblSecurityCode";
            lblSecurityCode.Size = new Size(106, 21);
            lblSecurityCode.TabIndex = 4;
            lblSecurityCode.Text = "Security Code";
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumber.Location = new Point(130, 193);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(105, 21);
            lblNumber.TabIndex = 3;
            lblNumber.Text = "Card Number";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(130, 140);
            lblName.Name = "lblName";
            lblName.Size = new Size(114, 21);
            lblName.TabIndex = 2;
            lblName.Text = "Name On Card";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(319, 85);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(205, 23);
            txtAmount.TabIndex = 1;
            // 
            // lblPaymentAmount
            // 
            lblPaymentAmount.AutoSize = true;
            lblPaymentAmount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPaymentAmount.Location = new Point(130, 83);
            lblPaymentAmount.Name = "lblPaymentAmount";
            lblPaymentAmount.Size = new Size(130, 21);
            lblPaymentAmount.TabIndex = 0;
            lblPaymentAmount.Text = "Payment Amount";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(281, 9);
            label1.Name = "label1";
            label1.Size = new Size(98, 30);
            label1.TabIndex = 10;
            label1.Text = "Payment";
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 417);
            Controls.Add(panel1);
            Name = "PaymentForm";
            Text = "PaymentForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblPaymentAmount;
        private Button Cancel;
        private Button Pay;
        private TextBox txtSecurityCode;
        private TextBox txtNumber;
        private TextBox txtName;
        private Label lblSecurityCode;
        private Label lblNumber;
        private Label lblName;
        private TextBox txtAmount;
        private Label label1;
    }
}