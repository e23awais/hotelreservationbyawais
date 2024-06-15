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
    public partial class frmSearchCustomer : Form
    {
        Customer c = new Customer();
        public frmSearchCustomer()
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerID.Clear();
        }
    }
}
