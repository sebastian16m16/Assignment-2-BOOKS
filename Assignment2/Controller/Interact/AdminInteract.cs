using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment2.View;
using Assignment2.Controller.Interfaces;
using Assignment2.Model;
using System.Data.SqlClient;
using Assignment2.DataBase;
using Assignment2.View.Interface;
using System.Windows.Forms;
using System.Data;

namespace Assignment2.Controller.Interact
{
    class AdminInteract : IAdminInteract
    {
        AdminGUI adminView;
        DBConnection dBConnection = new DBConnection();

        public AdminInteract()
        {
           
        }

        public void insertBook (Book book)
        {
            book.insertBook();
        }
        public void deleteBook(Book book)
        {
            book.deleteBook();
        }
        public void updateAuthor(Book book, String newAuthor)
        {
            book.updateAuthor(newAuthor);
        }
        public void updatePrice(Book book, double newPrice)
        {
            book.updatePrice(newPrice);
        }
        public void updateQuantity(Book book, int newQuantity)
        {
            book.updateQuantity(newQuantity);
        }
        public void updateTitle(Book book, String newTitle)
        {
            book.updateTitle(newTitle);
        }
        public Book getBook(string title, string author, IObserver observer)
        {
            Book book = new Book();

            String stmt1 = "Select * from Bookshelf where author = @author and title = @title";
            using (SqlCommand idCommand = new SqlCommand(stmt1, dBConnection.getConnection()))
            {
                idCommand.Parameters.AddWithValue("@author", author);
                idCommand.Parameters.AddWithValue("@title", title);

                SqlDataReader reader = idCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        book = new Book(reader.GetInt32(0), reader.GetString(1),
                         reader.GetString(2), reader.GetString(3), reader.GetDouble(4), reader.GetInt32(5), observer);
                    }
                }
            }
            return book;
        }
        public void updateGenre(Book book, string newGenre)
        {
            book.updateGenre(newGenre);
        }
        public void updateTable(DataGridView resultsTable)
        {
            String stmt = "Select * from bookshelf";

            using (SqlCommand command = new SqlCommand(stmt, dBConnection.getConnection()))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = command;

                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;

                resultsTable.DataSource = bindingSource;

                dataAdapter.Update(dataTable);
            }
        }
    }
}
