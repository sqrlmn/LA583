﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LibraryAssistantDAL;
using LibraryAssistantBL;
using LibraryAssistant;

namespace UnitTests
{
    [TestClass]
    public class BookTest
    {
        [TestMethod]
        public void TestReturnBook()
        {

        }
        [TestMethod]
        public void TestAddBook()
        {
            //string ISBN, string title, string author, int quantity, double price, string subject, int pageCount
            BookDAL testbook = new BookDAL();
            var isbn = "99";
            var title = "alphabet soup";
            var author = "Marie Holly";
            var quantity = 2;
            var price = 1.00;
            var subject = "education";
            var pagecount = 200;
            var result = testbook.AddBookDAL(isbn, title,author, quantity, price, subject, pagecount);
            Assert.IsTrue(result);
            var remove = testbook.RemoveBookByISBNDAL(isbn);
        }
        [TestMethod]
        public void TestRemoveBook()
        {
            BookDAL testbook = new BookDAL();
            //keep this just in case to test the remove book if the test case used for addbook was deleted
            var isbn = "99";
            var title = "alphabet soup";
            var author = "Marie Holly";
            var quantity = 2;
            var price = 1.00;
            var subject = "education";
            var pagecount = 200;
            var createbook = testbook.AddBookDAL(isbn, title, author, quantity, price, subject, pagecount);
            var result = testbook.RemoveBookByISBNDAL("99");
            Assert.IsTrue(result);
        }
        


        [TestMethod]
        public void TestEditBookbyISBN()
        {
            BookDAL testbook = new BookDAL();
            //keep this just in case to test the remove book if the test case used for addbook was deleted
            var isbn = "99";
            var title = "alphabet soup";
            var author = "Marie Holly";
            var quantity = 2;
            var price = 1.00;
            var subject = "education";
            var pagecount = 200;
            //var currentISBN=testbook.CheckISBNDAL(isbn)
            var createbook = testbook.AddBookDAL(isbn, title, author, quantity, price, subject, pagecount);
            var result = testbook.EditBookDAL(isbn, title, author, quantity, price, subject, pagecount,1,"100");
            Assert.IsFalse(result);
            testbook.RemoveBookByISBNDAL(isbn);
        }
        [TestMethod]
        public void TestGetReviewcount()
        {
            BookDAL testbook = new BookDAL();
            var isbn = "1";
            var result = testbook.GetReviewCountDAL(isbn);
            Assert.AreEqual(4,result);
        }
        [TestMethod]
        public void TestGetStarReview()
        {
            BookDAL testbook = new BookDAL();
            var isbn = "1";
            var result = testbook.GetstarCountDAL(isbn);
            Assert.AreEqual(19, result);
        }


    }
}
