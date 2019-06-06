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

namespace Assignment2.View
{
    public partial class CreateBookGUI : Form
    {
        Book book;
        AdminGUI adminGUI;
        public CreateBookGUI(AdminGUI adminGUI)
        {
            InitializeComponent();
            CenterToScreen();
            this.AcceptButton = button1;
            this.adminGUI = adminGUI;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.book = new Book(titleTextBox.Text, authorTextBox.Text, genreTextBox.Text,
                Double.Parse(priceTextBox.Text), Int32.Parse(quantityTextBox.Text), adminGUI);
            if (!book.existsBook())
            {
                book.insertBook();

                MessageBox.Show("Book inserted!");

                this.Close();
            }
            else
                MessageBox.Show("There already exists a book with this Title and Author!");

            

        }

        private void PriceTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(priceTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                priceTextBox.Text = priceTextBox.Text.Remove(priceTextBox.Text.Length - 1);
            }
        }

        private void QuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(quantityTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                quantityTextBox.Text = quantityTextBox.Text.Remove(quantityTextBox.Text.Length - 1);
            }
        }
    }
}
