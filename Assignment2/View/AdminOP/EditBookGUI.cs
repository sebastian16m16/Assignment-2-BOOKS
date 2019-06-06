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
using Assignment2.Model;

namespace Assignment2.View.AdminOP
{
    public partial class EditBookGUI : Form
    {
        public EditBookGUI(AdminGUI adminGUI)
        {
            InitializeComponent();
            CenterToScreen();
            AcceptButton = insertBook;
            this.adminGUI = adminGUI;
        }
        AdminGUI adminGUI;
        AdminInteract adminInteract = new AdminInteract();
        bool found;
        Book book;
        private void InsertBook_Click(object sender, EventArgs e)
        {
            if (titleTextBox.Text.Equals("") || authorTextBox.Text.Equals(""))
                MessageBox.Show("Please fill the Title and the Author fields!");
            else
            {
                this.book = adminInteract.getBook(titleTextBox.Text, authorTextBox.Text, adminGUI);
                if (book.existsBook())
                {
                    AcceptButton = editButton;
                    found = true;
                    genreTextBox.Text = this.book.genre;
                    priceTextBox.Text = this.book.price + "";
                    quantityTextBox.Text = this.book.quantity + "";
                    titleTextBox.Text = this.book.title;
                    authorTextBox.Text = this.book.author;
                }
                else
                    MessageBox.Show("Book doesn't Exist!");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (found == true)
            {
                adminInteract.updateAuthor(this.book, authorTextBox.Text);
                adminInteract.updateTitle(this.book, titleTextBox.Text);
                adminInteract.updateGenre(this.book, genreTextBox.Text);
                adminInteract.updatePrice(this.book, Double.Parse(priceTextBox.Text));
                adminInteract.updateQuantity(this.book, Int32.Parse(quantityTextBox.Text));

                MessageBox.Show("Book updated!\n\n" +
                    "Title: "+ titleTextBox.Text+"\n" +
                    "Author: " + authorTextBox.Text + "\n" +
                    "Genre: " + genreTextBox.Text + "\n" +
                    "Price: " + priceTextBox.Text + "\n" +
                    "Quantity: " + quantityTextBox.Text);

                this.Close();

            }
            else
                MessageBox.Show("Please enter a valid book!");
        }

       
    }
}
