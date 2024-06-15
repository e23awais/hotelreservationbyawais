using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelReservationSystem
{
    public partial class frmViewReservations : Form
    {
        Reservation r = new Reservation();
        public frmViewReservations()
        {
            InitializeComponent();
            ShowReservations();
        }

       private void ShowReservations()
        {

            dgvReservation.DataSource = r.ShowReservation();
            dgvReservation.ReadOnly = true;
            dgvReservation.Refresh();
        }

        private void btnViewSearch_Click(object sender, EventArgs e)
        {
            if (txtReservationID.Text == "")
            {
                MessageBox.Show("Please enter Reservations to search");
                return;
            }

            int ReservationID = Convert.ToInt32(txtReservationID.Text);
            DataTable dt = r.SearchReservation(ReservationID);

            if (dt.Rows.Count > 0)
            {
                dgvReservation.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No Reservation found for ReservationID " + ReservationID);
            }

        }

        private void btnViewCancel_Click(object sender, EventArgs e)
        {
            txtReservationID.Clear();
        }
    }
}
