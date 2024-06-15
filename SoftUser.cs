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
    public class SoftUser
    {
        public bool LoginUser(String UserId, String Password)
        {
            string query = "select * from HotelUser where UserId=@UserId and Password=@Password";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = Database.GetConnection();
            cmd.Parameters.AddWithValue("@UserId", UserId);
            cmd.Parameters.AddWithValue("@Password", Password);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            bool found = false;
            try
            {
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                    found = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return found;
        }
        public bool PasswordAuthentication(String Password)
        {
            string query = "select Password from HotelUser ";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = Database.GetConnection();
            cmd.Parameters.AddWithValue("@Password", Password);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            bool found = false;
            try
            {
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                    found = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return found;
        }
        public bool UpdatePassword( String Password)
        {
            String query = "Update HotelUser set Password=@Password";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = Database.GetConnection();
            cmd.Parameters.AddWithValue("@Password", Password);
           
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
