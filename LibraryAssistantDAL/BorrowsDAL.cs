using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LibraryAssistantDAL
{
    public class BorrowsDAL
    {
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
            MySqlCommand cmd = new MySqlCommand("INSERT INTO borrows (borrowId, bUsername, bISBN, issueDate) VALUES(@ID, @username, @ISBN, (SELECT CURDATE()))", conn);
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
    }
}
