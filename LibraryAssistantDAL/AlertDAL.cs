﻿using System;
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
            MySqlCommand cmd = new MySqlCommand("SELECT returnTime FROM alerts WHERE returnTime=@date and username=@username", conn);
            DateTime date = DateTime.Today;
            cmd.Parameters.Add(new MySqlParameter("@date", date));
            cmd.Parameters.Add(new MySqlParameter("@username", username));
            conn.Open();
            try
            {
                DateTime sql_date = (DateTime)cmd.ExecuteScalar();
                if (date == sql_date)
                {
                    conn.Close();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }

        }

        public bool GetBookAvailableDAL(string username)
        {
            MySqlConnection conn = new MySqlConnection("Server=libraryassistant.cwhg663yxudq.us-west-2.rds.amazonaws.com;Database=library;Uid=la583;Pwd=la583password;");
            MySqlCommand cmd = new MySqlCommand("SELECT username, bookavailable FROM alerts WHERE bookAvailable > 0 and username=@username", conn);
            cmd.Parameters.Add(new MySqlParameter("@username", username));
            conn.Open();
            MySqlDataReader alertCheck = cmd.ExecuteReader();
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
            MySqlConnection conn = new MySqlConnection("Server=libraryassistant.cwhg663yxudq.us-west-2.rds.amazonaws.com;Database=library;Uid=la583;Pwd=la583password;Convert Zero Datetime=True;");
            string query = "INSERT INTO alerts (alertID, username, returnTime)";
            query += " Values (@alertID, @username, @returnTime)";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.Add(new MySqlParameter("@alertID", alertID));
            cmd.Parameters.Add(new MySqlParameter("@username", username));
            cmd.Parameters.Add(new MySqlParameter("@returnTime", returnTime));
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
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
            MySqlConnection conn = new MySqlConnection("Server=libraryassistant.cwhg663yxudq.us-west-2.rds.amazonaws.com;Database=library;Uid=la583;Pwd=la583password;");
            string query = "INSERT INTO alerts (alertID, username, bookAvailable, conent)";
            query += " Values (@alertID, @username, @bookAvailable, @content)";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.Add(new MySqlParameter("@alertID", alertID));
            cmd.Parameters.Add(new MySqlParameter("@username", username));
            cmd.Parameters.Add(new MySqlParameter("@bookAvailable", bookAvailable));
            cmd.Parameters.Add(new MySqlParameter("@content", bookname));
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
            MySqlCommand cmd = new MySqlCommand("SELECT alerts FROM accounts WHERE username=@username ", conn);
            cmd.Parameters.Add(new MySqlParameter("@username", username));
            conn.Open();
            string phone = (string)cmd.ExecuteScalar();
            conn.Close();
            return true;
        }
    }
}
