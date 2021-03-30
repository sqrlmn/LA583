using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace LibraryAssistantDAL
{
    public class AlertDAL
    {
        public bool GetAlertUserReturnDAL(string username)
        {

            MySqlConnection conn = new MySqlConnection("Server=libraryassistant.cwhg663yxudq.us-west-2.rds.amazonaws.com;Database=library;Uid=la583;Pwd=la583password;Convert Zero Datetime=True;");
            MySqlCommand cmd = new MySqlCommand("SELECT returnTime FROM alerts WHERE returnTime=@date and username=@username", conn); // getting the return date of books that the user has checked out
            DateTime date = DateTime.Today; // todays date
            cmd.Parameters.Add(new MySqlParameter("@date", date)); 
            cmd.Parameters.Add(new MySqlParameter("@username", username));
            conn.Open();
            try
            {
                DateTime sql_date = (DateTime)cmd.ExecuteScalar(); // getting the date from the database if possible
                if (date == sql_date)
                {
                    conn.Close();
                    return true;
                }
                return false; // if the date does not match todays date it returns false
            }
            catch
            {
                return false; // if no object exists it returns false
            }
        }

        public bool GetBookAvailableDAL(string username)
        {
            MySqlConnection conn = new MySqlConnection("Server=libraryassistant.cwhg663yxudq.us-west-2.rds.amazonaws.com;Database=library;Uid=la583;Pwd=la583password;");
            MySqlCommand cmd = new MySqlCommand("SELECT username, bookavailable FROM alerts WHERE bookAvailable > 0 and username=@username", conn); // grabbing username of user reserving book and finding the amount of books available
            cmd.Parameters.Add(new MySqlParameter("@username", username));
            conn.Open();
            MySqlDataReader alertCheck = cmd.ExecuteReader(); // checking if there is data
            if (alertCheck.Read())
            {
                conn.Close();
                alertCheck.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool SetAlertReturnDAL(string username, int alertID, DateTime returnTime)
        {
            MySqlConnection conn = new MySqlConnection("Server=libraryassistant.cwhg663yxudq.us-west-2.rds.amazonaws.com;Database=library;Uid=la583;Pwd=la583password;");
            string query = "INSERT INTO alerts (alertID, username, returnTime)"; // setting values of the database to set book return date
            query += " Values (@alertID, @username, @returnTime)"; // the agruments passed into the function being set to database
            MySqlCommand cmd = new MySqlCommand(query, conn); // send command
            cmd.Parameters.Add(new MySqlParameter("@alertID", alertID));
            cmd.Parameters.Add(new MySqlParameter("@username", username));
            cmd.Parameters.Add(new MySqlParameter("@returnTime", returnTime));
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read()) // make sure data is to be read
            {
                conn.Close();
                dr.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool SetAlertBookAvailableDAL(string username, int bookAvailable, int alertID, string bookname)
        {
            MySqlConnection conn = new MySqlConnection("Server=libraryassistant.cwhg663yxudq.us-west-2.rds.amazonaws.com;Database=library;Uid=la583;Pwd=la583password;Convert Zero Datetime=True;");
            string query = "INSERT INTO alerts (alertID, username, bookAvailable)"; // setting values of the database to set book return date
            query += " Values (@alertID, @username, @bookAvailable)"; // the agruments passed into the function being set to database
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.Add(new MySqlParameter("@alertID", alertID));
            cmd.Parameters.Add(new MySqlParameter("@username", username));
            cmd.Parameters.Add(new MySqlParameter("@bookAvailable", bookAvailable));
            //cmd.Parameters.Add(new MySqlParameter("@content", bookname));
            conn.Open();
            int rowAffected = cmd.ExecuteNonQuery();
            conn.Close();
            if (rowAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateBookAvailableDAL(string username)
        {
            MySqlConnection conn = new MySqlConnection("Server=libraryassistant.cwhg663yxudq.us-west-2.rds.amazonaws.com;Database=library;Uid=la583;Pwd=la583password;");
            MySqlCommand cmd = new MySqlCommand("SELECT alerts FROM accounts WHERE username=@username ", conn); // cheking if book available
            cmd.Parameters.Add(new MySqlParameter("@username", username));
            conn.Open();
            string phone = (string)cmd.ExecuteScalar();
            conn.Close();
            return true;
        }
    }
}
