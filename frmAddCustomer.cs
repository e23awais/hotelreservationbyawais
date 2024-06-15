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
    public partial class frmAddCustomer : Form
    {
        Customer c = new Customer();
        
        
        public frmAddCustomer()
        {
            InitializeComponent();
           
        }

       

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtCustomerID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
        
        }

       

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtCustomerID.Text == "")
            {
                MessageBox.Show("Enter Customer ID");
                return;
            }
            if (txtFirstName.Text == "")
            {
                MessageBox.Show("Enter First Name");
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
            if (c.CreateCustomer(CustomerID, FirstName, LastName, Address,Email, Phone))
            {
                MessageBox.Show("Customer data added");
                txtCustomerID.Clear();
                txtFirstName.Clear();
                txtLastName.Clear();
                txtAddress.Clear();
                txtPhone.Clear();
                txtEmail.Clear();
              
            }
        }
    }
}
