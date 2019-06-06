using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment2.Model;
using Assignment2.Controller.Interact;

namespace Assignment2.View.AdminOP
{
    public partial class DeleteWindow : Form
    {
        Book book;
        AdminGUI adminGUI;
        AdminInteract adminInteract = new AdminInteract();
        public DeleteWindow(AdminGUI adminGUI)
        {
            InitializeComponent();
            CenterToScreen();
            AcceptButton = deleteButton;
            this.adminGUI = adminGUI;
        }
        

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            this.book = adminInteract.getBook(titleTextBox.Text, authorTextBox.Text, adminGUI);

            if (book.existsBook())
            {
                if (MessageBox.Show("Are you sure?", "Delete Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    adminInteract.deleteBook(book);

                    MessageBox.Show("Book deleted!");
                    this.Close();
                }
            }
            else
                MessageBox.Show("Book doesn't exist!");
        }
    }
}
