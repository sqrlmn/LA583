using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryAssistantDAL;

namespace LibraryAssistantBL
{
    public class ReservationBL
    {
        public string GetReservationBL(string keyword)
        {
            ReservationDAL reservationDal = new ReservationDAL();
            string ds = reservationDal.GetUserReservationIdDAL(keyword);
            return ds;
        }

        public bool SetReservationBL(string reservationID, string rUsername, string rISBN)
        {
            ReservationDAL reservationDal = new ReservationDAL();
            bool isDone = reservationDal.setReservationDAL(reservationID, rUsername, rISBN);
            return isDone;
        }
    }
}
