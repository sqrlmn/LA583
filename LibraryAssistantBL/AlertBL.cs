using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryAssistantDAL;

namespace LibraryAssistantBL
{
    class AlertBL
    {
        public void LoginBL(string username)
        {
            AlertDAL alertDal = new AlertDAL();
            bool isDone = alertDal.AlertUser(username);
            
        }
    }
}
