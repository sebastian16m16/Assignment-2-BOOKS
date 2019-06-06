using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment2.Model;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using Assignment2.View.Interface;

namespace Assignment2.Controller.Interfaces
{
    interface IUserInteract
    {
        void sellBook(Book book, int quantity);
        void returnAfterAuthor(String author, DataGridView resultsTable);
        void returnAfterTitle(String title, DataGridView resultsTable);
        void returnAfterGenre(String genre, DataGridView resultsTable);

        void updateTable(DataGridView resultsTable);


        Book getBook(String title, String author, IObserver observer);
    }
}
