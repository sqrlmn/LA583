using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using LibraryAssistantDAL;

namespace LibraryAssistantBL
{
    public class AccountBL
    {
        public bool NullCheckForUsernameAndPasswordInputBL(string username, string password)
        {
            if (username == "" || password == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool LoginBL(string username, string password)
        {
            if (NullCheckForUsernameAndPasswordInputBL(username, password))
            {
                AccountDAL accountDal = new AccountDAL();
                bool isDone = accountDal.LoginDAL(username, GenerateSHA512String(password));
                return isDone;
            }
            else
            {
                return false;
            }
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

        public bool NullCheckForUpdateUserNameBL(string username, string firstName, string lastName)
        {
            if (username == "" || firstName == "" || lastName == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool UpdateUserNameBL(string username, string firstName, string lastName)
        {
            if (NullCheckForUpdateUserNameBL(username, firstName, lastName))
            {
                AccountDAL accountDal = new AccountDAL();
                bool result = accountDal.UpdateUserNameDAL(username, firstName, lastName);
                return result;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateUserPasswordBL(string username, string password)
        {
            if (NullCheckForUsernameAndPasswordInputBL(username, password))
            {
                AccountDAL accountDal = new AccountDAL();
                bool result = accountDal.UpdateUserPasswordDAL(username, GenerateSHA512String(password));
                return result;
            }
            else
            {
                return false;
            }
        }

        public bool NullCheckForUpdateUserEmailInputBL(string username, string emailAddress)
        {
            if (username == "" || emailAddress == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool UpdateUserEmailBL(string username, string emailAddress)
        {
            if (NullCheckForUpdateUserEmailInputBL(username, emailAddress))
            {
                AccountDAL accountDal = new AccountDAL();
                bool result = accountDal.UpdateUserEmailDAL(username, emailAddress);
                return result;
            }
            else
            {
                return false;
            }
        }

        public bool NullCheckForUpdateUserAddressInputBL(string username, string address)
        {
            if (username == "" || address == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool UpdateUserAddressBL(string username, string address)
        {
            if (NullCheckForUpdateUserEmailInputBL(username, address))
            {
                AccountDAL accountDal = new AccountDAL();
                bool result = accountDal.UpdateUserAddressDAL(username, address);
                return result;
            }
            else
            {
                return false;
            }
        }

        public bool NullCheckForUpdateUserPhoneInputBL(string username, string phoneNumber)
        {
            if (username == "" || phoneNumber == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool UpdateUserPhoneBL(string username, string phoneNumber)
        {
            if (NullCheckForUpdateUserPhoneInputBL(username, phoneNumber))
            {
                AccountDAL accountDal = new AccountDAL();
                bool result = accountDal.UpdateUserPhoneDAL(username, phoneNumber);
                return result;
            }
            else
            {
                return false;
            }
        }

        public bool NullCheckForCreateNewAccountInputBL(string username, string password, string type, string firstName, string lastName, string emailAddress, string address, string phoneNumber)
        {
            if (username == "" || password == "" || type == "" || firstName == "" || lastName == "" || emailAddress == "" || address == "" || phoneNumber == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool CreateNewAccountBL(string username, string password, string type, string firstName, string lastName, string emailAddress, string address, string phoneNumber)
        {
            if (NullCheckForCreateNewAccountInputBL(username, password, type, firstName, lastName, emailAddress, address, phoneNumber))
            {
                AccountDAL accountDal = new AccountDAL();
                bool result = accountDal.CreateNewAccountDAL(username, GenerateSHA512String(password), type, firstName, lastName, emailAddress, address, phoneNumber);
                return result;
            }
            else
            {
                return false;
            }
        }

        public bool CheckUsernameBL(string username)
        {
            AccountDAL accountDal = new AccountDAL();
            bool result = accountDal.CheckUsernameDAL(username);
            return result;
        }

        public string GenerateSHA512String(string inputString)
        {
            SHA512 sha512 = SHA512Managed.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(inputString);
            byte[] hash = sha512.ComputeHash(bytes);
            return GetStringFromHash(hash);
        }

        private static string GetStringFromHash(byte[] hash)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                result.Append(hash[i].ToString("X2"));
            }
            return result.ToString();
        }
    }
}
