﻿using System;
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
        string quantity;
        string isbn;

        public frmBook(string isbn, string title, string author, string subject, string pages, string quantity, string rating)
        {
            InitializeComponent();
            label10.Text = isbn + "               "  +  pages + "               " + author + "             " + quantity + "               " + subject + "               " + rating;
            label3.Text = title;
            this.quantity = quantity;
            this.isbn = isbn;
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
            int quan = Int32.Parse(quantity);
            if (quan != 0)
            {
                MessageBox.Show("Cannot reserve this book. Copies are available to rent.");
            }
            else
            {
                MessageBox.Show("Book Reserved!");
                ReservationBL reserveBL = new ReservationBL();

            }


        }
    }
}
