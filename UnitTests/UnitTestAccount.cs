using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryAssistantDAL;
using LibraryAssistantBL;
using LibraryAssistant;

namespace UnitTests
{
    [TestClass]
    public class UnitTestAccount
    {
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
        public void Test()
        {
            //
        }
    }
}
