using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using LibraryAssistantBL;

namespace LibraryAssistant
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != string.Empty && txtPassword.Text != string.Empty)
            {
                AccountBL accountBl = new AccountBL();
                bool isDone = accountBl.LoginBL(txtUsername.Text, accountBl.GenerateSHA512String(txtPassword.Text));
                if (isDone)
                {
                    frmMain fMain = new frmMain();
                    this.Hide();
                    fMain.username = txtUsername.Text;
                    fMain.Show();
                    txtUsername.Clear();
                    txtPassword.Clear();
                    fMain.FormClosed += (s, args) => this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid username or password...", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter the fields properly...", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            frmRegister fRegister = new frmRegister();
            fRegister.Show();
        }

        private void lblForgotPw_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact Admin. This function is under development.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //frmForgotPw fForgotPw = new frmForgotPw();
            //fForgotPw.Show();
        }

        private void txt_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the key is the enter key
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                btnLogin.PerformClick();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
