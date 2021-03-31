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
    public class SearchTest
    {
        [TestMethod]
        public void TestValidKeyword()
        {
            BookDAL bookDal = new BookDAL();
            var validKeyword = "Show Boat";
            var books = bookDal.GetBooksDAL(validKeyword);
            bool result = false;

            for (int i = 0; i < books.Tables[0].Rows.Count; i++)
            {
                string checkTitle = books.Tables[0].Rows[0]["title"].ToString();
                string checkAuthor = books.Tables[0].Rows[0]["author"].ToString();
                string checkSubject = books.Tables[0].Rows[0]["subject"].ToString();

                if (checkTitle.Equals("Show Boat") || checkAuthor.Equals("Show Boat") || checkSubject.Equals("Show Boat"))
                {
                    result = true;
                }
                else
                {
                    result = false;
                    Assert.IsTrue(result);
                }
            }

            Assert.IsTrue(result);
        }
    }
}