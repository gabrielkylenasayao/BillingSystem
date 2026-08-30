namespace BillingSystem
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblUsername = new Label();
            txtUsername = new MaskedTextBox();
            lblPassword = new Label();
            txtPassword = new MaskedTextBox();
            btnLogin = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(89, 26);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(194, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "BILLING SYSTEM";
            lblTitle.Click += label1_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(78, 86);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(78, 20);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(157, 83);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(125, 27);
            txtUsername.TabIndex = 2;
            txtUsername.MaskInputRejected += txtUsername_MaskInputRejected;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(83, 136);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(73, 20);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(157, 133);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 4;
            txtPassword.MaskInputRejected += txtPassword_MaskInputRejected;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(76, 193);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(211, 193);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Quit";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(382, 253);
            Controls.Add(btnCancel);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Billing System v1.0 – Login (G. K. N.)";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
          
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
                
        }
         
        

        private void txtPassword_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void txtUsername_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label lblTitle;
        private Label lblUsername;
        private MaskedTextBox txtUsername;
        private Label lblPassword;
        private MaskedTextBox txtPassword;
        private Button btnLogin;
        private Button btnCancel;
    }
}
