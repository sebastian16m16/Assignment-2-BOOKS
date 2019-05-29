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

namespace Assignment2
{
    public partial class BooksApp : Form
    {
        public BooksApp()
        {
            InitializeComponent();

            Book book = new Book("Valvet Dream", "Ion Popa", "roman", 34.6);

            book.insertBook();

            Console.WriteLine(book.bookInfo());


        }

       
    }
}
