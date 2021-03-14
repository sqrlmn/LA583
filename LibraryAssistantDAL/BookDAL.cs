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
        public bool AddBookDAL(string ISBN, string title, string author, int quantity, float price, string subject, int available, string book_condition)
        {

            MySqlConnection conn = new MySqlConnection("Server=libraryassistant.cwhg663yxudq.us-west-2.rds.amazonaws.com;Database=library;Uid=la583;Pwd=la583password;");
            MySqlCommand cmd = new MySqlCommand("INSERT INTO books (ISBN, title, author,quantity,price,subject,available,bookCondition) VALUES(@ISBN, @title, @author, @quantity, @price, @subject, @available,@book_condition)", conn);
            cmd.Parameters.Add(new MySqlParameter("@ISBN", ISBN));
            cmd.Parameters.Add(new MySqlParameter("@title", title));
            cmd.Parameters.Add(new MySqlParameter("@author", author));
            cmd.Parameters.Add(new MySqlParameter("@quantity", quantity));
            cmd.Parameters.Add(new MySqlParameter("@price", price));
            cmd.Parameters.Add(new MySqlParameter("@subject", subject));
            cmd.Parameters.Add(new MySqlParameter("@avialable", available));
            cmd.Parameters.Add(new MySqlParameter("@book_condition", book_condition));

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
