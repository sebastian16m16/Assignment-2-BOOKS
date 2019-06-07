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
using Assignment2.Controller.Interact;
using Assignment2.Model;
using Assignment2.Controller;
using Assignment2.Controller.Generate_Files;

namespace Assignment2.View.UserOP
{
    public partial class SellWindow : Form
    {

        UserGUI user;
        public SellWindow(UserGUI user)
        {
            InitializeComponent();
            CenterToScreen();
            this.user = user;
            AcceptButton = sellButton;
        }
        UserInteract userInteract = new UserInteract();

        Book book;
      
        private void SellButton_Click(object sender, EventArgs e)
        {
            this.book = userInteract.getBook(titleBox.Text, authorBox.Text, user);

            if (userInteract.existsBook(this.book))
            {
                if (!quantityBox.Text.Equals(""))
                {
                    if (Int32.Parse(quantityBox.Text) <= book.quantity)
                    {
                        book.addObserver(user);
                        userInteract.sellBook(book, Int32.Parse(quantityBox.Text));

                        if (Int32.Parse(quantityBox.Text) == book.quantity)
                        {
                            GeneratePDF generatePDF = new GeneratePDF();
                            GenerateCSV generateCSV = new GenerateCSV();

                            String text = "Title: " + book.title + "\n" +
                                "Author: " + book.author + "\n" +
                                "Genre: " + book.genre;
                            String filename = book.author +"-"+ book.title;
                            generatePDF.createPDF(filename, text);

                            generateCSV.addNeededBook(book.title, book.author);


                            MessageBox.Show("There are no more books with: \n" +
                                "Title: " + book.title + "\n" +
                                "Author: " + book.author);
                        }


                        MessageBox.Show("Selled " + quantityBox.Text + " books: \n" +
                            "Title: " + titleBox.Text + "\n" +
                            "Author: " + authorBox.Text + "\n" +
                            "Total price: " + totalLabel.Text);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Insufficient stock!");
                }
                else
                    MessageBox.Show("Please fill the Quantity field!");
                
                
            }
            else
                MessageBox.Show("This book doesn't exist!");
            
            
            
        }

        private void QuantityBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(quantityBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                quantityBox.Text = quantityBox.Text.Remove(quantityBox.Text.Length - 1);
            }

            if (!authorBox.Text.Equals("") && !titleBox.Text.Equals(""))
            {

                this.book = userInteract.getBook(titleBox.Text, authorBox.Text, user);
                if (book.existsBook())
                {
                    if (quantityBox.Text.Equals(""))
                    {
                        totalLabel.Text = "0 RON";
                    }
                    else
                        totalLabel.Text = book.price * Int32.Parse(quantityBox.Text) + " RON";
                }
                
            }
            
                
            
        }

        public UserGUI UserGUI
        {
            get => default;
            set
            {
            }
        }
    }
}
