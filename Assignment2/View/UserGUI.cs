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


namespace Assignment2.View
{
    public partial class UserGUI : Form, IUserView
    {
        public UserGUI()
        {
            InitializeComponent();
            CenterToScreen();

        }


        UserInteract userInteract = new UserInteract();

        private void Button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure?", "Exit Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LoginGUI login = new LoginGUI();
                login.Show();
                this.Close();
            }
            
        }



        //static DataTable GetTable()
        //{
        //    GetTableData getTableData = new GetTableData();
        //    DataTable table = new DataTable();

        //    table.Columns.Add("Book ID", typeof(int));
        //    table.Columns.Add("Title", typeof(String));
        //    table.Columns.Add("Author", typeof(String));
        //    table.Columns.Add("Genre", typeof(String));
        //    table.Columns.Add("Price", typeof(double));
        //    table.Columns.Add("Quantity", typeof(int));

        //    List<Book> books = getTableData.getBooks();

        //    foreach(Book p in books)
        //    {
        //        table.Rows.Add(p.book_id, p.title, p.author, p.genre, p.price, p.quantity);
        //    }

        //    return table;
        //}

        public void update()
        {
            this.bookShelfTableAdapter1.Fill(this.bookDataSet1.BookShelf);

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (searchBox.Text.Equals(""))
                this.update();
        }

        private void SellButton_Click(object sender, EventArgs e)
        {
            SellWindow sellWindow = new SellWindow(this);
            FormState.PreviousPage = this;
            sellWindow.Show();
            
        }

       
    }
}
