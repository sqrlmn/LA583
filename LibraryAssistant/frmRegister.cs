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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && txtPassword.Text != "" && txtConfirmPassword.Text != "" && txtFirstName.Text != "" && txtLastName.Text != "" && txtEmail.Text != "" && mtbPhone.MaskCompleted && rtbAddress.Text != "")
            {
                if (txtPassword.Text == txtConfirmPassword.Text)
                {
                    AccountBL accountBl = new AccountBL();
                    if (accountBl.CreateNewAccountBL(txtUsername.Text, txtPassword.Text, "0", txtFirstName.Text, txtLastName.Text, txtEmail.Text, rtbAddress.Text, mtbPhone.Text))
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
                    MessageBox.Show("New password confirmation does not match the new password", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MessageBox.Show("There is an error...", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter the fields properly...", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
