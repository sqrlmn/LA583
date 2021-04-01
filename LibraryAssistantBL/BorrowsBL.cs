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
        public bool CreateBorrowsBL(string username, string ISBN)
        {
            BorrowsDAL borrowsDAL = new BorrowsDAL();
            int maxid = borrowsDAL.GetMaxIDDAL();
            bool create = borrowsDAL.CreateBorrowByUsername(maxid, username, ISBN);
            return create;
        }
    }
}
