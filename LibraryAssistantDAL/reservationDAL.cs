using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LibraryAssistantDAL
{
    public class ReservationDAL
    {
        public bool setReservationDAL(string reservationID, string rUsername, string rISBN)
        {
            MySqlConnection conn = new MySqlConnection("Server=libraryassistant.cwhg663yxudq.us-west-2.rds.amazonaws.com;Database=library;Uid=la583;Pwd=la583password;");
            string query = "INSERT INTO reservations (reservationID, rUsername, rISBN)"; // setting database variables for book reservation
            query += " VALUES (@reservationID, @rUsername, @rISBN)"; // setting arguments to database names
            MySqlCommand cmd = new MySqlCommand(query, conn); // processing command
            cmd.Parameters.Add(new MySqlParameter("@reservationID", reservationID));
            cmd.Parameters.Add(new MySqlParameter("@rUsername", rUsername));
            cmd.Parameters.Add(new MySqlParameter("@rISBN", rISBN));
            conn.Open();
            int rowAffected = cmd.ExecuteNonQuery(); // checking if the database set was successful
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

        public string GetUserReservationIdDAL(string keyword)
        {
            MySqlConnection conn = new MySqlConnection("Server=libraryassistant.cwhg663yxudq.us-west-2.rds.amazonaws.com;Database=library;Uid=la583;Pwd=la583password;");
            MySqlCommand cmd = new MySqlCommand("SELECT reservationId FROM reservations WHERE username=@rusername", conn); // grabbing reservationId
            cmd.Parameters.Add(new MySqlParameter("@username", keyword));
            conn.Open();
            string reservationID = (string)cmd.ExecuteScalar();
            conn.Close();
            return reservationID;
        }
    }
}
