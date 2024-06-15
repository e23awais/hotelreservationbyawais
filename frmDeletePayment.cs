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
    public partial class frmDeletePayment : Form
    {
        Payment p = new Payment();
        Reservation r = new Reservation();
        Customer c = new Customer();    
        public frmDeletePayment()
        {
            InitializeComponent();
            ShowPayments();
        }
        private void ShowPayments()
        {

            dgvPayment.DataSource = p.ShowPayment();
            dgvPayment.ReadOnly = true;
            dgvPayment.Refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtPaymentID.Text == "")
            {
                MessageBox.Show("Please enter Payment ID to Delete");
                return;
            }
            if (txtReservationID.Text == "")
            {
                MessageBox.Show("Please Get Reservation ID to Delete");
                return;
            }
            if (txtPaymentID.Text == "")
            {
                MessageBox.Show("Please Get Customer ID to Delete");
                return;
            }



            int PaymentID = Convert.ToInt32(txtPaymentID.Text);
            int ReservationID = Convert.ToInt32(txtReservationID.Text);
            int CustomerID = Convert.ToInt32(txtCustomerID.Text);   
            DialogResult dr;
            dr = MessageBox.Show("Do you want to Delete this Payment Transaction?",
            "Payment Transaction Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (p.DeletePayment(PaymentID))
                {
                    if (r.CancelReservation(ReservationID))
                    {
                        if (c.DeleteCustomer(CustomerID))
                        {
                            txtPaymentID.Clear();
                            txtReservationID.Clear();
                            txtCustomerID.Clear();
                            ShowPayments();
                            MessageBox.Show("Payment Transaction , Reservation and Customer Data Deleted Successfuly");
                        }
                    }
                    
                }
                else
                    MessageBox.Show("Error Deleting Payment Transaction , Reservation and Customer Data ");
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPaymentID.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtPaymentID.Text == "")
            {
                MessageBox.Show("Please enter Payment ID to search");
                return;
            }

            int PaymentID = Convert.ToInt32(txtPaymentID.Text);
            DataTable dt = p.SearchPayment(PaymentID);

            if (dt.Rows.Count > 0)
            {
                dgvPayment.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No Payment Records found for PaymentID " + PaymentID);
            }

        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            if (dgvPayment.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvPayment.SelectedRows[0];
                txtPaymentID.Text = row.Cells[0].Value.ToString();
                txtReservationID.Text = row.Cells[1].Value.ToString();
                txtCustomerID.Text = row.Cells[6].Value.ToString();

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtPaymentID.Clear();
            txtReservationID.Clear();
            txtCustomerID.Clear();

        }
    }
}
