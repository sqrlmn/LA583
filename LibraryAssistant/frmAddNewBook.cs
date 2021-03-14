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
    public partial class frmAddNewBook : Form
    {
        public frmAddNewBook()
        {
            InitializeComponent();
        }

        public bool isAdd;
        public string ISBN;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BookBL bookBl = new BookBL();
            if (isAdd)
            {
                if (txtISBN.Text != "" && txtTitle.Text != "" && txtAuthors.Text != "" && txtSubject.Text != "" && txtPageCount.Text != "" && txtPrice.Text != "" && txtQuantity.Text != "")
                {
                    if (!bookBl.CheckISBNBL(txtISBN.Text))
                    {
                        if (bookBl.AddBookBL(txtISBN.Text, txtTitle.Text, txtAuthors.Text, Convert.ToInt32(txtQuantity.Text), Convert.ToDouble(txtPrice.Text), txtSubject.Text, Convert.ToInt32(txtPageCount.Text)))
                        {
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("There is an error...", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Book is already existed.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Enter the fields properly...", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (txtISBN.Text != "" && txtTitle.Text != "" && txtAuthors.Text != "" && txtSubject.Text != "" && txtPageCount.Text != "" && txtPrice.Text != "" && txtQuantity.Text != "" && txtAvailable.Text != "")
                {
                    if (txtISBN.Text == ISBN)
                    {
                        if (Convert.ToInt32(txtQuantity.Text) >= Convert.ToInt32(txtAvailable.Text))
                        {
                            if (bookBl.EditBookBL(txtISBN.Text, txtTitle.Text, txtAuthors.Text, Convert.ToInt32(txtQuantity.Text), Convert.ToDouble(txtPrice.Text), txtSubject.Text, Convert.ToInt32(txtPageCount.Text), Convert.ToInt32(txtAvailable.Text), ISBN))
                            {
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("There is an error...", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Available cannot be larger than quantity...", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        if (!bookBl.CheckISBNBL(txtISBN.Text))
                        {
                            if (Convert.ToInt32(txtQuantity.Text) >= Convert.ToInt32(txtAvailable.Text))
                            {
                                if (bookBl.EditBookBL(txtISBN.Text, txtTitle.Text, txtAuthors.Text, Convert.ToInt32(txtQuantity.Text), Convert.ToDouble(txtPrice.Text), txtSubject.Text, Convert.ToInt32(txtPageCount.Text), Convert.ToInt32(txtAvailable.Text), ISBN))
                                {
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("There is an error...", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Available cannot be larger than quantity...", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("ISBN is already existed.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Enter the fields properly...", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmAddNewBook_Load(object sender, EventArgs e)
        {
            if (isAdd)
            {
                lblAvailable.Hide();
                txtAvailable.Hide();
            }
            else
            {
                lblAddNewBook.Text = "Edit book";
                btnAdd.Text = "Save";
            }
        }
    }
}
