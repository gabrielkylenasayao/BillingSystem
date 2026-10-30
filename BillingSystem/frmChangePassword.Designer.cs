namespace BillingSystem
{
    partial class frmChangePassword
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
            lblchangepass = new Label();
            lblCurrent = new Label();
            lblNew = new Label();
            lblRetype = new Label();
            txtCurrentPassword = new TextBox();
            txtNewPassword = new TextBox();
            txtRetypePassword = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblchangepass
            // 
            lblchangepass.AutoSize = true;
            lblchangepass.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblchangepass.Location = new Point(199, 35);
            lblchangepass.Name = "lblchangepass";
            lblchangepass.Size = new Size(355, 54);
            lblchangepass.TabIndex = 0;
            lblchangepass.Text = "Change Password";
            // 
            // lblCurrent
            // 
            lblCurrent.AutoSize = true;
            lblCurrent.Font = new Font("Segoe UI", 12F);
            lblCurrent.Location = new Point(84, 134);
            lblCurrent.Name = "lblCurrent";
            lblCurrent.Size = new Size(172, 28);
            lblCurrent.TabIndex = 1;
            lblCurrent.Text = "Current Password :";
            // 
            // lblNew
            // 
            lblNew.AutoSize = true;
            lblNew.Font = new Font("Segoe UI", 12F);
            lblNew.Location = new Point(84, 194);
            lblNew.Name = "lblNew";
            lblNew.Size = new Size(146, 28);
            lblNew.TabIndex = 2;
            lblNew.Text = "New Password :";
            // 
            // lblRetype
            // 
            lblRetype.AutoSize = true;
            lblRetype.Font = new Font("Segoe UI", 12F);
            lblRetype.Location = new Point(84, 252);
            lblRetype.Name = "lblRetype";
            lblRetype.Size = new Size(167, 28);
            lblRetype.TabIndex = 3;
            lblRetype.Text = "Retype Password :";
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.Font = new Font("Segoe UI", 12F);
            txtCurrentPassword.Location = new Point(386, 134);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.Size = new Size(310, 34);
            txtCurrentPassword.TabIndex = 4;
            txtCurrentPassword.UseSystemPasswordChar = true;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Font = new Font("Segoe UI", 12F);
            txtNewPassword.Location = new Point(386, 194);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(310, 34);
            txtNewPassword.TabIndex = 5;
            txtNewPassword.UseSystemPasswordChar = true;
            // 
            // txtRetypePassword
            // 
            txtRetypePassword.Font = new Font("Segoe UI", 12F);
            txtRetypePassword.Location = new Point(386, 252);
            txtRetypePassword.Name = "txtRetypePassword";
            txtRetypePassword.Size = new Size(310, 34);
            txtRetypePassword.TabIndex = 6;
            txtRetypePassword.UseSystemPasswordChar = true;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(84, 349);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(151, 42);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save Password";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(574, 349);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(122, 42);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtRetypePassword);
            Controls.Add(txtNewPassword);
            Controls.Add(txtCurrentPassword);
            Controls.Add(lblRetype);
            Controls.Add(lblNew);
            Controls.Add(lblCurrent);
            Controls.Add(lblchangepass);
            Name = "frmChangePassword";
            Text = "frmChangePassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblchangepass;
        private Label lblCurrent;
        private Label lblNew;
        private Label lblRetype;
        private TextBox txtCurrentPassword;
        private TextBox txtNewPassword;
        private TextBox txtRetypePassword;
        private Button btnSave;
        private Button btnCancel;
    }
}