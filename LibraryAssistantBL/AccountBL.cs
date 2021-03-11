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

        public string GetUserFirstNameBL(string username)
        {
            AccountDAL accountDal = new AccountDAL();
            string firstName = accountDal.GetUserFirstNameDAL(username);
            return firstName;
        }

        public string GetUserLastNameBL(string username)
        {
            AccountDAL accountDal = new AccountDAL();
            string lastName = accountDal.GetUserLastNameDAL(username);
            return lastName;
        }

        public bool GetUserTypeBL(string username)
        {
            AccountDAL accountDal = new AccountDAL();
            bool type = accountDal.GetUserTypeDAL(username);
            return type;
        }

        public string GetUserEmailBL(string username)
        {
            AccountDAL accountDal = new AccountDAL();
            string email = accountDal.GetUserEmailDAL(username);
            return email;
        }

        public string GetUserAddressBL(string username)
        {
            AccountDAL accountDal = new AccountDAL();
            string address = accountDal.GetUserAddressDAL(username);
            return address;
        }

        public string GetUserPhoneBL(string username)
        {
            AccountDAL accountDal = new AccountDAL();
            string phone = accountDal.GetUserPhoneDAL(username);
            return phone;
        }

        public bool UpdateUserNameBL(string username, string firstName, string lastName)
        {
            AccountDAL accountDal = new AccountDAL();
            bool result = accountDal.UpdateUserNameDAL(username, firstName, lastName);
            return result;
        }

        public bool UpdateUserPasswordBL(string username, string password)
        {
            AccountDAL accountDal = new AccountDAL();
            bool result = accountDal.UpdateUserPasswordDAL(username, password);
            return result;
        }

        public bool UpdateUserEmailBL(string username, string emailAddress)
        {
            AccountDAL accountDal = new AccountDAL();
            bool result = accountDal.UpdateUserEmailDAL(username, emailAddress);
            return result;
        }

        public bool UpdateUserAddressBL(string username, string address)
        {
            AccountDAL accountDal = new AccountDAL();
            bool result = accountDal.UpdateUserAddressDAL(username, address);
            return result;
        }

        public bool UpdateUserPhoneBL(string username, string phoneNumber)
        {
            AccountDAL accountDal = new AccountDAL();
            bool result = accountDal.UpdateUserPhoneDAL(username, phoneNumber);
            return result;
        }

        public bool CreateNewAccountBL(string username, string password, string type, string firstName, string lastName, string emailAddress, string address, string phoneNumber)
        {
            AccountDAL accountDal = new AccountDAL();
            bool result = accountDal.CreateNewAccountDAL(username, password, type, firstName, lastName, emailAddress, address, phoneNumber);
            return result;
        }

        public bool CheckUsernameBL(string username)
        {
            AccountDAL accountDal = new AccountDAL();
            bool result = accountDal.CheckUsernameDAL(username);
            return result;
        }
    }
}
