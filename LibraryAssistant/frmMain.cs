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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public string username;

        //VARIABLES USED TO STORE BOOK GRID VIEW CLICK ROW HEADER EVENT
        public static string BookISBN;
        public static string BookTitle;
        public static string BookSubject;
        public static string BookAuthor;
        public static int BookPage;
        public static double BookPrice;
        public static int BookCopy;
        public static double BookRating;
        public static double BookAvailability;

        private void lblLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BookBL bookBl = new BookBL();
            DataSet ds = bookBl.GetBooksBL(txtSearch.Text);
            dgvSearch.DataSource = ds.Tables[0];
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the key is the enter key
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                btnSearch.PerformClick();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            dgvSearch.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AccountBL accountBl = new AccountBL();
            string firstName = accountBl.GetUserFirstNameBL(username);
            string lastName = accountBl.GetUserLastNameBL(username);
            bool type = accountBl.GetUserTypeBL(username);
            lblFullname.Text = firstName + " " + lastName;
            AlertBL alertBL = new AlertBL();
            alertBL.GetAlertUserBL(username);

            if (type)
            {
                lblAccountType.Text = "Librarian";
            }
            else
            {
                lblAccountType.Text = "User";
            }
        }

        private void dgvSearch_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void dgvSearch_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvSearch.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            int column = e.ColumnIndex;
            int row = e.RowIndex;
            string isbn = dgvSearch.Rows[row].Cells[0].Value.ToString();
            string title = dgvSearch.Rows[row].Cells[1].Value.ToString();
            string author = dgvSearch.Rows[row].Cells[2].Value.ToString();
            string subject = dgvSearch.Rows[row].Cells[3].Value.ToString();
            string pages = dgvSearch.Rows[row].Cells[4].Value.ToString();
            string quantity = dgvSearch.Rows[row].Cells[5].Value.ToString();
            string rating = dgvSearch.Rows[row].Cells[6].Value.ToString();
            frmBook fBook = new frmBook(isbn, title, author, subject, pages, quantity, rating);
            fBook.Username = username;
            fBook.Show();
        }

        private void lblEditAccount_Click(object sender, EventArgs e)
        {
            frmAccount fAccount = new frmAccount();
            fAccount.username = username;
            fAccount.ShowDialog();
        }

        private void lblViewCart_Click(object sender, EventArgs e)
        {
            frmCarts frcarts = new frmCarts(username);
            frcarts.ShowDialog();
        }

        private void lblReturnBook_Click(object sender, EventArgs e)
        {

        }

        private void lblBookReturn_Click(object sender, EventArgs e)
        {
            AccountBL lbAccount = new AccountBL();
            bool Actype = lbAccount.GetUserTypeBL(username);
            if (Actype == true)
            {
                lblBookReturn.Show();
            }
            else
            {
                lblBookReturn.Hide();
            }
        }

        private void checkout_Click(object sender, EventArgs e)
        {
            CartsBL carts = new CartsBL();
            bool truthstatement = carts.removeCartsbyusername(username);
        }
    }
}
