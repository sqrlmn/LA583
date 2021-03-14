using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryAssistantDAL;

namespace LibraryAssistantBL
{
    public class AlertBL
    {
        public bool GetAlertUserBL(string username)
        {
            AlertDAL alertDal = new AlertDAL();
            bool isDone = alertDal.GetAlertUserReturnDAL(username);
            return isDone;
        }

        public bool SetAlertReturnBL(string username, int alertID, DateTime returnTime)
        {
            AlertDAL alertDal = new AlertDAL();
            bool isDone = alertDal.SetAlertReturnDAL(username, alertID, returnTime);
            return isDone;
        }

        public bool SetAlertBookAvailableBL(string username, int bookAvailable, int alertID, string bookname)
        {
            AlertDAL alertDal = new AlertDAL();
            bool isDone = alertDal.SetAlertBookAvailableDAL(username, alertID, alertID, bookname);
            return isDone;
        }


    }
}
