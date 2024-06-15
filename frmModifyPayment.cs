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
    public partial class frmModifyPayment : Form
    {
        Payment p = new Payment();
        Reservation r = new Reservation();
        Customer c = new Customer();
        int CustomerID;
        int ReservationID;
        bool Starting = true;
        /* bool Starting2 = true*/
        void FillPaymentCombo()
        {
            cbReservationID.DataSource = r.ShowReservation();
            cbReservationID.DisplayMember = "ReservationID";
            cbReservationID.ValueMember = "ReservationID";
        }
        void FillPaymentCombo2()
        {
            cbCustomerID.DataSource = c.ShowCustomer();
            cbCustomerID.DisplayMember = "CustomerID";
            cbCustomerID.ValueMember = "CustomerID";
        }
        public frmModifyPayment()
        {
            InitializeComponent();
            ShowPayments();
            FillPaymentCombo();
            FillPaymentCombo2();
        }
        private void ShowPayments()
        {

            dgvPayment.DataSource = p.ShowPayment();
            dgvPayment.ReadOnly = true;
            dgvPayment.Refresh();
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvPayment.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvPayment.SelectedRows[0];
                txtPaymentID.Text = row.Cells[0].Value.ToString();
                cbReservationID.Text = row.Cells[1].Value.ToString();
                cbPaymentMethod.Text = row.Cells[2].Value.ToString();
                txtCardNumber.Text = row.Cells[3].Value.ToString();
                dtpExpiryDate.Value= Convert.ToDateTime(row.Cells[4].Value);
                cbPaymentAmount.Text = row.Cells[5].Value.ToString();
                cbCustomerID.Text = row.Cells[6].Value.ToString();

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPaymentID.Text == "")
            {
                MessageBox.Show("Enter Payment ID");
                return;
            }
            if (cbReservationID.SelectedIndex == -1)
            {
                MessageBox.Show("Select Reservation ID");
                return;
            }
            if (cbPaymentMethod.SelectedIndex == -1)
            {
                MessageBox.Show("Select PaymentMethod");
                return;
            }
            if (cbPaymentAmount.SelectedIndex == -1)
            {
                MessageBox.Show("Select Payment Amount");
                return;
            }

            int PaymentID = Convert.ToInt32(txtPaymentID.Text);
            DateTime ExpiryDate = dtpExpiryDate.Value;
            String PaymentMethod = cbPaymentMethod.Text;
            int ReservationID = Convert.ToInt32(cbReservationID.Text);
            int CustomerID = Convert.ToInt32(cbCustomerID.Text);
            String PaymentAmount = cbPaymentAmount.Text;
            String CardNumber = txtCardNumber.Text;
            if (p.ModifyPayment(PaymentID, ReservationID,CustomerID ,PaymentMethod, CardNumber, ExpiryDate, PaymentAmount))
            {
                MessageBox.Show("Payment Details Updated Successfuly");
                txtPaymentID.Clear();
                txtCardNumber.Clear();
                cbCustomerID.SelectedIndex = -1;
                cbReservationID.SelectedIndex = -1;
                cbPaymentMethod.SelectedIndex = -1;
                cbPaymentAmount.SelectedIndex = -1;
                ShowPayments();
            }
        }

        private void cbReservationID_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Starting != true)
                ReservationID = Convert.ToInt32(cbReservationID.ToString());
        }

        private void cbCustomerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Starting != true)
                CustomerID = Convert.ToInt32(cbCustomerID.ToString());
        }
    }
}
