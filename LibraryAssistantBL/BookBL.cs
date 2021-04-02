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
        }//output

        public bool NullCheckForUsernameAndISBNReturnBookBL(string username, string isbn)
        {
            if (username == "" || isbn == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool ReturnBookBL(string username, string isbn)
        {
            if (NullCheckForUsernameAndISBNReturnBookBL(username, isbn))
            {
                BookDAL bookDal = new BookDAL();
                bool ds = bookDal.ReturnBookDAL(username, isbn);
                return ds;
            }
            else
            {
                return false;
            }
        }

        public bool NullCheckForISBNInputBL(string ISBN)
        {
            if (ISBN == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool RemoveBookBL(string ISBN)
        {
            if (NullCheckForISBNInputBL(ISBN))
            {
                BookDAL bookDal = new BookDAL();
                bool ds = bookDal.RemoveBookByISBNDAL(ISBN);
                return ds;
            }
            else
            {
                return false;
            }
        }

        public bool NullCheckForISBNAndTitleAndAuthorAndSubjectAddBookBL(string ISBN, string title, string author, string subject)
        {
            if (ISBN == "" || title == "" || author == "" || subject == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool AddBookBL(string ISBN, string title, string author, int quantity, double price, string subject, int pageCount)
        {
            if (NullCheckForISBNAndTitleAndAuthorAndSubjectAddBookBL(ISBN, title, author, subject))
            {

                BookDAL bookDal = new BookDAL();
                bool ds = bookDal.AddBookDAL(ISBN, title, author, quantity, price, subject, pageCount);
                return ds;
            }
            else
            {
                return false;
            }
        }


        public bool CheckISBNBL(string ISBN)
        {
            if (NullCheckForISBNInputBL(ISBN))
            {
                BookDAL bookDal = new BookDAL();
                bool result = bookDal.CheckISBNDAL(ISBN);
                return result;
            }
            else
            {
                return false;
            }
        }

        public bool NullCheckForISBNAndTitleAndAuthorAndSubjectEditBookBL(string ISBN, string title, string author, string subject, string currentISBN)
        {
            if (ISBN == "" || title == "" || author == "" || subject == "" || currentISBN == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool EditBookBL(string ISBN, string title, string author, int quantity, double price, string subject, int pageCount, int available, string currentISBN)
        {
            if (NullCheckForISBNAndTitleAndAuthorAndSubjectEditBookBL(ISBN, title, author, subject, currentISBN))
            {
                BookDAL bookDal = new BookDAL();
                bool ds = bookDal.EditBookDAL(ISBN, title, author, quantity, price, subject, pageCount, available, currentISBN);
                return ds;
            }
            else
            {
                return false;
            }
        }

        public bool UpdatebookRateBL(string ISBN, int starcount)
        {
            if (NullCheckForISBNInputBL(ISBN))
            {
                BookDAL bookDal = new BookDAL();
                bool ds = bookDal.updateBookreviewDAL(ISBN, starcount);
                return ds;
            }
            else
            {
                return false;
            }
        }

        public bool DecreaseAvailableBL(string ISBN, int available)
        {
            if (NullCheckForISBNInputBL(ISBN))
            {
                BookDAL bookDal = new BookDAL();
                bool ds = bookDal.DecreaseAvailableDAL(ISBN, available);
                return ds;
            }
            else
            {
                return false;
            }
        }

        public bool IncreaseAvailableBL(string ISBN, int available)
        {
            if (NullCheckForISBNInputBL(ISBN))
            {
                BookDAL bookDal = new BookDAL();
                bool ds = bookDal.IncreaseAvailableDAL(ISBN, available);
                return ds;
            }
            else
            {
                return false;
            }
        }
    }
}
