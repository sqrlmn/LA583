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
        public bool type;

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
            type = accountBl.GetUserTypeBL(username);
            lblFullname.Text = firstName + " " + lastName;
            AlertBL alertBL = new AlertBL();

            if (type)
            {
                lblAccountType.Text = "Librarian";
                lblBookReturn.Show();
                lblViewCart.Hide();
                lblCheckout.Text = "Issue";
            }
            else
            {
                lblAccountType.Text = "User";
                lblBookReturn.Hide();
                if (alertBL.GetAlertUserBL(username))
                {
                    MessageBox.Show("You have an book due today!");
                }
                btnAdd.Hide();
                btnEdit.Hide();
                btnRemove.Hide();
            }
        }

        private void dgvSearch_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvSearch.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            rowIndex = e.RowIndex;
            try
            {
                rISBN = dgvSearch.Rows[rowIndex].Cells[0].Value.ToString();
                rBookTitle = dgvSearch.Rows[rowIndex].Cells[1].Value.ToString();
            }
            catch { };
        }

        private void dgvSearch_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvSearch.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
            fBook.userType = type;
            fBook.ShowDialog();
        }

        private void lblEditAccount_Click(object sender, EventArgs e)
        {
            frmAccount fAccount = new frmAccount();
            fAccount.username = username;
            fAccount.ShowDialog();
        }

        private void lblViewCart_Click(object sender, EventArgs e)
        {
            frmCarts frcarts = new frmCarts(username,BookISBN);
            frcarts.ShowDialog();
        }

        private void lblReturnBook_Click(object sender, EventArgs e)
        {

        }

        private void lblBookReturn_Click(object sender, EventArgs e)
        {
            frmBookReturn bookReturn = new frmBookReturn();
            bookReturn.Show();
        }

        private void checkout_Click(object sender, EventArgs e)
        {
            if (type)
            {
                frmIssue fIssue = new frmIssue();
                fIssue.ShowDialog();
            }
            else
            {
                CartsBL carts = new CartsBL();
                BorrowsBL borrowsBl = new BorrowsBL();
                for (int i = 0; i < carts.GetUsersBookCartsBL(username).Tables[0].Rows.Count; i++)
                {
                    borrowsBl.CreateBorrowsBL(username, carts.GetUsersBookCartsBL(username).Tables[0].Rows[i][0].ToString());
                }
                if (carts.removeCartsbyusername(username))
                {
                    MessageBox.Show("You are already checkout...", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("There is an error...", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                AlertBL newReturnAlert = new AlertBL();
                DateTime today = DateTime.Today;
                DateTime expiryDate = today.AddDays(15);
                Random rnd_id = new Random();
                int alert_id = rnd_id.Next(1, 1000);
                newReturnAlert.SetAlertReturnBL(username, alert_id, expiryDate);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddNewBook fAddNewBook = new frmAddNewBook();
            fAddNewBook.isAdd = true;
            fAddNewBook.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (rISBN != null)
            {
                frmAddNewBook fAddNewBook = new frmAddNewBook();
                fAddNewBook.Text = "Edit Book";
                fAddNewBook.ISBN = rISBN;
                fAddNewBook.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please click on a book to edit it.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public string rISBN = null;
        public string rBookTitle = null;
        public int rowIndex;
        private void btnRemove_Click(object sender, EventArgs e)
        {
            BookBL bookBl = new BookBL();
            try
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to remove "+ rBookTitle +"?", "Remove a book", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    dgvSearch.Rows.RemoveAt(rowIndex);
                    bookBl.RemoveBookBL(rISBN);
                }
                else if (dialogResult == DialogResult.No)
                {
                    // do nothing
                }
            }
            catch
            {
                MessageBox.Show("Please click on a book to remove it.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
