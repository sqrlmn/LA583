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
                    txtInformation1.PasswordChar = '*';
                    lblInformation2.Visible = false;
                    txtInformation2.Visible = false;
                    lblInformation3.Text = "New password:";
                    txtInformation3.PasswordChar = '*';
                    lblInformation4.Text = "Confirm new password:";
                    txtInformation4.PasswordChar = '*';
                    mtbInformation1.Visible = false;
                    mtbInformation2.Visible = false;
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
                    mtbInformation1.Visible = false;
                    mtbInformation2.Visible = false;
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
                    mtbInformation1.Visible = false;
                    mtbInformation2.Visible = false;
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
                    mtbInformation1.Visible = false;
                    mtbInformation2.Visible = false;
                    break;
                default: // Change phone number
                    lblTitle.Text = "Change phone number";
                    lblInformation1.Text = "Phone number:";
                    txtInformation1.Text = accountBl.GetUserPhoneBL(username);
                    txtInformation1.ReadOnly = true;
                    lblInformation2.Visible = false;
                    txtInformation2.Visible = false;
                    lblInformation3.Text = "New phone number:";
                    txtInformation3.Visible = false;
                    lblInformation4.Text = "Confirm new phone number:";
                    txtInformation4.Visible = false;
                    break;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AccountBL accountBl = new AccountBL();
            switch (type)
            {
                case 0:
                    if (accountBl.LoginBL(username, txtInformation1.Text))
                    {
                        if (txtInformation3.Text != "" && txtInformation4.Text != "")
                        {
                            if (txtInformation3.Text == txtInformation4.Text)
                            {
                                if (accountBl.UpdateUserPasswordBL(username, txtInformation3.Text))
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
                            }
                        }
                        else
                        {
                            MessageBox.Show("Enter the fields properly...", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Current password is not valid...", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case 1:
                    if (txtInformation3.Text != "" && txtInformation4.Text != "")
                    {
                        if (accountBl.UpdateUserNameBL(username, txtInformation3.Text, txtInformation4.Text))
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
                        MessageBox.Show("Enter the fields properly...", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                case 2:
                    if (txtInformation3.Text != "" && txtInformation4.Text != "")
                    {
                        if (txtInformation3.Text == txtInformation4.Text)
                        {
                            if (accountBl.UpdateUserEmailBL(username, txtInformation3.Text))
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
                            MessageBox.Show("New email address confirmation does not match the new email address", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter the fields properly...", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                case 3:
                    if (txtInformation3.Text != "")
                    {
                        if (accountBl.UpdateUserAddressBL(username, txtInformation3.Text))
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
                        MessageBox.Show("Enter the fields properly...", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                default: // Change phone number
                    if (mtbInformation1.MaskCompleted && mtbInformation2.MaskCompleted)
                    {
                        if (mtbInformation1.Text == mtbInformation2.Text)
                        {
                            if (accountBl.UpdateUserPhoneBL(username, mtbInformation1.Text))
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
                            MessageBox.Show("New phone number confirmation does not match the new phone number", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter the fields properly...", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
            }
        }

        private void txt_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the key is the enter key
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                btnSave.PerformClick();
            }
        }
    }
}
