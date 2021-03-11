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
    public partial class frmEditAccount : Form
    {
        public frmEditAccount()
        {
            InitializeComponent();
        }

        public string username;
        public int type; // 0: Change password; 1: Edit name; 2: Change email; 3: Change address; 4: Change phone number

        private void frmEditAccount_Load(object sender, EventArgs e)
        {
            AccountBL accountBl = new AccountBL();
            switch (type)
            {
                case 0:
                    lblTitle.Text = "Change password";
                    lblInformation1.Text = "Current password:";
                    lblInformation2.Visible = false;
                    txtInformation2.Visible = false;
                    lblInformation3.Text = "New password:";
                    lblInformation4.Text = "Confirm new password:";
                    break;
                case 1:
                    lblTitle.Text = "Edit name";
                    lblInformation1.Text = "First name:";
                    txtInformation1.Text = accountBl.GetUserFirstNameBL(username);
                    txtInformation1.ReadOnly = true;
                    lblInformation2.Text = "Last name:";
                    txtInformation2.Text = accountBl.GetUserLastNameBL(username);
                    txtInformation2.ReadOnly = true;
                    lblInformation3.Text = "New first name:";
                    lblInformation4.Text = "New last name:";
                    break;
                case 2:
                    lblTitle.Text = "Change email address";
                    lblInformation1.Text = "Email address:";
                    txtInformation1.Text = accountBl.GetUserEmailBL(username);
                    txtInformation1.ReadOnly = true;
                    lblInformation2.Visible = false;
                    txtInformation2.Visible = false;
                    lblInformation3.Text = "New email address:";
                    lblInformation4.Text = "Confirm new email address:";
                    break;
                case 3:
                    lblTitle.Text = "Change address";
                    lblInformation1.Text = "Address:";
                    txtInformation1.Text = accountBl.GetUserAddressBL(username);
                    txtInformation1.ReadOnly = true;
                    lblInformation2.Visible = false;
                    txtInformation2.Visible = false;
                    lblInformation3.Text = "New address";
                    lblInformation4.Visible = false;
                    txtInformation4.Visible = false;
                    break;
                default: // Change phone number
                    lblTitle.Text = "Change phone number";
                    lblInformation1.Text = "Phone number:";
                    txtInformation1.Text = accountBl.GetUserPhoneBL(username);
                    txtInformation1.ReadOnly = true;
                    lblInformation2.Visible = false;
                    txtInformation2.Visible = false;
                    lblInformation3.Text = "New phone number:";
                    lblInformation4.Text = "Confirm new phone number:";
                    break;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
