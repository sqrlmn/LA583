using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LibraryAssistantDAL
{
    public class BorrowsDAL
    {
        // Data: status = 0 have not issued yet; status = 1 issued; status = 2 returned
        public int GetMaxIDDAL()
        {
            MySqlConnection conn = new MySqlConnection("Server=libraryassistant.cwhg663yxudq.us-west-2.rds.amazonaws.com;Database=library;Uid=la583;Pwd=la583password;");
            MySqlCommand cmd = new MySqlCommand("SELECT max(borrowId) FROM borrows; ", conn);
            conn.Open();
            string ID = cmd.ExecuteScalar().ToString();
            if (ID == "")
            {
                ID = "0";
            }
            conn.Close();
            int updateID = Int32.Parse(ID);
            updateID += 1;
            return updateID;
        }

        public bool CreateBorrowByUsername(int id, string username, string ISBN)
        {
            MySqlConnection conn = new MySqlConnection("Server=libraryassistant.cwhg663yxudq.us-west-2.rds.amazonaws.com;Database=library;Uid=la583;Pwd=la583password;");
            MySqlCommand cmd = new MySqlCommand("INSERT INTO borrows (borrowId, bUsername, bISBN, issueDate, status) VALUES(@ID, @username, @ISBN, (SELECT CURDATE()), 0)", conn);
            cmd.Parameters.Add(new MySqlParameter("@ID", id));
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

        public bool ChangeBorrowStatusByUsernameDAL(string username)
        {
            MySqlConnection conn = new MySqlConnection("Server=libraryassistant.cwhg663yxudq.us-west-2.rds.amazonaws.com;Database=library;Uid=la583;Pwd=la583password;");
            MySqlCommand cmd = new MySqlCommand("UPDATE borrows SET status = 1 WHERE bUsername = @username", conn);
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

        public int GetBookAvailableByISBNDAL(string ISBN)
        {
            MySqlConnection conn = new MySqlConnection("Server=libraryassistant.cwhg663yxudq.us-west-2.rds.amazonaws.com;Database=library;Uid=la583;Pwd=la583password;");
            MySqlCommand cmd = new MySqlCommand("SELECT available FROM books WHERE ISBN = @ISBN", conn);
            cmd.Parameters.Add(new MySqlParameter("@ISBN", ISBN));
            conn.Open();
            int avalble = (int)cmd.ExecuteScalar();
            conn.Close();
            return avalble;
        }

        public DataSet GetBorrowsISBNByUsernameDAL(string username)
        {
            MySqlConnection conn = new MySqlConnection("Server=libraryassistant.cwhg663yxudq.us-west-2.rds.amazonaws.com;Database=library;Uid=la583;Pwd=la583password;");
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT bISBN FROM borrows WHERE bUsername = '" + username + "' AND Status = 0", conn);
            DataSet ds = new DataSet("username");
            da.Fill(ds);
            return ds;
        }

        public DataSet GetBorrowsDAL()
        {
            MySqlConnection conn = new MySqlConnection("Server=libraryassistant.cwhg663yxudq.us-west-2.rds.amazonaws.com;Database=library;Uid=la583;Pwd=la583password;");
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT DISTINCT bUsername as User, COUNT(bUsername) AS 'Number of Books' FROM borrows WHERE status = 0 GROUP BY bUsername", conn);
            DataSet ds = new DataSet("Borrows");
            da.Fill(ds);
            return ds;
        }
    }
}
