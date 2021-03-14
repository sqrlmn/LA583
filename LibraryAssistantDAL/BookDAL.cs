using System;
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
            MySqlCommand cmd = new MySqlCommand("DELETE FROM borrows WHERE borrowID = @username and bISBN = @isbn", conn);
            MySqlCommand bookAdd = new MySqlCommand("Update FROM books WHERE ISBN = @isbn and availability += 1", conn);
            cmd.Parameters.Add(new MySqlParameter("@username", username));
            cmd.Parameters.Add(new MySqlParameter("@isbn", isbn));
            bookAdd.Parameters.Add(new MySqlParameter("@isbn", isbn));
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
        public bool RemoveBookByISBNDAL(string ISBN)
        {
            MySqlConnection conn = new MySqlConnection("Server=libraryassistant.cwhg663yxudq.us-west-2.rds.amazonaws.com;Database=library;Uid=la583;Pwd=la583password;");
            MySqlCommand cmd = new MySqlCommand("DELETE FROM books WHERE ISBN = @ISBN", conn);
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
        public bool AddBookDAL(string ISBN, string title, string author, int quantity, double price, string subject, int pageCount)
        {

            MySqlConnection conn = new MySqlConnection("Server=libraryassistant.cwhg663yxudq.us-west-2.rds.amazonaws.com;Database=library;Uid=la583;Pwd=la583password;");
            MySqlCommand cmd = new MySqlCommand("INSERT INTO books (ISBN, title, author, quantity, price, subject, available, pageCount, reviewCount, starCount) VALUES(@ISBN, @title, @author, @quantity, @price, @subject, @quantity, @pageCount, 0, 0)", conn);
            cmd.Parameters.Add(new MySqlParameter("@ISBN", ISBN));
            cmd.Parameters.Add(new MySqlParameter("@title", title));
            cmd.Parameters.Add(new MySqlParameter("@author", author));
            cmd.Parameters.Add(new MySqlParameter("@quantity", quantity));
            cmd.Parameters.Add(new MySqlParameter("@price", price));
            cmd.Parameters.Add(new MySqlParameter("@subject", subject));
            cmd.Parameters.Add(new MySqlParameter("@pageCount", pageCount));

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

        public bool CheckISBNDAL(string ISBN)
        {
            MySqlConnection conn = new MySqlConnection("Server=libraryassistant.cwhg663yxudq.us-west-2.rds.amazonaws.com;Database=library;Uid=la583;Pwd=la583password;");
            MySqlCommand cmd = new MySqlCommand("SELECT ISBN FROM books WHERE ISBN=@ISBN", conn);
            cmd.Parameters.Add(new MySqlParameter("@ISBN", ISBN));
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

        public bool EditBookDAL(string ISBN, string title, string author, int quantity, double price, string subject, int pageCount, int available, string currentISBN)
        {

            MySqlConnection conn = new MySqlConnection("Server=libraryassistant.cwhg663yxudq.us-west-2.rds.amazonaws.com;Database=library;Uid=la583;Pwd=la583password;");
            MySqlCommand cmd = new MySqlCommand("UPDATE books SET ISBN = @ISBN, title = @title, pageCount = @pageCount, author = @author, quantity = @quantity, price = @price, subject = @subject, available = @available WHERE(ISBN = @currentISBN)", conn);
            cmd.Parameters.Add(new MySqlParameter("@ISBN", ISBN));
            cmd.Parameters.Add(new MySqlParameter("@title", title));
            cmd.Parameters.Add(new MySqlParameter("@author", author));
            cmd.Parameters.Add(new MySqlParameter("@quantity", quantity));
            cmd.Parameters.Add(new MySqlParameter("@price", price));
            cmd.Parameters.Add(new MySqlParameter("@subject", subject));
            cmd.Parameters.Add(new MySqlParameter("@pageCount", pageCount));
            cmd.Parameters.Add(new MySqlParameter("@available", available));
            cmd.Parameters.Add(new MySqlParameter("@currentISBN", currentISBN));

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
        public void updateBookreviewDAL(string ISBN, int starcount)
        {
            int rc = GetReviewCountDAL(ISBN);
            int sc = GetstarCountDAL(ISBN);
            MySqlConnection conn = new MySqlConnection("Server=libraryassistant.cwhg663yxudq.us-west-2.rds.amazonaws.com;Database=library;Uid=la583;Pwd=la583password;");

            MySqlCommand cmd3 = new MySqlCommand("UPDATE books SET reviewCount = @rc, starCount = @sc WHERE ISBN = @ISBN", conn);
            cmd3.Parameters.Add(new MySqlParameter("@rc", rc + 1));
            cmd3.Parameters.Add(new MySqlParameter("@sc", sc + starcount));
            cmd3.Parameters.Add(new MySqlParameter("@ISBN", ISBN));

            conn.Open();
            cmd3.ExecuteNonQuery();
            conn.Close();
        }
        public int GetReviewCountDAL(string ISBN)
        {
            MySqlConnection conn = new MySqlConnection("Server=libraryassistant.cwhg663yxudq.us-west-2.rds.amazonaws.com;Database=library;Uid=la583;Pwd=la583password;");
            MySqlCommand cmd = new MySqlCommand("SELECT reviewCount FROM books WHERE ISBN = @ISBN", conn);
            cmd.Parameters.Add(new MySqlParameter("@ISBN", ISBN));
            conn.Open();
            string rc = cmd.ExecuteScalar().ToString();
            int brc = Int32.Parse(rc);
            conn.Close();
            return brc;

        }
        public int GetstarCountDAL(string ISBN)
        {
            MySqlConnection conn = new MySqlConnection("Server=libraryassistant.cwhg663yxudq.us-west-2.rds.amazonaws.com;Database=library;Uid=la583;Pwd=la583password;");
            MySqlCommand cmd = new MySqlCommand("SELECT starCount FROM books WHERE ISBN = @ISBN", conn);
            cmd.Parameters.Add(new MySqlParameter("@ISBN", ISBN));
            conn.Open();
            string sc = cmd.ExecuteScalar().ToString();
            int bsc = Int32.Parse(sc);
            conn.Close();
            return bsc;
        }
    }
}
