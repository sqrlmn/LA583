using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LibraryAssistant
{    
    public partial class Form1 : Form
    {
        //Connect to DB
        private MySqlConnection mConnection = new MySqlConnection("Server=libraryassistant.cwhg663yxudq.us-west-2.rds.amazonaws.com;Database=library;Uid=la583;Pwd=la583password;");
        //Send Query
        private MySqlCommand mCommand;
        //Read Data from DB
        private MySqlDataReader mDataReader;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //example code bring account information from DB 
            /*
            mCommand = new MySqlCommand();
            mCommand.Connection = mConnection;


            mCommand.CommandText = "SELECT * FROM accounts";
            mConnection.Open();
            mDataReader = mCommand.ExecuteReader();



            while (mDataReader.Read())

            {
                string accountId = mDataReader["accountId"].ToString();
                string accountPw = mDataReader["accountPw"].ToString();
                string type = mDataReader["type"].ToString();
                string aName = mDataReader["aName"].ToString();
                string email = mDataReader["email"].ToString();

                textBox1.AppendText("ID : " + accountId + "\n");
                textBox1.AppendText("PW : " + accountPw + "\n");
                textBox1.AppendText("Type : " + type + "\n");
                textBox1.AppendText("Name : " + aName + "\n");
                textBox1.AppendText("Email : " + email + "\n");

            }

            mConnection.Close();
            */
        }

        public void ConnectDB()
        {
            mConnection.Open();
        }

        public void DisConnectDB()
        {
            mConnection.Close();
        }

        public void Query()
        {
            mCommand = new MySqlCommand();
            mCommand.Connection = mConnection;
            mCommand.CommandText = "";
            //Login query: "SELECT * FROM accounts where accountId= ?, accountPw= ?";
            //Register query: "INSERT INTO accounts (accountId, accountPw, type, aName, email) VALUES (?,?,?,?,?)";
            //SearchBookByTitle query: "SELECT * FROM books where title= ?";
            //SearchBookByAuthor query: "SELECT * FROM books where author= ?";
            //SearchBookBySubject query: "SELECT * FROM books where subject= ?";
            //AddBook query: "INSERT INTO books (ISBN, title, pagecount, bookcondition, authorId, subject) VALUES (?,?,?,?,?,?)";
            //UpdateBook query: "UPDATE books SET title = ?, pagecount = ?, bookcondition = ?, authorId = ?, subject = ?;
            //RemoveBook query: "DELETE from books where ISBN = ?;
            mDataReader = mCommand.ExecuteReader();
        }
    }
}
