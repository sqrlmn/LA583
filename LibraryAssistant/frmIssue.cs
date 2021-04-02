using LibraryAssistantBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryAssistant
{
    public partial class frmIssue : Form
    {
        public frmIssue()
        {
            InitializeComponent();
        }

        public int rowIndex;
        public string username;

        private void dgvIssue_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvIssue.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            rowIndex = e.RowIndex;
            try
            {
                username = dgvIssue.Rows[rowIndex].Cells[0].Value.ToString();
            }
            catch { };
        }

        private void frmIssue_Load(object sender, EventArgs e)
        {
            BorrowsBL borrowsBl = new BorrowsBL();
            DataSet ds = borrowsBl.GetBorrowsBL();
            dgvIssue.DataSource = ds.Tables[0];
        }

        bool isNotAvailable;
        private void btnIssue_Click(object sender, EventArgs e)
        {
            BorrowsBL borrowsBl = new BorrowsBL();
            BookBL bookBl = new BookBL();
            
            for (int i = 0; i < borrowsBl.GetBorrowsISBNByUsernameBL(username).Tables[0].Rows.Count; i++)
            {
                if (Convert.ToInt32(borrowsBl.GetBookAvailableByISBNBL(borrowsBl.GetBorrowsISBNByUsernameBL(username).Tables[0].Rows[i][0].ToString())) <= 0)
                {
                    isNotAvailable = true;
                }
            }
            if (!isNotAvailable)
            {
                try
                {
                    DialogResult dialogResult = MessageBox.Show("Do you want to issue book(s) for " + username + "?", "Issue book(s)", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        for (int j = 0; j < borrowsBl.GetBorrowsISBNByUsernameBL(username).Tables[0].Rows.Count; j++)
                        {
                            bookBl.DecreaseAvailableBL(borrowsBl.GetBorrowsISBNByUsernameBL(username).Tables[0].Rows[j][0].ToString(), Convert.ToInt32(borrowsBl.GetBookAvailableByISBNBL(borrowsBl.GetBorrowsISBNByUsernameBL(username).Tables[0].Rows[j][0].ToString())));
                        }
                        dgvIssue.Rows.RemoveAt(rowIndex);
                        borrowsBl.IssueBorrowByUsername(username);
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        // do nothing
                    }
                }
                catch
                {
                    MessageBox.Show("Please click on a user to issue book(s).", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
