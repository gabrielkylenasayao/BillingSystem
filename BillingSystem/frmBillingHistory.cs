using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BillingSystem.Database;

namespace BillingSystem
{
    public partial class frmBillingHistory : Form
    {
        private int customerId;
        private string customerName;

        // Constructor accepting the selected Customer ID and Name from CustomerListForm
        public frmBillingHistory(int id, string name)
        {
            InitializeComponent();
            customerId = id;
            customerName = name;

            // Keep the history grid strictly read-only and clean when empty:
            dgvBillingHistory.AllowUserToAddRows = false;

            this.Load += new EventHandler(this.frmBillingHistory_Load);

            lblTitle.Text = $"Billing History - {customerName}";
            this.Text = $"Billing History - {customerName}";
        }

        private void frmBillingHistory_Load(object sender, EventArgs e)
        {
            LoadBillingHistoryData();
        }

        private void LoadBillingHistoryData()
        {
            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    // Explicitly selects and aliases only the spec-required columns, hiding BillingID and CustomerID
                    string query = @"SELECT 
                             BillingMonth AS 'Billing Month', 
                             PreviousReading AS 'Previous Reading', 
                             PresentReading AS 'Present Reading', 
                             Consumption AS 'Consumption', 
                             RatePerCubic AS 'Rate Per Cubic', 
                             TotalAmount AS 'Total Amount', 
                             Status 
                             FROM Billing 
                             WHERE CustomerID = @CustomerID 
                             ORDER BY BillingID DESC";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", customerId);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            dgvBillingHistory.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading billing history: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}