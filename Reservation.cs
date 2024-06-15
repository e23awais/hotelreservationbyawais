using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace HotelReservationSystem
{
    public class Reservation
    {
        public bool CreateReservation(int ReservationID, DateTime CheckInDate, DateTime CheckOutDate, int NumOfGuests, String RoomType, String SpecialRequests)
        {
            String query = "insert into Reservation(ReservationID,CheckInDate,CheckOutDate,NumOfGuests,RoomType,SpecialRequests )values(@ReservationID,@CheckInDate,@CheckOutDate,@NumOfGuests,@RoomType,@SpecialRequests )";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = Database.GetConnection();
            cmd.Parameters.AddWithValue("@ReservationID", ReservationID);
            cmd.Parameters.AddWithValue("@CheckInDate", CheckInDate);
            cmd.Parameters.AddWithValue("@CheckOutDate", CheckOutDate);
            cmd.Parameters.AddWithValue("@NumOfGuests", NumOfGuests);
            cmd.Parameters.AddWithValue("@RoomType", RoomType);
            cmd.Parameters.AddWithValue("@SpecialRequests", SpecialRequests);
            bool success = false;
            try
            {
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                    success = true;
                else
                    success = false;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return success;
        }
        public DataTable ShowReservation()
        {
            String query = "Select * from Reservation";
            SqlDataAdapter da;
            da = new SqlDataAdapter(query, Database.GetConnection());
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
            }

            catch (SqlException ex)

            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
        public DataTable SearchReservation(int ReservationID)
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Reservation WHERE ReservationID = @ReservationID";
            SqlCommand cmd = new SqlCommand(query, Database.GetConnection());
            {
                cmd.Parameters.AddWithValue("@ReservationID",ReservationID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }
        public bool CancelReservation(int  ReservationID)
        {
            String query = "Delete from Reservation where ReservationID= @ReservationID";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = Database.GetConnection();
            cmd.Parameters.AddWithValue("@ReservationID", ReservationID);
            bool success = false;
            try
            {
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                    success = true;
                else
                    success = false;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return success;
        }
        public bool UpdateReservation(int ReservationID, DateTime CheckInDate, DateTime CheckOutDate, int NumOfGuests, String RoomType, String SpecialRequests)
        {
            String query = "Update Reservation set CheckInDate = @CheckInDate , CheckOutDate = @CheckOutDate ,NumOfGuests =  @NumOfGuests ,RoomType = @RoomType,SpecialRequests = @SpecialRequests  where ReservationID = @ReservationID";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = Database.GetConnection();
            cmd.Parameters.AddWithValue("@ReservationID", ReservationID);
            cmd.Parameters.AddWithValue("@CheckInDate", CheckInDate);
            cmd.Parameters.AddWithValue("@CheckOutDate", CheckOutDate);
            cmd.Parameters.AddWithValue("@NumOfGuests", NumOfGuests);
            cmd.Parameters.AddWithValue("@RoomType", RoomType);
            cmd.Parameters.AddWithValue("@SpecialRequests", SpecialRequests);
            bool success = false;
            try
            {
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                    success = true;
                else
                    success = false;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return success;
        }

    }

}

