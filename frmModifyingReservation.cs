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
    public partial class frmModifyingReservation : Form
    {
        Reservation r = new Reservation();
        public frmModifyingReservation()
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvReservation.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvReservation.SelectedRows[0];
                txtReservationID.Text = row.Cells[0].Value.ToString();
                dtpCheckInDate.Value = Convert.ToDateTime(row.Cells[1].Value);

                dtpCheckOutDate.Value= Convert.ToDateTime(row.Cells[2].Value);
                txtNumOfGuests.Text = row.Cells[3].Value.ToString();
                cbRoomType.Text = row.Cells[4].Value.ToString();
                txtSpecialRequest.Text = row.Cells[5].Value.ToString();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
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

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtReservationID.Text == "")
            {
                MessageBox.Show("Enter Reservation Id");
                return;
            }
            if (txtNumOfGuests.Text == "")
            {
                MessageBox.Show("Enter Number Of Guests");
                return;
            }
            if (cbRoomType.SelectedIndex == -1)
            {
                MessageBox.Show("Select RoomType");
            }
                        int ReservationID = Convert.ToInt32(txtReservationID.Text);
            DateTime CheckInDate = dtpCheckInDate.Value;
            DateTime CheckOutDate = dtpCheckOutDate.Value;
            int NumOfGuests = Convert.ToInt32(txtNumOfGuests.Text);
            String RoomType = cbRoomType.Text;
            String SpecialRequests = txtSpecialRequest.Text;
            if (r.UpdateReservation(ReservationID, CheckInDate, CheckOutDate, NumOfGuests, RoomType, SpecialRequests))
            {
                MessageBox.Show("Reservation Updated");
                txtReservationID.Clear();
                txtNumOfGuests.Clear();
                txtSpecialRequest.Clear();
                cbRoomType.SelectedIndex = -1;  
                ShowReservations();
            }
        }

       
    }
}
