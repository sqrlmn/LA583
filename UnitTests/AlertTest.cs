using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryAssistantDAL;
using LibraryAssistantBL;
using LibraryAssistant;
using System.Data;
using System.IO;

namespace UnitTests
{
    [TestClass]
    public class AlertTest
    {
        [TestMethod]
        public void TestgetUserBookReturnAlert()
        {
            AlertDAL alertdal = new AlertDAL();
            var validUsername = "a";
            var check = alertdal.GetAlertUserReturnDAL(validUsername);
            Assert.IsNotNull(check);
        }

        //[TestMethod]
        //public void TestGetBookAvailable()
        //{
        //    AlertDAL alertdal = new AlertDAL();
        //    var validUsername = "a";
        //    var check = alertdal.GetBookAvailableDAL(validUsername);
        //    Assert.IsFalse(check);
        //}

        [TestMethod]
        public void TestSetAlertReturn()
        {
            AlertDAL alertdal = new AlertDAL();
            Random random = new Random();
            DateTime today = DateTime.Today;
            var num = random.Next(1000);
            var validUsername = "a";
            var check = alertdal.SetAlertReturnDAL(validUsername, num, today);
            Assert.IsFalse(check);
        }

        //[TestMethod]
        //public void TestSetBookAlertAvailable()
        //{
        //    AlertDAL alertdal = new AlertDAL();
        //    Random random = new Random();
        //    DateTime today = DateTime.Today;
        //    var num = random.Next(1000);
        //    var validUsername = "a";
        //    var check = alertdal.SetAlertBookAvailableDAL(validUsername, 0, num, "A Daughter of the Snows");
        //    Assert.IsTrue(check);
        //}
    }
}
