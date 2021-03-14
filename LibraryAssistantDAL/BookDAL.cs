﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LibraryAssistantDAL
{
    public class BookDAL
    {
        public DataSet GetBooksDAL(string keyword)
        {
            MySqlConnection conn = new MySqlConnection("Server=libraryassistant.cwhg663yxudq.us-west-2.rds.amazonaws.com;Database=library;Uid=la583;Pwd=la583password;");
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT ISBN, title AS Title, author AS Author, subject AS Subject, pageCount AS 'Number of Pages', quantity AS 'Number of Copies', IF (reviewCount > 0, starCount/reviewCount, NULL) AS Rating FROM books " +
                "WHERE Title LIKE '%" + keyword + "%' OR Subject = '" + keyword + "' OR Author = '" + keyword + "'", conn);
            DataSet ds = new DataSet("Books");
            da.Fill(ds);
            return ds;
        }

        public bool ReturnBookDAL(string username, string isbn)
        {
            MySqlConnection conn = new MySqlConnection("Server=libraryassistant.cwhg663yxudq.us-west-2.rds.amazonaws.com;Database=library;Uid=la583;Pwd=la583password;");

            MySqlCommand cmd = new MySqlCommand("SELECT availability FROM books WHERE ISBN = @isbn", conn);
            cmd.Parameters.Add(new MySqlParameter("@username", username));
            conn.Open();
            int avail = cmd.ExecuteNonQuery();
            conn.Close();


            MySqlCommand cmd2 = new MySqlCommand("DELETE FROM borrows WHERE borrowID = @username and bISBN = @isbn", conn);
            MySqlCommand bookAdd = new MySqlCommand("UPDATE books SET  availability = @avail WHERE ISBN = @isbn", conn);
            cmd2.Parameters.Add(new MySqlParameter("@username", username));
            cmd2.Parameters.Add(new MySqlParameter("@isbn", isbn));
            bookAdd.Parameters.Add(new MySqlParameter("@isbn", isbn));
            bookAdd.Parameters.Add(new MySqlParameter("@avail", avail + 1));

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
