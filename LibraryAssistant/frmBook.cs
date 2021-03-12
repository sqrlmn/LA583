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
    public partial class frmBook : Form
    {

        public frmBook(string isbn, string title, string author, string subject, string pages, string quantity, string rating)
        {
            InitializeComponent();
            label10.Text = isbn + "               "  +  pages + "               " + author + "             " + quantity + "               " + subject + "               " + rating;
            label3.Text = title;
            Refresh();
            
        }

        private void frmBook_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
