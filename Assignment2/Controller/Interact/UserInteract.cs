using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment2.DataBase;
using Assignment2.Model;
using Assignment2.View;
using Assignment2.Controller.Interfaces;
using System.Data.SqlClient;

namespace Assignment2.Controller.Interact
{
    class UserInteract : IUserInteract
    {
        DBConnection dBConnection = new DBConnection();

        public Book getBook(string title, string author)
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
                         reader.GetString(2), reader.GetString(3), reader.GetDouble(4), reader.GetInt32(5));
                    }
                }
            }
            return book;
        }

        public List<Book> searchAuthor(string author)
        {
            List<Book> books = new List<Book>();

            String stmt = "Select * from bookshelf where author = @author";

            using(SqlCommand command = new SqlCommand(stmt, dBConnection.getConnection()))
            {
                command.Parameters.AddWithValue("@author", author);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Book book = new Book(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), 
                        reader.GetDouble(4), reader.GetInt32(5));
                    books.Add(book);
                }
            }
            return books;
        }

        public List<Book> searchGenre(string genre)
        {
            List<Book> books = new List<Book>();

            String stmt = "Select * from bookshelf where genre = @genre";

            using (SqlCommand command = new SqlCommand(stmt, dBConnection.getConnection()))
            {
                command.Parameters.AddWithValue("@genre", genre);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Book book = new Book(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),
                        reader.GetDouble(4), reader.GetInt32(5));
                    books.Add(book);
                }
            }
            return books;
        }

        public List<Book> searchTitle(string title)
        {
            List<Book> books = new List<Book>();

            String stmt = "Select * from bookshelf where title = @title";

            using (SqlCommand command = new SqlCommand(stmt, dBConnection.getConnection()))
            {
                command.Parameters.AddWithValue("@title", title);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Book book = new Book(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),
                        reader.GetDouble(4), reader.GetInt32(5));
                    books.Add(book);
                }
            }
            return books;
        }

        public void sellBook(Book book, int quantity)
        {
            book.sellBook(quantity);
        }

        public bool existsBook(Book book)
        {
            return book.existsBook();
        }
    }
}
