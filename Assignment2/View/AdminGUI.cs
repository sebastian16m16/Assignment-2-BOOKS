using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment2.View;
using Assignment2.View.Interface;


namespace Assignment2.View
{
    public partial class AdminGUI : Form, IAdminView 
    {
        public AdminGUI()
        {
            InitializeComponent();
            CenterToScreen();
            
            
        }

        private void BackButton_Click(object sender, EventArgs e)
        {

            LoginGUI books = new LoginGUI();
            books.Show();
            this.Close();


        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            CreateBookGUI create = new CreateBookGUI();
            create.Show();
            this.Hide();
        }

        public void update()
        {
            this.bookShelfTableAdapter1.Fill(this.bookDataSet1.BookShelf);
        }

        private void ViewAllButton_Click(object sender, EventArgs e)
        {
            this.update();
        }

        
    }
}
