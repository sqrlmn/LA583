using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryAssistantDAL;

namespace LibraryAssistantBL
{
    public class AccountBL
    {
        public bool LoginBL(string username, string password)
        {
            AccountDAL accountDal = new AccountDAL();
            bool isDone = accountDal.LoginDAL(username, password);
            return isDone;
        }
    }
}
