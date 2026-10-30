namespace BillingSystem
{
    partial class frmAuditLogs
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
            lblTitle = new Label();
            lblFrom = new Label();
            lblTo = new Label();
            btnSearch = new Button();
            btnClose = new Button();
            dtpFrom = new DateTimePicker();
            dtpTo = new DateTimePicker();
            btnSearch = new Button();
            dgvAuditLogs = new DataGridView();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAuditLogs).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AccessibleRole = AccessibleRole.Window;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(199, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Audit Log Report";
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Location = new Point(72, 85);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(46, 20);
            lblFrom.TabIndex = 1;
            lblFrom.Text = "From:";
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Location = new Point(404, 85);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(28, 20);
            lblTo.TabIndex = 2;
            lblTo.Text = "To:";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(710, 85);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(776, 462);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new Point(124, 85);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(250, 27);
            dtpFrom.TabIndex = 5;
            // 
            // dtpTo
            // 
            dtpTo.Location = new Point(438, 85);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(250, 27);
            dtpTo.TabIndex = 6;
            // 
            // dgvAuditLogs
            // 
            dgvAuditLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuditLogs.Location = new Point(32, 120);
            dgvAuditLogs.Name = "dgvAuditLogs";
            dgvAuditLogs.RowHeadersWidth = 51;
            dgvAuditLogs.Size = new Size(808, 271);
            dgvAuditLogs.TabIndex = 7;
            // 
            // frmAuditLogs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 503);
            Controls.Add(btnClose);
            Controls.Add(dgvAuditLogs);
            Controls.Add(btnSearch);
            Controls.Add(dtpTo);
            Controls.Add(dtpFrom);
            Controls.Add(btnClose);
            Controls.Add(btnSearch);
            Controls.Add(lblTo);
            Controls.Add(lblFrom);
            Controls.Add(lblTitle);
            Name = "frmAuditLogs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Audit Log Report";
            Load += frmAuditLogs_Load;
            Click += btnSearch_Click;
            ((System.ComponentModel.ISupportInitialize)dgvAuditLogs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblFrom;
        private Label lblTo;
        private Button btnSearch;
        private Button btnClose;
        private DateTimePicker dtpFrom;
        private DateTimePicker dtpTo;
        private DataGridView dgvAuditLogs;
    }
}