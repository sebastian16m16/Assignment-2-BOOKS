using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment2.DataBase;
using Assignment2.Model;
using System.Windows.Forms;
using Assignment2.Controller.Interfaces;
using System.Data.SqlClient;
using System.Data;
using Assignment2.View.Interface;

namespace Assignment2.Controller.Interact
{
    class UserInteract : IUserInteract
    {
        DBConnection dBConnection = new DBConnection();

        internal IUserInteract IUserInteract
        {
            get => default;
            set
            {
            }
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
        public void sellBook(Book book, int quantity)
        {
            book.sellBook(quantity);
        }
        public bool existsBook(Book book)
        {
            return book.existsBook();
        }
        public void returnAfterAuthor(string author, DataGridView resultsTable)
        {
            String stmt = "Select * from bookshelf where author = @author";

            using (SqlCommand command = new SqlCommand(stmt, dBConnection.getConnection()))
            {
                command.Parameters.AddWithValue("@author", author);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;

                resultsTable.DataSource = bindingSource;

                dataAdapter.Update(dataTable);
            }
        }
        public void returnAfterTitle(string title, DataGridView resultsTable)
        {
            String stmt = "Select * from bookshelf where title = @title";

            using (SqlCommand command = new SqlCommand(stmt, dBConnection.getConnection()))
            {
                command.Parameters.AddWithValue("@title", title);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;

                resultsTable.DataSource = bindingSource;

                dataAdapter.Update(dataTable);
            }
        }
        public void returnAfterGenre(string genre, DataGridView resultsTable)
        {
            String stmt = "Select * from bookshelf where genre = @genre";

            using (SqlCommand command = new SqlCommand(stmt, dBConnection.getConnection()))
            {
                command.Parameters.AddWithValue("@genre", genre);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;

                resultsTable.DataSource = bindingSource;

                dataAdapter.Update(dataTable);
            }
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
