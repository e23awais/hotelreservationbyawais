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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }


        private void changePasswordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmChangePassword frmCP = new frmChangePassword();
            frmCP.MdiParent = this;
            frmCP.Show();
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Log out of your account?",
            "Hotel Reservation System", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                Database.DisConnect();
                Application.Exit();
            }
        }

        private void creatingReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCreatingReservation frmCR = new frmCreatingReservation();
            frmCR.MdiParent = this;
            frmCR.Show();
        }

        private void modifyingReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModifyingReservation frmMR = new frmModifyingReservation();
            frmMR.MdiParent = this;
            frmMR.Show();
        }

        private void viewingReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewReservations frmVR = new frmViewReservations();
            frmVR.MdiParent = this;
            frmVR.Show();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddCustomer frmAC = new frmAddCustomer();
            frmAC.MdiParent = this;
            frmAC.Show();
        }

        private void updateCustomerToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            frmUpdateCustomer frmUC = new frmUpdateCustomer();
            frmUC.MdiParent = this;
            frmUC.Show();
        }

        private void searchCustomerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSearchCustomer frmSC = new frmSearchCustomer();
            frmSC.MdiParent = this;
            frmSC.Show();
        }

        private void addPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddPayment frmAP = new frmAddPayment();
            frmAP.MdiParent = this;
            frmAP.Show();
        }

        private void modifyPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModifyPayment frmMP = new frmModifyPayment();
            frmMP.MdiParent = this;
            frmMP.Show();
        }

        private void viewPaymentTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewPayment frmVP = new frmViewPayment();
            frmVP.MdiParent = this;
            frmVP.Show();
        }

        private void deleteTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeletePayment frmDP = new frmDeletePayment();
            frmDP.MdiParent = this;
            frmDP.Show();
        }
    }
}
