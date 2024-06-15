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
    public partial class frmAddPayment : Form
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
            cbCustomerID.DataSource =c.ShowCustomer();
            cbCustomerID.DisplayMember = "CustomerID";
            cbCustomerID.ValueMember = "CustomerID";
        }
        public frmAddPayment()
        {
            InitializeComponent();
            FillPaymentCombo();
            FillPaymentCombo2();    
        }

        private void btnAdd_Click(object sender, EventArgs e)
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
            if (p.AddPayment(PaymentID, ReservationID,CustomerID, PaymentMethod, CardNumber, ExpiryDate, PaymentAmount))
            {
                MessageBox.Show("Payment Details Added Successfuly");
                txtPaymentID.Clear();
                txtCardNumber.Clear();
                cbCustomerID.SelectedIndex = -1;
                cbReservationID.SelectedIndex = -1; 
                cbPaymentMethod.SelectedIndex = -1;
                cbPaymentAmount.SelectedIndex = -1;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtPaymentID.Clear();
            txtCardNumber.Clear();
            cbReservationID.SelectedIndex = -1;
            cbPaymentMethod.SelectedIndex = -1;
            cbPaymentAmount.SelectedIndex = -1;
            cbCustomerID.SelectedIndex = -1;
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
