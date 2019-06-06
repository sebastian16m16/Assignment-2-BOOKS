using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment2.DataBase;
using System.Data.SqlClient;
using Assignment2.Model;
using Microsoft.VisualBasic;
using Assignment2.View;

namespace Assignment2
{
    public partial class LoginGUI : Form
    {
        public LoginGUI()
        {
            InitializeComponent();
            CenterToScreen();
            this.AcceptButton = loginBtn;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.username = usernameTextBox.Text;
            login.updateLoginObject();

            if (login.loginExists() && login.password.Equals(passwordTextBox.Text))
            {
                if (!login.admin)
                {
                    UserGUI userGUI = new UserGUI();
                    userGUI.Show();
                    FormState.PreviousPage = this;
                    this.Hide();
                }
                else
                {
                    AdminGUI adminGUI = new AdminGUI();
                    adminGUI.Show();
                    FormState.PreviousPage = this;
                    this.Hide();
                    
                }
                
            }
            else
                MessageBox.Show("Invalid Login");
        }

        private void LoginGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
