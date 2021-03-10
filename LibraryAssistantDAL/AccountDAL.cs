using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LibraryAssistantDAL
{
    public class AccountDAL
    {
        public bool LoginDAL(string username, string password)
        {
            MySqlConnection conn = new MySqlConnection("Server=libraryassistant.cwhg663yxudq.us-west-2.rds.amazonaws.com;Database=library;Uid=la583;Pwd=la583password;");
            MySqlCommand cmd = new MySqlCommand("SELECT accountId, accountPw FROM accounts WHERE accountId=@username and accountPw=@password", conn);
            cmd.Parameters.Add(new MySqlParameter("@username", username));
            cmd.Parameters.Add(new MySqlParameter("@password", password));
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

        public string GetUserFirstNameDAL(string username)
        {
            MySqlConnection conn = new MySqlConnection("Server=libraryassistant.cwhg663yxudq.us-west-2.rds.amazonaws.com;Database=library;Uid=la583;Pwd=la583password;");
            MySqlCommand cmd = new MySqlCommand("SELECT firstName FROM accounts WHERE accountId=@username", conn);
            cmd.Parameters.Add(new MySqlParameter("@username", username));
            conn.Open();
            string firstName = (string)cmd.ExecuteScalar();
            conn.Close();
            return firstName;
        }

        public string GetUserLastNameDAL(string username)
        {
            MySqlConnection conn = new MySqlConnection("Server=libraryassistant.cwhg663yxudq.us-west-2.rds.amazonaws.com;Database=library;Uid=la583;Pwd=la583password;");
            MySqlCommand cmd = new MySqlCommand("SELECT lastName FROM accounts WHERE accountId=@username", conn);
            cmd.Parameters.Add(new MySqlParameter("@username", username));
            conn.Open();
            string lastName = (string)cmd.ExecuteScalar();
            conn.Close();
            return lastName;
        }

        public bool GetUserTypeDAL(string username)
        {
            MySqlConnection conn = new MySqlConnection("Server=libraryassistant.cwhg663yxudq.us-west-2.rds.amazonaws.com;Database=library;Uid=la583;Pwd=la583password;");
            MySqlCommand cmd = new MySqlCommand("SELECT type FROM accounts WHERE accountId=@username", conn);
            cmd.Parameters.Add(new MySqlParameter("@username", username));
            conn.Open();
            bool type = (bool)cmd.ExecuteScalar();
            conn.Close();
            return type;
        }
    }
}
