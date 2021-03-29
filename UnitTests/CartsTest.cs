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
            var isbn = "4";
            var id = 4;
            var result = cartDal.CreateCartsbyUsername(username,isbn,id);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestRemoveCartbyUsername()
        {
            CartsDAL cartDal = new CartsDAL();
            var username = "dd";
            var result = cartDal.RemoveCartsbyUsername(username);
            Assert.IsTrue(result);
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
