using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LibraryAssistantDAL
{
    public  class CartsDAL
    {
        public DataSet getCartsDAL(string username)
        {
            MySqlConnection conn = new MySqlConnection("Server=libraryassistant.cwhg663yxudq.us-west-2.rds.amazonaws.com;Database=library;Uid=la583;Pwd=la583password;");
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT accountsUsername, bookISBN, ID ", conn);
            DataSet ds = new DataSet("Books");
            da.Fill(ds);
            return ds;
        }

        public bool CreateCartsbyUsername(string username, string ISBN, int ID)
        {
            
            MySqlConnection conn = new MySqlConnection("Server=libraryassistant.cwhg663yxudq.us-west-2.rds.amazonaws.com;Database=library;Uid=la583;Pwd=la583password;");
            MySqlCommand cmd = new MySqlCommand("INSERT INTO carts (ID, bookISBN, accountsUsername) VALUES(@ID, @ISBN, @username)", conn);
            cmd.Parameters.Add(new MySqlParameter("@ID", ID));
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
            MySqlCommand cmd = new MySqlCommand("SELECT max(ID) FROM carts; ", conn);
            conn.Open();
            string id = cmd.ExecuteScalar().ToString();
            if (id == "")
            {
                id = "0";
            }
            conn.Close();
            int updateid = Int32.Parse(id);
            updateid += 1;
            return updateid;
        }

        public bool RemoveCartsbyUsername(string username)
        {
            MySqlConnection conn = new MySqlConnection("Server=libraryassistant.cwhg663yxudq.us-west-2.rds.amazonaws.com;Database=library;Uid=la583;Pwd=la583password;");
            MySqlCommand cmd = new MySqlCommand("DELETE FROM carts WHERE accountsUsername = @username", conn);
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

        public bool RemoveCartsbyISBN(string username, string ISBN)
        {
            MySqlConnection conn = new MySqlConnection("Server=libraryassistant.cwhg663yxudq.us-west-2.rds.amazonaws.com;Database=library;Uid=la583;Pwd=la583password;");
            MySqlCommand cmd = new MySqlCommand("DELETE FROM carts WHERE accountsUsername = @username and bookISBN = @ISBN", conn);
            cmd.Parameters.Add(new MySqlParameter("@username", username));
            cmd.Parameters.Add(new MySqlParameter("@ISBN", ISBN));
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

        public bool cartisEmpty()
        {
            MySqlConnection conn = new MySqlConnection("Server=libraryassistant.cwhg663yxudq.us-west-2.rds.amazonaws.com;Database=library;Uid=la583;Pwd=la583password;");
            MySqlCommand cmd = new MySqlCommand("select count(*) from carts " , conn);
            conn.Open();
            int rowAffected = cmd.ExecuteNonQuery();
            conn.Close();
            if(rowAffected==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataSet getCartsinfobyusername(string username)
        {
            MySqlConnection conn = new MySqlConnection("Server=libraryassistant.cwhg663yxudq.us-west-2.rds.amazonaws.com;Database=library;Uid=la583;Pwd=la583password;");
            MySqlCommand cmd = new MySqlCommand("SELECT c.bookISBN, b.title, b.author, b.subject FROM carts as c INNER JOIN books as b ON c.bookISBN = b.ISBN INNER JOIN accounts as a ON c.accountsUsername = a.username where c.accountsUsername=@username;", conn);
            cmd.Parameters.Add(new MySqlParameter("@username", username));
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet("carts");
            da.Fill(ds);
            return ds;
        }
    }
}
