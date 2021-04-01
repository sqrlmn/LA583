using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LibraryAssistantDAL;
using LibraryAssistantBL;
using LibraryAssistant;
using System.Data;
using MySql.Data.MySqlClient;

namespace UnitTests
{
    [TestClass]
    public class IntegrationTest
    {
         
        [TestMethod]
        public void TestSuccesfulCaseLoginToCheckoutForUser()
        {
            // Test Scenario
            // User('a') login to library assistant app and search book 'Show Boat'. 
            // And add book which on the first line to cart.
            // User realize his/her address information is wrong, so try to change it.
            // Also, user decide to rate the star on 'Three Soldiers' because he/she liked the book he borrowed last time. 
            // And then he/she check out the cart.

            //Login
            string username = ValidLogin("a", "a");

            //Search
            string bookISBN = ValidSearch("Show Boat");

            //Add to Cart
            bool resultCreate = CreateCart(username, bookISBN);

            //Update addresss
            bool checkAddress = EditAddress(username, "12112 SE 70th, Newcastle, WA 98056");

            //Search
            bookISBN = ValidSearch("Three Soldiers");

            //Rating
            RateStarOnBook(bookISBN, 4);

            ResetReviewStarCount(bookISBN);

            bool checkReview = TestGetReviewCount(bookISBN);
            bool checkStar = TestGetStarCount(bookISBN);

            //Checkout
            bool resultRemove = RemoveCart(username);
            //Console.WriteLine(resultRemove);

            Assert.IsTrue(resultCreate && resultRemove && checkAddress && checkReview && checkStar);
        }                

        [TestMethod]
        public void TestForRegisterNewUser()
        {
            //Test Scenario
            // Guest try to register account for using library assistant app as "test", "t", "0", "test", "user", "test@wsu.edu", "pullman", "(509) 555-3333"
            // And login by this account

            //confrim register
            bool checkRegister = ConfirmAccountCreation("test", "t", "0", "test", "user", "test@wsu.edu", "pullman", "(509) 555-3333");

            // ****login problem because of Encryption****
            // test again later

            bool checkDelete = DeleteTestAccount();

            Assert.IsTrue(checkRegister && checkDelete);
        }

        [TestMethod]
        public void TestSuccessfulCaseForLibrarian()
        {
            // Test Scenario
            // Librarian('a') login to library assistant app. 
            // And add the book as "33", "test book", "Fake Writer", 1, 12.5, "test", 99
            // He/She realizes that he wrote the wrong pagecount and updates it.("100")
            // but his/hers colleague to delete the book because it hasn't come yet, so he/she deletes it. 


            //Login
            string username = ValidLogin("b", "b");

            //Add book
            string addedBookISBN = AddBook("33", "test book", "Fake Writer", 1, 12.5, "test", 99);

            //Update book
            UpdateBook(addedBookISBN, 100);

            //Delete book
            bool checkDeleteBook = DeleteBook(addedBookISBN);

            Assert.IsTrue(checkDeleteBook);
        }


        public string ValidLogin(string typedUsername, string typedPassword)
        {
            AccountDAL accountDal = new AccountDAL();
            AccountBL accountBl = new AccountBL();
            var validUsername = typedUsername;
            var validPassword = accountBl.GenerateSHA512String(typedPassword);
            var result = accountDal.LoginDAL(validUsername, validPassword);

            if(result == true)
            {
                return validUsername;
            }
            else
            {
                return null;
            }
        }


        public string ValidSearch(string typedBookname)
        {
            BookDAL bookDal = new BookDAL();
            var validKeyword = typedBookname;
            var books = bookDal.GetBooksDAL(validKeyword);
            string result = null;
            
            string checkTitle = books.Tables[0].Rows[0]["title"].ToString();
            string checkAuthor = books.Tables[0].Rows[0]["author"].ToString();
            string checkSubject = books.Tables[0].Rows[0]["subject"].ToString();

            if (checkTitle.Equals(typedBookname) || checkAuthor.Equals(typedBookname) || checkSubject.Equals(typedBookname))
            {
                result = books.Tables[0].Rows[0]["ISBN"].ToString();
            }  

            return result;
        }


        public string InvalidSearch(string typedBookname)
        {
            BookDAL bookDal = new BookDAL();
            var validKeyword = typedBookname;
            var books = bookDal.GetBooksDAL(validKeyword);
            string result = null;

            string checkTitle = books.Tables[0].Rows[0]["title"].ToString();
            string checkAuthor = books.Tables[0].Rows[0]["author"].ToString();
            string checkSubject = books.Tables[0].Rows[0]["subject"].ToString();

            if (checkTitle.Equals(typedBookname) || checkAuthor.Equals(typedBookname) || checkSubject.Equals(typedBookname))
            {
                result = books.Tables[0].Rows[0]["ISBN"].ToString();
            }

            return result;
        }


        public bool CreateCart(string username, string ISBN)
        {
            CartsDAL cartDal = new CartsDAL();
            var id = cartDal.GetMaxIDDAL();
            var result = cartDal.CreateCartsbyUsername(username, ISBN, id);
            return result;
        }


        public bool RemoveCart(string username)
        {
            CartsDAL cartDal = new CartsDAL();
            var result = cartDal.RemoveCartsbyUsername(username);
            return result;
        }

        
        public bool ConfirmAccountCreation(string username, string password, string type, string firstName, string lastName, string emailAddress, string address, string phoneNumber)
        {
            AccountDAL accountDal = new AccountDAL();
            accountDal.CreateNewAccountDAL(username, password, type, firstName, lastName, emailAddress, address, phoneNumber);
            //string confirmedUsername = null;
            bool result = false;
            
            string checkFirstName = accountDal.GetUserFirstNameDAL(username);
            string checkLastName = accountDal.GetUserLastNameDAL(username);
            string checkEmailAddress = accountDal.GetUserEmailDAL(username);
            string checkAddress = accountDal.GetUserAddressDAL(username);
            string checkPhoneNumber = accountDal.GetUserPhoneDAL(username);

            if (checkFirstName.Equals(firstName) && checkLastName.Equals(lastName) && checkEmailAddress.Equals(emailAddress) && 
                checkAddress.Equals(address) && checkPhoneNumber.Equals(phoneNumber))
            {
                //confirmedUsername = username;
                result = true;
            }

            return result;
        }

        
        public bool EditAddress(string username, string address)
        {
            AccountDAL accountDal = new AccountDAL();
            accountDal.UpdateUserAddressDAL(username, address);
            bool result = false;

            string checkAddress = accountDal.GetUserAddressDAL(username);

            if (checkAddress.Equals(address))
            {
                result = true;
            }

            return result;
        }


        public bool DeleteTestAccount()
        {
            MySqlConnection conn = new MySqlConnection("Server=libraryassistant.cwhg663yxudq.us-west-2.rds.amazonaws.com;Database=library;Uid=la583;Pwd=la583password;");
            MySqlCommand cmd = new MySqlCommand("DELETE FROM accounts WHERE username = @username", conn);
            cmd.Parameters.Add(new MySqlParameter("@username", "test"));
            conn.Open(); 
            int rowAffected = cmd.ExecuteNonQuery();
            conn.Close();
            if (rowAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public void RateStarOnBook(string ISBN, int star)
        {
            BookDAL bookDal = new BookDAL();
            bookDal.updateBookreviewDAL(ISBN, star);

        } 

        public void ResetReviewStarCount(string ISBN)
        {
            BookDAL bookDal = new BookDAL();
            int rc = bookDal.GetReviewCountDAL(ISBN);
            int sc = bookDal.GetstarCountDAL(ISBN);
            MySqlConnection conn = new MySqlConnection("Server=libraryassistant.cwhg663yxudq.us-west-2.rds.amazonaws.com;Database=library;Uid=la583;Pwd=la583password;");

            MySqlCommand cmd3 = new MySqlCommand("UPDATE books SET reviewCount = @rc, starCount = @sc WHERE ISBN = @ISBN", conn);
            cmd3.Parameters.Add(new MySqlParameter("@rc", rc - 1));
            cmd3.Parameters.Add(new MySqlParameter("@sc", sc - 4));
            cmd3.Parameters.Add(new MySqlParameter("@ISBN", ISBN));

            conn.Open();
            cmd3.ExecuteNonQuery();
            conn.Close();
        }

        public bool TestGetReviewCount(string ISBN)
        {
            BookDAL testbook = new BookDAL();
            var result = testbook.GetReviewCountDAL(ISBN);
            bool checkResult = false;

            if(result == 0)
            {
                checkResult = true;
            }

            return checkResult;
        }

        public bool TestGetStarCount(string ISBN)
        {
            BookDAL testbook = new BookDAL();
            var result = testbook.GetstarCountDAL(ISBN);
            bool checkResult = false;

            if (result == 0)
            {
                checkResult = true;
            }

            return checkResult;
        }

        public string AddBook(string ISBN, string title, string author, int quantity, double price, string subject, int pageCount)
        {
            BookDAL testbook = new BookDAL();
            testbook.AddBookDAL(ISBN, title, author, quantity, price, subject, pageCount);

            var book = testbook.GetBooksDAL(title);

            string checkAddBook = book.Tables[0].Rows[0]["ISBN"].ToString();

            return checkAddBook;
        }

        public void UpdateBook(string ISBN, int pagecount)
        {
            BookDAL testbook = new BookDAL();
            // ****Need to add function to update individual data****
            testbook.EditBookDAL(ISBN, "test book", "Fake Writer", 1, 12.5, "test", 199, 1, ISBN);
        }

        public bool DeleteBook(string ISBN)
        {
            BookDAL testbook = new BookDAL();
            bool result =testbook.RemoveBookByISBNDAL(ISBN);
            return result;
        }

    }
}
