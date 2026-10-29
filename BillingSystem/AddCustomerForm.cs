using BillingSystem.Database;
using BillingSystem.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BillingSystem.Database;
using BillingSystem.Utils;


namespace BillingSystem
{
    public partial class AddCustomerForm : Form
    {

        // 0 = Add mode (new customer)
        // > 0 = Edit mode (holds the CustomerID being edited)
        private int _editCustomerId = 0;


        // Constructor for ADD mode (no parameters)
        public AddCustomerForm()
        {
            InitializeComponent();
            _editCustomerId = 0;
        }

        // Constructor for EDIT mode — receives the CustomerID to edit
        public AddCustomerForm(int customerId)
        {
            InitializeComponent();
            _editCustomerId = customerId;
        }



        private void lblAddress_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            _editCustomerId = customerId;
        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {
            if (_editCustomerId > 0)
            {
                // EDIT MODE — change the title and load existing data
                lblTitle.Text = "Edit Customer";
                this.Text = "Billing System - Edit Customer";
                LoadCustomerData(_editCustomerId);
            }
            else
            {
                // ADD MODE — set default values
                lblTitle.Text = "Add New Customer";
                txtBalance.Text = "0.00";
            }
        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {
            if (_editCustomerId > 0)
            {
                // EDIT MODE — change the title and load existing data
                lblTitle.Text = "Edit Customer";
                this.Text = "Billing System - Edit Customer";
                LoadCustomerData(_editCustomerId);
            }
            else
            {
                // ADD MODE — set default values
                lblTitle.Text = "Add New Customer";
                txtBalance.Text = "0.00";
            }
        }

        private void LoadCustomerData(int customerId)
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string sql = @"SELECT FullName, Address, ContactNumber, Email, Balance
                           FROM   Customers
                           WHERE  CustomerID = @CustomerID;";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", customerId);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtFullName.Text = reader.GetString("FullName");
                                txtAddress.Text = reader.GetString("Address");
                                txtContact.Text = reader.GetString("ContactNumber");
                                txtEmail.Text = reader.GetString("Email");
                                txtBalance.Text = reader.GetDecimal("Balance").ToString("N2");
                            }
                            else
                            {
                                MessageBox.Show("Customer record not found.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customer data:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private bool ValidateInputs()
        {
            // Check Full Name
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Full Name is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return false;
            }

            // Check Address
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Address is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddress.Focus();
                return false;
            }

            // Check Contact Number
            if (string.IsNullOrWhiteSpace(txtContact.Text))
            {
                MessageBox.Show("Contact Number is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContact.Focus();
                return false;
            }

            // Check Email
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            // Check Balance is a valid number
            if (!decimal.TryParse(txtBalance.Text, out _))
            {
                MessageBox.Show("Initial Balance must be a valid number (e.g. 0.00).",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBalance.Focus();
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // 1. Validate form inputs first
            if (!ValidateInputs())
            {
                return;
            }

            // 2. Decide whether to UPDATE or INSERT based on _editCustomerId
            if (_editCustomerId > 0)
            {
                UpdateCustomer();
            }
            else
            {
                InsertCustomer();
            }
        }

        private void UpdateCustomer()
        {
            string query = @"UPDATE Customers 
                    SET FullName = @FullName, 
                        Address = @Address, 
                        ContactNumber = @ContactNumber, 
                        Email = @Email, 
                        Balance = @Balance 
                    WHERE CustomerID = @CustomerID";

            using (var conn = DatabaseConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FullName", txtFullName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@ContactNumber", txtContact.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@Balance", decimal.Parse(txtBalance.Text.Trim()));
                        cmd.Parameters.AddWithValue("@CustomerID", _editCustomerId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {

                            AuditLogger.Log("EDIT_CUSTOMER",$"Customer ID {_editCustomerId} updated by {AppSession.CurrentUsername}.");


                            MessageBox.Show("Customer updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No records were updated.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating customer: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void InsertCustomer()
        {
            string query = @"INSERT INTO Customers (FullName, Address, ContactNumber, Email, Balance) 
                    VALUES (@FullName, @Address, @ContactNumber, @Email, @Balance)";

            using (var conn = DatabaseConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FullName", txtFullName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@ContactNumber", txtContact.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@Balance", decimal.Parse(txtBalance.Text.Trim()));

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            AuditLogger.Log("ADD_CUSTOMER",$"New customer '{txtFullName.Text.Trim()}' added by {AppSession.CurrentUsername}.");


                            MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding customer: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}

