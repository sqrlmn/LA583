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
            MySqlCommand cmd = new MySqlCommand("SELECT username, password FROM accounts WHERE username=@username and password=@password", conn);
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
            MySqlCommand cmd = new MySqlCommand("SELECT firstName FROM accounts WHERE username=@username", conn);
            cmd.Parameters.Add(new MySqlParameter("@username", username));
            conn.Open();
            string firstName = (string)cmd.ExecuteScalar();
            conn.Close();
            return firstName;
        }

        public string GetUserLastNameDAL(string username)
        {
            MySqlConnection conn = new MySqlConnection("Server=libraryassistant.cwhg663yxudq.us-west-2.rds.amazonaws.com;Database=library;Uid=la583;Pwd=la583password;");
            MySqlCommand cmd = new MySqlCommand("SELECT lastName FROM accounts WHERE username=@username", conn);
            cmd.Parameters.Add(new MySqlParameter("@username", username));
            conn.Open();
            string lastName = (string)cmd.ExecuteScalar();
            conn.Close();
            return lastName;
        }

        public bool GetUserTypeDAL(string username)
        {
            MySqlConnection conn = new MySqlConnection("Server=libraryassistant.cwhg663yxudq.us-west-2.rds.amazonaws.com;Database=library;Uid=la583;Pwd=la583password;");
            MySqlCommand cmd = new MySqlCommand("SELECT type FROM accounts WHERE username=@username", conn);
            cmd.Parameters.Add(new MySqlParameter("@username", username));
            conn.Open();
            bool type = (bool)cmd.ExecuteScalar();
            conn.Close();
            return type;
        }

        public string GetUserEmailDAL(string username)
        {
            MySqlConnection conn = new MySqlConnection("Server=libraryassistant.cwhg663yxudq.us-west-2.rds.amazonaws.com;Database=library;Uid=la583;Pwd=la583password;");
            MySqlCommand cmd = new MySqlCommand("SELECT emailAddress FROM accounts WHERE username=@username", conn);
            cmd.Parameters.Add(new MySqlParameter("@username", username));
            conn.Open();
            string email = (string)cmd.ExecuteScalar();
            conn.Close();
            return email;
        }

        public string GetUserAddressDAL(string username)
        {
            MySqlConnection conn = new MySqlConnection("Server=libraryassistant.cwhg663yxudq.us-west-2.rds.amazonaws.com;Database=library;Uid=la583;Pwd=la583password;");
            MySqlCommand cmd = new MySqlCommand("SELECT address FROM accounts WHERE username=@username", conn);
            cmd.Parameters.Add(new MySqlParameter("@username", username));
            conn.Open();
            string address = (string)cmd.ExecuteScalar();
            conn.Close();
            return address;
        }

        public string GetUserPhoneDAL(string username)
        {
            MySqlConnection conn = new MySqlConnection("Server=libraryassistant.cwhg663yxudq.us-west-2.rds.amazonaws.com;Database=library;Uid=la583;Pwd=la583password;");
            MySqlCommand cmd = new MySqlCommand("SELECT phoneNumber FROM accounts WHERE username=@username", conn);
            cmd.Parameters.Add(new MySqlParameter("@username", username));
            conn.Open();
            string phone = (string)cmd.ExecuteScalar();
            conn.Close();
            return phone;
        }
    }
}
