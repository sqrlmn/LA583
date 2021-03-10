using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
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
                bool isDone = accountBl.LoginBL(txtUsername.Text, txtPassword.Text);
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
                    //tbAdminEmail.Clear();
                    //tbAdminPass.Clear();
                    MessageBox.Show("Invalid username or password...");
                }
            }
            else
            {
                MessageBox.Show("Enter the fields properly...");
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
            frmForgotPw fForgotPw = new frmForgotPw();
            fForgotPw.Show();
        }

        //public static string GenerateSHA512String(string inputString)
        //{
        //    SHA512 sha512 = SHA512Managed.Create();
        //    byte[] bytes = Encoding.UTF8.GetBytes(inputString);
        //    byte[] hash = sha512.ComputeHash(bytes);
        //    return GetStringFromHash(hash);
        //}

        //private static string GetStringFromHash(byte[] hash)
        //{
        //    StringBuilder result = new StringBuilder();
        //    for (int i = 0; i < hash.Length; i++)
        //    {
        //        result.Append(hash[i].ToString("X2"));
        //    }
        //    return result.ToString();
        //}

        private void txt_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the key is the enter key
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                btnLogin.PerformClick();
            }
        }
    }
}
