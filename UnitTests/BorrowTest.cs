using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryAssistantDAL;
using LibraryAssistantBL;
using LibraryAssistant;
using System;

namespace UnitTests
{
    [TestClass]
    public class BorrowTest
    {
        [TestMethod]
        public void TestGetMaxIDDAL()
        {
            BorrowsDAL borrowsDal = new BorrowsDAL();
            var result = borrowsDal.GetMaxIDDAL();
            Assert.IsNotNull(result);
        }


        [TestMethod]
        public void TestCreateBorrowByUsername()
        {
            BorrowsDAL borrowsDal = new BorrowsDAL();
            var ID = borrowsDal.GetMaxIDDAL();
            var username = "a";
            var ISBN = "6";
            var result = borrowsDal.CreateBorrowByUsername(ID, username, ISBN);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestChangeBorrowStatusByUsernameDAL()
        {
            BorrowsDAL borrowsDal = new BorrowsDAL();
            var username = "a";
            var result = borrowsDal.ChangeBorrowStatusByUsernameDAL(username);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestGetBookAvailableByISBNDAL()
        {
            BorrowsDAL borrowsDal = new BorrowsDAL();
            var ISBN = "6";
            var result = borrowsDal.GetBookAvailableByISBNDAL(ISBN);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestGetBorrowsISBNByUsernameDAL()
        {
            BorrowsDAL borrowsDal = new BorrowsDAL();
            var username = "a";
            var result = borrowsDal.GetBorrowsISBNByUsernameDAL(username);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestGetBorrowsDAL()
        {
            BorrowsDAL borrowsDal = new BorrowsDAL();
            var result = borrowsDal.GetBorrowsDAL();
            Assert.IsNotNull(result);
        }
    }
}
