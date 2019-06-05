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

            //Book book = new Book("Valvet Dream", "Ion Popa", "roman", 34.6);

            //book.insertBook();

            //Console.WriteLine(book.bookInfo());



            //Book tes1 = new Book();
            //tes1.book_id = 5;
            //tes1.updateBookObject();
            //Console.WriteLine(tes1.bookInfo());

            //tes1.updatePrice(40);
            //Console.WriteLine(tes1.bookInfo());

            //tes1.deleteBook();

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
                    this.Hide();
                }
                else
                {
                    AdminGUI adminGUI = new AdminGUI();
                    adminGUI.Show();
                    this.Hide();
                    
                }
                
            }
            else
                MessageBox.Show("Invalid Login");
        }
    }
}
