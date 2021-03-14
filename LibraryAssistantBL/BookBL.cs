using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryAssistantDAL;

namespace LibraryAssistantBL
{
    public class BookBL
    {
        public DataSet GetBooksBL(string keyword)
        {
            BookDAL bookDal = new BookDAL();
            DataSet ds = bookDal.GetBooksDAL(keyword);
            return ds;
        }

        public bool ReturnBookBL(string username, string isbn)
        {
            BookDAL bookDal = new BookDAL();
            bool ds = bookDal.ReturnBookDAL(username, isbn);
            return ds;
        }
        public bool RemoveBookBL(string ISBN)
        {
            BookDAL bookDal = new BookDAL();
            bool ds = bookDal.RemoveBookByISBNDAL(ISBN);
            return ds;
        }
        public bool AddBookBL(string ISBN, string title, string author, int quantity, float price, string subject, int available, string book_condition)
        {
            BookDAL bookDal = new BookDAL();
            bool ds = bookDal.AddBookDAL(ISBN, title, author, quantity, price, subject, available, book_condition);
            return ds;

        }
    }
}
