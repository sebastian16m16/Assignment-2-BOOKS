using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment2.Controller.Interact;
using Assignment2.View.Interface;
using Assignment2.Model;
using Assignment2.View.UserOP;
using System.Data.SqlClient;


namespace Assignment2.View
{
    public partial class UserGUI : Form, IObserver
    {
        public UserGUI()
        {
            InitializeComponent();
            CenterToScreen();
            AcceptButton = searchButton;
            titleCheckBox.Checked = true;

        }

        internal IObserver IObserver
        {
            get => default;
            set
            {
            }
        }

        UserInteract userInteract = new UserInteract();
        private void Button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure?", "Exit Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LoginGUI login = new LoginGUI();
                login.Show();
                this.Hide();
            }
            
        }
        public void update()
        {
            this.bookShelfTableAdapter1.Fill(this.bookDataSet1.BookShelf);

            userInteract.updateTable(resultsTable);

        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (searchBox.Text.Equals(""))
                this.update();

            if(authorCheckBox.Checked == true)
            {
                if (searchBox.Text.Equals(""))
                    this.update();
                else
                 userInteract.returnAfterAuthor(searchBox.Text, resultsTable);
            }

            if(titleCheckBox.Checked == true)
            {
                if (searchBox.Text.Equals(""))
                    this.update();
                else
                    userInteract.returnAfterTitle(searchBox.Text, resultsTable);
            }
            if (genreCheckBox.Checked == true)
            {
                if (searchBox.Text.Equals(""))
                    this.update();
                else
                    userInteract.returnAfterGenre(searchBox.Text, resultsTable);
            }
        }
        private void SellButton_Click(object sender, EventArgs e)
        {
            SellWindow sellWindow = new SellWindow(this);
            FormState.PreviousPage = this;
            sellWindow.Show();
            
        }
        private void TitleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            authorCheckBox.Checked = false;
            genreCheckBox.Checked = false;
        }
        private void AuthorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            titleCheckBox.Checked = false;
            genreCheckBox.Checked = false;
        }
        private void GenreCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            titleCheckBox.Checked = false;
            authorCheckBox.Checked = false;
        }

        private void UserGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
