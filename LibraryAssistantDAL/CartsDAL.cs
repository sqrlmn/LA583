using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LibraryAssistantDAL
{
    class CartsDAL
    {
        public DataSet getCartsDAL(string username)
        {
            MySqlConnection conn = new MySqlConnection("Server=libraryassistant.cwhg663yxudq.us-west-2.rds.amazonaws.com;Database=library;Uid=la583;Pwd=la583password;");
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT accountsUsername, bookISBN, ID ", conn);
            DataSet ds = new DataSet("Books");
            da.Fill(ds);
            return ds;
        }
        public bool CreateCartsbyISBN(string username, string ISBN, int ID)
        {
            ID+=1;
            MySqlConnection conn = new MySqlConnection("Server=libraryassistant.cwhg663yxudq.us-west-2.rds.amazonaws.com;Database=library;Uid=la583;Pwd=la583password;");
            MySqlCommand cmd = new MySqlCommand("INSERT INTO carts (ID, bookISBN, accountsUsername) VALUES(@ID, @ISBN, @username)", conn);
            cmd.Parameters.Add(new MySqlParameter("@maxid", ID));
            cmd.Parameters.Add(new MySqlParameter("@ISBN",ISBN ));
            cmd.Parameters.Add(new MySqlParameter("@username", username));
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
        public int GetMaxIDDAL()
        {
            MySqlConnection conn = new MySqlConnection("Server=libraryassistant.cwhg663yxudq.us-west-2.rds.amazonaws.com;Database=library;Uid=la583;Pwd=la583password;");
            MySqlCommand cmd = new MySqlCommand("SELECT MAX(ID) FROM carts; ", conn);
            conn.Open();
            int id = (int)cmd.ExecuteScalar();
            conn.Close();
            return id;
        }
    }
}
