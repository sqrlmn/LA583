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
    public partial class frmBookReturn : Form
    {
        public frmBookReturn()
        {
            InitializeComponent();
        }
        string username;
        string isbn;

        private void frmBookReturn_Load(object sender, EventArgs e)
        {

        }

        private void txtbUsername_TextChanged(object sender, EventArgs e)
        {
             this.username = txtbUsername.Text;
        }

        private void txtbISBN_TextChanged(object sender, EventArgs e)
        {
             this.isbn = txtbISBN.Text;
        }

        private void btnConfirmReturn_Click(object sender, EventArgs e)
        {
            BookBL bookBL = new BookBL();
            if (bookBL.ReturnBookBL(username, isbn) == true)
            {
                MessageBox.Show("Book return successful!");
            }
            else
            {
                MessageBox.Show("Book return not successful!");
            }
        }
    }
}
