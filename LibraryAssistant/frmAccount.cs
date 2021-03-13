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
    public partial class frmAccount : Form
    {
        public frmAccount()
        {
            InitializeComponent();
        }

        public string username;
        AccountBL accountBl = new AccountBL();

        private void LoadAccountInformation()
        {
            lblUsername.Text = username;
            lblFullname.Text = accountBl.GetUserFirstNameBL(username) + " " + accountBl.GetUserLastNameBL(username);
            lblEmail.Text = accountBl.GetUserEmailBL(username);
            lblAddress.Text = accountBl.GetUserAddressBL(username);
            lblPhoneNumber.Text = accountBl.GetUserPhoneBL(username);
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            LoadAccountInformation();
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {
            frmEditAccount fEditAccount = new frmEditAccount();
            fEditAccount.username = username;
            fEditAccount.Text = "Change Password";
            fEditAccount.type = 0;
            fEditAccount.ShowDialog();
        }

        private void lblEditName_Click(object sender, EventArgs e)
        {
            frmEditAccount fEditAccount = new frmEditAccount();
            fEditAccount.username = username;
            fEditAccount.Text = "Edit Name";
            fEditAccount.type = 1;
            fEditAccount.ShowDialog();
        }

        private void lblChangeEmail_Click(object sender, EventArgs e)
        {
            frmEditAccount fEditAccount = new frmEditAccount();
            fEditAccount.username = username;
            fEditAccount.Text = "Change Email Address";
            fEditAccount.type = 2;
            fEditAccount.ShowDialog();
        }

        private void lblChangeAddress_Click(object sender, EventArgs e)
        {
            frmEditAccount fEditAccount = new frmEditAccount();
            fEditAccount.username = username;
            fEditAccount.Text = "Change Address";
            fEditAccount.type = 3;
            fEditAccount.ShowDialog();
        }

        private void lblChangePhoneNumber_Click(object sender, EventArgs e)
        {
            frmEditAccount fEditAccount = new frmEditAccount();
            fEditAccount.username = username;
            fEditAccount.Text = "Change Phone Number";
            fEditAccount.type = 4;
            fEditAccount.ShowDialog();
        }

        private void frmAccount_Activated(object sender, EventArgs e)
        {
            LoadAccountInformation();
        }
    }
}
