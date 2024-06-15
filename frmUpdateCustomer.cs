using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationSystem
{
    public partial class frmUpdateCustomer : Form
    {
        Customer c = new Customer();
       
        public frmUpdateCustomer()
        {
            InitializeComponent();
          
            ShowCustomers();
        }
        private void ShowCustomers()
        {

            dgvCustomer.DataSource = c.ShowCustomer();
            dgvCustomer.ReadOnly = true;
            dgvCustomer.Refresh();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (txtCustomerID.Text == "")
            {
                MessageBox.Show("Please enter Customer ID to search");
                return;
            }

            int CustomerID = Convert.ToInt32(txtCustomerID.Text);
            DataTable dt = c.SearchCustomer(CustomerID);

            if (dt.Rows.Count > 0)
            {
                dgvCustomer.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No Customer found for CustomerID" + CustomerID);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvCustomer.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvCustomer.SelectedRows[0];
                txtCustomerID.Text = row.Cells[0].Value.ToString();
                txtFirstName.Text = row.Cells[1].Value.ToString();
                txtLastName.Text = row.Cells[2].Value.ToString();
                txtAddress.Text = row.Cells[3].Value.ToString();
                txtEmail.Text = row.Cells[4].Value.ToString();
                txtPhone.Text = row.Cells[5].Value.ToString();
               
               
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtCustomerID.Text == "")
            {
                MessageBox.Show("Enter Customer Id");
                return;
            }
            if (txtFirstName.Text == "")
            {
                MessageBox.Show("Enter First Name ");
                return;
            }
            if (txtAddress.Text == "")
            {
                MessageBox.Show("Enter Address");
                return;
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Enter Email");
                return;
            }
            if (txtPhone.Text == "")
            {
                MessageBox.Show("Enter Phone");
                return;
            }
            int CustomerID = Convert.ToInt32(txtCustomerID.Text);
            String FirstName = txtFirstName.Text;
            String LastName = txtLastName.Text;
            String Email = txtEmail.Text;
            String Address = txtAddress.Text;
            String Phone = txtPhone.Text;
            if (c.UpdateCustomer(CustomerID, FirstName, LastName,Address,Email, Phone))
            {
                MessageBox.Show("Customer data Updated Successfuly");
                txtCustomerID.Clear();
                txtFirstName.Clear();
                txtLastName.Clear();
                txtAddress.Clear();
                txtPhone.Clear();
                txtEmail.Clear();
                ShowCustomers();
            }
        }

    }
}
