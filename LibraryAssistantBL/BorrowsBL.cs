using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryAssistantDAL;

namespace LibraryAssistantBL
{
    public class BorrowsBL
    {
        public bool NullCheckForCreateBorrowsInputBL(string username, string ISBN)
        {
            if (username == "" || ISBN == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool CreateBorrowsBL(string username, string ISBN)
        {
            if (NullCheckForCreateBorrowsInputBL(username, ISBN))
            {
                BorrowsDAL borrowsDAL = new BorrowsDAL();
                int maxid = borrowsDAL.GetMaxIDDAL();
                bool create = borrowsDAL.CreateBorrowByUsername(maxid, username, ISBN);
                return create;
            }
            else
            {
                return false;
            }
        }

        public bool NullCheckUsernameInputBL(string username)
        {
            if (username == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool IssueBorrowByUsername(string username)
        {
            if (NullCheckUsernameInputBL(username))
            {
                BorrowsDAL borrowDal = new BorrowsDAL();
                bool removed = borrowDal.ChangeBorrowStatusByUsername(username);
                return removed;
            }
            else
            {
                return false;
            }
        }

        public bool ChangeBorrowStatusByUsernameBL(string username)
        {
            if (NullCheckUsernameInputBL(username))
            {
                BorrowsDAL borrowDal = new BorrowsDAL();
                bool result = borrowDal.ChangeBorrowStatusByUsername(username);
                return result;
            }
            else
            {
                return false;
            }
        }

        public DataSet GetBorrowsBL()
        {
            BorrowsDAL borrowDal = new BorrowsDAL();
            DataSet ds = borrowDal.GetBorrowsDAL();
            return ds;
        }
    }
}
