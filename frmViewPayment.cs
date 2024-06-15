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
    public partial class frmViewPayment : Form
    {
        Payment p = new Payment();
        public frmViewPayment()
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

        private void btnViewSearch_Click(object sender, EventArgs e)
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

        private void btnViewCancel_Click(object sender, EventArgs e)
        {
            txtPaymentID.Clear();
        }

       
    }
}
