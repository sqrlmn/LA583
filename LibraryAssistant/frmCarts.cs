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
    public partial class frmCarts : Form
    {
        string userName;
        string isbn;
        int row;
        public frmCarts(string username, string ISBN)
        {

            InitializeComponent();
            userName = username;
            CartsBL carts = new CartsBL();
            DataSet ds = carts.getCartsbyUsername(username);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            row = e.RowIndex;
            isbn = dataGridView1.Rows[row].Cells[0].Value.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            CartsBL carts = new CartsBL();
            if (isbn != null)
            {
                bool truthValue = carts.removeCartsbyISBN(userName, isbn);
                DataSet ds = carts.getCartsbyUsername(userName);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
    }
}
