using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryAssistantDAL;
using LibraryAssistantBL;
using LibraryAssistant;
using System.Security.Cryptography;
using System.Text;

namespace UnitTests
{
    [TestClass]
    public class UnitTestAccount
    {
        const string isNull = "";
        [TestMethod]
        public void TestValidUsernameAndPasswordWithoutEncryption()
        {
            AccountDAL accountDal = new AccountDAL();
            var validUsername = "a";
            var validPassword = "a";
            var result = accountDal.LoginDAL(validUsername, validPassword);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestValidUsernameAndPasswordWithEncryption()
        {
            AccountDAL accountDal = new AccountDAL();
            AccountBL accountBl = new AccountBL();
            var validUsername = "a";
            var validPassword = accountBl.GenerateSHA512String("a");
            var result = accountDal.LoginDAL(validUsername, validPassword);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestInvalidUsernameAndPasswordWithoutEncryption()
        {
            AccountDAL accountDal = new AccountDAL();
            var validUsername = "invalid";
            var validPassword = "invalid";
            var result = accountDal.LoginDAL(validUsername, validPassword);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestInvalidUsernameAndPasswordWithEncryption()
        {
            AccountDAL accountDal = new AccountDAL();
            AccountBL accountBl = new AccountBL();
            var validUsername = "invalid";
            var validPassword = accountBl.GenerateSHA512String("invalid");
            var result = accountDal.LoginDAL(validUsername, validPassword);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestLoginUsernameIsNull()
        {
            AccountBL accountBl = new AccountBL();
            var result = accountBl.NullCheckForUsernameAndPasswordInputBL(isNull, "a");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestLoginPasswordIsNull()
        {
            AccountBL accountBl = new AccountBL();
            var result = accountBl.NullCheckForUsernameAndPasswordInputBL("a", isNull);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestLoginIsNotNull()
        {
            AccountBL accountBl = new AccountBL();
            var result = accountBl.NullCheckForUsernameAndPasswordInputBL("a", "a");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestUpdateUserNameUsernameIsNull()
        {
            AccountBL accountBl = new AccountBL();
            var result = accountBl.NullCheckForUpdateUserNameBL(isNull, "Nghia", "Luong");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestUpdateUserNameFirstNameIsNull()
        {
            AccountBL accountBl = new AccountBL();
            var result = accountBl.NullCheckForUpdateUserNameBL("a", isNull, "Luong");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestUpdateUserNameLastNameIsNull()
        {
            AccountBL accountBl = new AccountBL();
            var result = accountBl.NullCheckForUpdateUserNameBL("a", "Nghia", isNull);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestUpdateUserNameIsNotNull()
        {
            AccountBL accountBl = new AccountBL();
            var result = accountBl.NullCheckForUpdateUserNameBL("a", "Nghia", "Luong");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestUpdateEmailUsernameIsNull()
        {
            AccountBL accountBl = new AccountBL();
            var result = accountBl.NullCheckForUpdateUserEmailInputBL(isNull, "nghia.luong@wsu.edu");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestUpdateEmailEmailAddressIsNull()
        {
            AccountBL accountBl = new AccountBL();
            var result = accountBl.NullCheckForUpdateUserEmailInputBL("a", isNull);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestUpdateEmailIsNotNull()
        {
            AccountBL accountBl = new AccountBL();
            var result = accountBl.NullCheckForUsernameAndPasswordInputBL("a", "nghia.luong@wsu.edu");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestUpdateAddressUsernameIsNull()
        {
            AccountBL accountBl = new AccountBL();
            var result = accountBl.NullCheckForUpdateUserAddressInputBL(isNull, "12110 SE 70th St, Newcastle, WA 98056");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestUpdateAddressEmailAddressIsNull()
        {
            AccountBL accountBl = new AccountBL();
            var result = accountBl.NullCheckForUpdateUserAddressInputBL("a", isNull);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestUpdateAddressIsNotNull()
        {
            AccountBL accountBl = new AccountBL();
            var result = accountBl.NullCheckForUpdateUserAddressInputBL("a", "12110 SE 70th St, Newcastle, WA 98056");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestUpdatePhoneUsernameIsNull()
        {
            AccountBL accountBl = new AccountBL();
            var result = accountBl.NullCheckForUpdateUserPhoneInputBL(isNull, "(425) 327-5432");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestUpdatePhoneEmailAddressIsNull()
        {
            AccountBL accountBl = new AccountBL();
            var result = accountBl.NullCheckForUpdateUserPhoneInputBL("a", isNull);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestUpdatePhoneIsNotNull()
        {
            AccountBL accountBl = new AccountBL();
            var result = accountBl.NullCheckForUpdateUserPhoneInputBL("a", "(425) 327-5432");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestCreateNewAccountUsernameIsNull()
        {
            AccountBL accountBl = new AccountBL();
            var result = accountBl.NullCheckForCreateNewAccountInputBL(isNull, "a", "0", "Mingyi", "Liang", "mingyi.liang@wsu.edu", "12110 SE 70th St, Newcastle, WA 98056", "(425) 327-5432");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestCreateNewAccountPasswordIsNull()
        {
            AccountBL accountBl = new AccountBL();
            var result = accountBl.NullCheckForCreateNewAccountInputBL("a", isNull, "0", "Mingyi", "Liang", "mingyi.liang@wsu.edu", "12110 SE 70th St, Newcastle, WA 98056", "(425) 327-5432");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestCreateNewAccountTypeIsNull()
        {
            AccountBL accountBl = new AccountBL();
            var result = accountBl.NullCheckForCreateNewAccountInputBL("a", "a", isNull, "Mingyi", "Liang", "mingyi.liang@wsu.edu", "12110 SE 70th St, Newcastle, WA 98056", "(425) 327-5432");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestCreateNewAccountFirstNameIsNull()
        {
            AccountBL accountBl = new AccountBL();
            var result = accountBl.NullCheckForCreateNewAccountInputBL("a", "a", "0", isNull, "Liang", "mingyi.liang@wsu.edu", "12110 SE 70th St, Newcastle, WA 98056", "(425) 327-5432");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestCreateNewAccountLastNameIsNull()
        {
            AccountBL accountBl = new AccountBL();
            var result = accountBl.NullCheckForCreateNewAccountInputBL("a", "a", "0", "Mingyi", isNull, "mingyi.liang@wsu.edu", "12110 SE 70th St, Newcastle, WA 98056", "(425) 327-5432");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestCreateNewAccountEmailAddressIsNull()
        {
            AccountBL accountBl = new AccountBL();
            var result = accountBl.NullCheckForCreateNewAccountInputBL("a", "a", "0", "Mingyi", "Liang", isNull, "12110 SE 70th St, Newcastle, WA 98056", "(425) 327-5432");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestCreateNewAccountAddressIsNull()
        {
            AccountBL accountBl = new AccountBL();
            var result = accountBl.NullCheckForCreateNewAccountInputBL("a", "a", "0", "Mingyi", "Liang", "mingyi.liang@wsu.edu", isNull, "(425) 327-5432");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestCreateNewAccountPhoneIsNull()
        {
            AccountBL accountBl = new AccountBL();
            var result = accountBl.NullCheckForCreateNewAccountInputBL("a", "a", "0", "Mingyi", "Liang", "mingyi.liang@wsu.edu", "12110 SE 70th St, Newcastle, WA 98056", isNull);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestCreateNewAccountIsNotNull()
        {
            // This test is used to check valid input when creating new account
            AccountBL accountBl = new AccountBL();
            var result = accountBl.NullCheckForCreateNewAccountInputBL("a", "a", "0", "Mingyi", "Liang", "mingyi.liang@wsu.edu", "12110 SE 70th St, Newcastle, WA 98056", "(425) 327-5432");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestPasswordIsEncrypted()
        {
            // This test is used to check whether password is encrypted
            SHA512 sha512 = SHA512Managed.Create();
            byte[] bytes = Encoding.UTF8.GetBytes("testing");
            byte[] hash = sha512.ComputeHash(bytes);
            AccountBL accountBl = new AccountBL();
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                result.Append(hash[i].ToString("X2"));
            }
            var expected = result.ToString();
            var actual = accountBl.GenerateSHA512String("testing");
            Assert.AreEqual(expected, actual);
        }
    }
}
