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
        public bool AlertUserDAL(string username)
        {
            MySqlConnection conn = new MySqlConnection("Server=libraryassistant.cwhg663yxudq.us-west-2.rds.amazonaws.com;Database=library;Uid=la583;Pwd=la583password;");
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM alerts WHERE date(returnTime)=@date", conn);
            string date = DateTime.Now.ToString("M/d/yyyy");
            cmd.Parameters.Add(new MySqlParameter("@date", date));
            return true;
        }

        public bool SetAlertReturnDAL(string username, int alertID, string returnTime)
        {
            MySqlConnection conn = new MySqlConnection("Server=libraryassistant.cwhg663yxudq.us-west-2.rds.amazonaws.com;Database=library;Uid=la583;Pwd=la583password;");
            string query = "INSERT INTO alerts (alertID, username, returnTime)";
            query += " Values (@alertID, @username, @returnTime)";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.Add(new MySqlParameter("@alertID", alertID));
            cmd.Parameters.Add(new MySqlParameter("@username", username));
            cmd.Parameters.Add(new MySqlParameter("@returnTime", returnTime));
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

       // public bool SetAlertBookAvailableDAL(string username, )
    }
}
