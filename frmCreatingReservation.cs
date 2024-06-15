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
    public partial class frmCreatingReservation : Form
    {
        Reservation r = new Reservation();
        public frmCreatingReservation()
        {
            InitializeComponent();
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
                return;
            }
             int ReservationID = Convert.ToInt32(txtReservationID.Text);
            DateTime CheckInDate = dtpCheckInDate.Value;
            DateTime  CheckOutDate =dtpCheckOutDate.Value;
            int NumOfGuests= Convert.ToInt32(txtNumOfGuests.Text);
            String RoomType = cbRoomType.Text;
            String SpecialRequests= txtSpecialRequest.Text;
            if (r.CreateReservation(ReservationID, CheckInDate, CheckOutDate, NumOfGuests, RoomType, SpecialRequests))
            {
                MessageBox.Show("Reservation Created");
                txtReservationID.Clear();
                txtNumOfGuests.Clear();
                txtSpecialRequest.Clear();
                cbRoomType.SelectedIndex = -1;  
                
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtReservationID.Clear();
            txtNumOfGuests.Clear();
            cbRoomType.SelectedIndex = -1;
            txtSpecialRequest.Clear();
        }
    }
}
