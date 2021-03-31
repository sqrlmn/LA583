using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LibraryAssistantDAL;
using LibraryAssistantBL;
using LibraryAssistant;

namespace UnitTests
{
    [TestClass]
    public class CartsTest
    {
        [TestMethod]
        public void TestcreateCarts()
        {
            CartsDAL cartDal = new CartsDAL();
            var username = "a";
            //var isbn = "4";
            //var id = 4;
            var isbn = cartDal.GetMaxIDDAL().ToString();
            var id = cartDal.GetMaxIDDAL();
            var result = cartDal.CreateCartsbyUsername(username,isbn,id);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestRemoveCartbyUsername()
        {
            CartsDAL cartDal = new CartsDAL();
            var username = "b";
            var isbn=cartDal.GetMaxIDDAL().ToString();
            var id = cartDal.GetMaxIDDAL();
            var testcart = cartDal.CreateCartsbyUsername(username,isbn,id);
            var result = cartDal.RemoveCartsbyUsername(username);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestfailedRemovecartbyUserName()
        {
            CartsDAL cartDal = new CartsDAL();
            var username = "g";
            var result = cartDal.RemoveCartsbyUsername(username);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void TestRemoveCartByISBN()
        {
            CartsDAL cartDal = new CartsDAL();
            var username = "b";
            var isbn = cartDal.GetMaxIDDAL().ToString();
            var id = cartDal.GetMaxIDDAL();
            var testcart = cartDal.CreateCartsbyUsername(username, isbn, id);
            var result=cartDal.RemoveCartsbyISBN(username,isbn);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestFailedRemoveCartbyIsbn()
        {
            CartsDAL cartDal = new CartsDAL();
            var username = "b";
            var isbn = "3";
            var result = cartDal.RemoveCartsbyISBN(username, isbn);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void TestCartisempty()
        {
            CartsDAL cartDal = new CartsDAL();
            var result = cartDal.cartisEmpty();
            Assert.IsFalse(result);

        }

    }
}
