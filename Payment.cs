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
    public class Payment
    {
        public bool AddPayment(int PaymentID, int ReservationID, int CustomerID, String PaymentMethod, String CardNumber, DateTime ExpiryDate,String PaymentAmount)
        {
            String query = "insert into Payment(PaymentID,ReservationID,CustomerID,PaymentMethod,CardNumber,ExpiryDate,PaymentAmount)values(@PaymentID,@ReservationID,@CustomerID,@PaymentMethod,@CardNumber,@ExpiryDate,@PaymentAmount)";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = Database.GetConnection();
            cmd.Parameters.AddWithValue("@PaymentID", PaymentID);
            cmd.Parameters.AddWithValue("@ReservationID", ReservationID);
            cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
            cmd.Parameters.AddWithValue("@PaymentMethod", PaymentMethod);
            cmd.Parameters.AddWithValue("@CardNumber", CardNumber);
            cmd.Parameters.AddWithValue("@ExpiryDate", ExpiryDate);
            cmd.Parameters.AddWithValue("@PaymentAmount", PaymentAmount);
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
        public DataTable ShowPayment()
        {
            String query = "Select * from Payment";
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
        public DataTable SearchPayment(int PaymentID)
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Payment WHERE PaymentID = @PaymentID";
            SqlCommand cmd = new SqlCommand(query, Database.GetConnection());
            {
                cmd.Parameters.AddWithValue("@PaymentID", PaymentID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }
        public bool DeletePayment(int PaymentID)
        {
            String query = "Delete from Payment where PaymentID= @PaymentID";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = Database.GetConnection();
            cmd.Parameters.AddWithValue("@PaymentID", PaymentID);
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

        public bool ModifyPayment(int PaymentID, int ReservationID, int CustomerID, String PaymentMethod, String CardNumber, DateTime ExpiryDate, String PaymentAmount)
        {
            String query = "Update Payment set ReservationID = @ReservationID ,CustomerID=@CustomerID, PaymentMethod = @PaymentMethod ,CardNumber =  @CardNumber ,ExpiryDate = @ExpiryDate,PaymentAmount = @PaymentAmount  where PaymentID = @PaymentID";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = Database.GetConnection();
            cmd.Parameters.AddWithValue("@PaymentID", PaymentID);
            cmd.Parameters.AddWithValue("@ReservationID", ReservationID);
            cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
            cmd.Parameters.AddWithValue("@PaymentMethod", PaymentMethod);
            cmd.Parameters.AddWithValue("@CardNumber", CardNumber);
            cmd.Parameters.AddWithValue("@ExpiryDate", ExpiryDate);
            cmd.Parameters.AddWithValue("@PaymentAmount", PaymentAmount);
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
 


