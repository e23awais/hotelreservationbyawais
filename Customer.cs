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
    public class Customer
    {
        public bool CreateCustomer(int CustomerID, String FirstName, String LastName, String Address, String Email, String Phone)
        {
            String query = "insert into Customer(CustomerID,FirstName,LastName,Address,Email,Phone )values(@CustomerID,@FirstName,@LastName,@Address,@Email,@Phone)";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = Database.GetConnection();
            cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@Phone", Phone);
            
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
        public DataTable ShowCustomer()
        {
            String query = "Select * from Customer";
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
        public DataTable SearchCustomer(int CustomerID)
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Customer WHERE CustomerID = @CustomerID";
            SqlCommand cmd = new SqlCommand(query, Database.GetConnection());
            {
                cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }
        public bool DeleteCustomer(int CustomerID)
        {
            String query = "Delete from Customer where CustomerID= @CustomerID";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = Database.GetConnection();
            cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
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
        public bool UpdateCustomer(int CustomerID, String FirstName, String LastName, String Address, String Email, String Phone)
        {
            String query = "Update Customer set FirstName = @FirstName , LastName = @LastName ,Address =  @Address ,Email = @Email,Phone = @Phone  where CustomerID = @CustomerID";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = Database.GetConnection();
            cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@Phone", Phone);
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
