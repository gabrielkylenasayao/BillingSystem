namespace BillingSystem
{
    partial class frmBillingHistory
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
            dgvBillingHistory = new DataGridView();
            btnClose = new Button();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBillingHistory).BeginInit();
            SuspendLayout();
            // 
            // dgvBillingHistory
            // 
            dgvBillingHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBillingHistory.Location = new Point(12, 84);
            dgvBillingHistory.Name = "dgvBillingHistory";
            dgvBillingHistory.RowHeadersWidth = 51;
            dgvBillingHistory.Size = new Size(781, 307);
            dgvBillingHistory.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(699, 409);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(10, 26);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(222, 41);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Billing History";
            // 
            // frmBillingHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitle);
            Controls.Add(btnClose);
            Controls.Add(dgvBillingHistory);
            Name = "frmBillingHistory";
            Text = "frmBillingHistory";
            ((System.ComponentModel.ISupportInitialize)dgvBillingHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBillingHistory;
        private Button btnClose;
        private Label lblTitle;
    }
}