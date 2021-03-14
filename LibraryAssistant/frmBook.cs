using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryAssistantBL;

namespace LibraryAssistant
{
    public partial class frmBook : Form
    {
        public string Username;
        string quantity;
        string isbn;

        public frmBook(string isbn, string title, string author, string subject, string pages, string quantity, string rating)
        {
            InitializeComponent();
            lblBookISBN.Text = isbn;
            lblBookPages.Text = pages;
            lblBoothAuthor.Text = author;
            lblBookQuantity.Text = quantity;
            lblBookSubject.Text = subject;
            lblBookTitle.Text = title;
            lblBookRating.Text = rating;
            this.quantity = quantity;
            this.isbn = isbn;
            Refresh();
        }

        private void frmBook_Load(object sender, EventArgs e)
        {

        }

        private void btBookReserve_Click(object sender, EventArgs e)
        {
            int quan = Int32.Parse(quantity);
            if (quan != 0)
            {
                MessageBox.Show("Cannot reserve this book. Copies are available to rent.");
            }
            else
            {
                MessageBox.Show("Book Reserved!");
                ReservationBL reserveBL = new ReservationBL();
                reserveBL.SetReservationBL("1", Username, isbn);
                AlertBL alertBL = new AlertBL();
                alertBL.SetAlertBookAvailableBL(Username, 0, 1, DateTime.Now.ToString("M/d/yyyy"));
                
            }
        }

        private void addtoCart_Click(object sender, EventArgs e)
        {
            CartsBL carts = new CartsBL();
            bool truthstatement = carts.createCartsBL(Username, isbn);
            MessageBox.Show("Book added to cart!");
        }
    }
}
