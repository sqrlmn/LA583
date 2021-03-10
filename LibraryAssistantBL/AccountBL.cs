﻿using System;
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

        public string GetUserPhoneNameBL(string username)
        {
            AccountDAL accountDal = new AccountDAL();
            string phone = accountDal.GetUserPhoneDAL(username);
            return phone;
        }
    }
}
