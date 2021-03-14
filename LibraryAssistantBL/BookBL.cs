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

        public bool AddBookBL(string ISBN, string title, string author, int quantity, double price, string subject, int pageCount)
        {
            BookDAL bookDal = new BookDAL();
            bool ds = bookDal.AddBookDAL(ISBN, title, author, quantity, price, subject, pageCount);
            return ds;
        }

        public bool CheckISBNBL(string ISBN)
        {
            BookDAL bookDal = new BookDAL();
            bool result = bookDal.CheckISBNDAL(ISBN);
            return result;
        }

        public bool EditBookBL(string ISBN, string title, string author, int quantity, double price, string subject, int pageCount, int available, string currentISBN)
        {
            BookDAL bookDal = new BookDAL();
            bool ds = bookDal.EditBookDAL(ISBN, title, author, quantity, price, subject, pageCount, available, currentISBN);
            return ds;
        }
    }
}
