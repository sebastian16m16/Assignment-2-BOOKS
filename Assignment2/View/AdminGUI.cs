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
using Assignment2.View.AdminOP;
using Assignment2.Controller.Interact;


namespace Assignment2.View
{
    public partial class AdminGUI : Form, IObserver 
    {
        public AdminGUI()
        {
            InitializeComponent();
            CenterToScreen();
        }

        AdminInteract adminInteract = new AdminInteract();

        private void BackButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure?", "Exit Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                FormState.PreviousPage.Show();
                this.Hide();
            }
            
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            CreateBookGUI create = new CreateBookGUI(this);
            create.Show();
        }

        public void update()
        {
            this.bookShelfTableAdapter1.Fill(this.bookDataSet1.BookShelf);
            adminInteract.updateTable(resultsTable);
        }

        private void ViewAllButton_Click(object sender, EventArgs e)
        {
            this.update();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            EditBookGUI editBookGUI = new EditBookGUI(this);
            editBookGUI.Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteWindow deleteWindow = new DeleteWindow(this);
            deleteWindow.Show();
        }

        private void AdminGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
