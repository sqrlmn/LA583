using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryAssistantDAL;

namespace LibraryAssistantBL
{
    public class CartsBL
    {
        public DataSet getCartsBL(string username)
        {
            CartsDAL cartsDAL = new CartsDAL();
            DataSet ds = cartsDAL.getCartsDAL(username);
            return ds;
        }
        public bool createCartsBL(string username, string ISBN)
        {
            CartsDAL cartsDAL = new CartsDAL();
            int maxid = cartsDAL.GetMaxIDDAL();
            bool create = cartsDAL.CreateCartsbyUsername(username, ISBN, maxid);
            return create;
        }
        public bool removeCartsbyISBN(string username, string ISBN)
        {
            CartsDAL cartsDAL = new CartsDAL();
            bool removed = cartsDAL.RemoveCartsbyISBN(username, ISBN);
            return removed;
        }
        public bool removeCartsbyusername(string username)
        {
            CartsDAL cartsDAL = new CartsDAL();
            bool removed = cartsDAL.RemoveCartsbyUsername(username);
            return removed;
        }
        public DataSet getCartsbyUsername(string username)
        {
            CartsDAL cartsDAL = new CartsDAL();
            DataSet ds = cartsDAL.getCartsinfobyusername(username);
            return ds;
        }
        public DataSet GetUsersBookCartsBL(string username)
        {
            CartsDAL cartsDal = new CartsDAL();
            DataSet ds = cartsDal.GetUsersBookCartsDAL(username);
            return ds;
        }
    }
}
