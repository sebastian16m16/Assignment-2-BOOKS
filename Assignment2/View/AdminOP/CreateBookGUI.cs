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
        public CreateBookGUI()
        {
            InitializeComponent();
            CenterToScreen();
            this.AcceptButton = button1;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            AdminGUI admin = new AdminGUI();
            admin.Show();
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Book book = new Book(titleTextBox.Text, authorTextBox.Text, genreTextBox.Text,
                Double.Parse(priceTextBox.Text), Int32.Parse(quantityTextBox.Text));

            book.insertBook();

            MessageBox.Show("Book inserted!");

            AdminGUI admin = new AdminGUI();
            admin.Show();
            this.Close();

        }


    }
}
