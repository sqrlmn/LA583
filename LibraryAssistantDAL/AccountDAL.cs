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
    }
}
