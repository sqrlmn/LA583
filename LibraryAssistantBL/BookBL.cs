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
    }
}
