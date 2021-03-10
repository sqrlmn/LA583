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
        int rowSelected;

        //VARIABLES USED TO STORE BOOK GRID VIEW CLICK ROW HEADER EVENT
        public static string BookISBN;
        public static string BookTitle;
        public static string BookSubject;
        public static string BookAuthor;
        public static int BookPage;
        public static double BookPrice;
        public static int BookCopy;
        public static double BookRating;

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
            AccountBL accountBl = new AccountBL();
            string firstName = accountBl.GetUserFirstNameBL(username);
            string lastName = accountBl.GetUserLastNameBL(username);
            bool type = accountBl.GetUserTypeBL(username);
            lblFullname.Text = firstName + " " + lastName;
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
            dgvSearch.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dgvSearch_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvSearch.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void lblEditAccount_Click(object sender, EventArgs e)
        {
            frmAccount fAccount = new frmAccount();
            fAccount.Show();
        }
    }
}
