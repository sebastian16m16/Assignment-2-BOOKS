using Assignment2.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Assignment2.DataBase;


namespace Assignment2.Model
{
    class Book
    {
        public int book_id { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string genre { get; set; }
        public double price { get; set; }

        DBConnection dBConnection = new DBConnection();

        public Book(string title, string author, string genre, double price)
        {
            this.title = title;
            this.author = author;
            this.genre = genre;
            this.price = price;
        }

        public Book() { }


        public void insertBook()
        {
            String stmt = "Insert into Bookshelf (title, author, genre, price) values (@title, @author, @genre, @price)";


            using (SqlCommand command = new SqlCommand(stmt, dBConnection.getConnection()))
            {
                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@author", author);
                command.Parameters.AddWithValue("@genre", genre);
                command.Parameters.AddWithValue("@price", price);
                command.ExecuteNonQuery();
                Console.WriteLine("Book inserted!");


            }
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
                        this.book_id = reader.GetInt32(0);
                    }
                }
            }
        }

        public string bookInfo()
        {
            return book_id + " " + title + " " + author + " " + genre + " " + price;
        }

        public void updateBookObject()
        {

            //if id is not null
            if (book_id != 0)
            {
                String stmt = "Select * from bookshelf where book_id = @book_id";

                using (SqlCommand command = new SqlCommand(stmt, dBConnection.getConnection()))
                {
                    command.Parameters.AddWithValue("@book_id", book_id);
                    command.ExecuteNonQuery();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            this.book_id = reader.GetInt32(0);
                            this.title = reader.GetString(1);
                            this.author = reader.GetString(2);
                            this.genre = reader.GetString(3);
                            this.price = reader.GetDouble(4);
                        }
                    }
                }
            }

            if (author != null && title != null)
            {
                String stmt = "Select * from bookshelf where author = @author and title = @title";

                using (SqlCommand command = new SqlCommand(stmt, dBConnection.getConnection()))
                {
                    command.Parameters.AddWithValue("@author", author);
                    command.Parameters.AddWithValue("@title", title);
                    command.ExecuteNonQuery();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            this.book_id = reader.GetInt32(0);
                            this.title = reader.GetString(1);
                            this.author = reader.GetString(2);
                            this.genre = reader.GetString(3);
                            this.price = reader.GetDouble(4);
                        }
                    }
                }
            }
        }

        public bool deleteBook()
        {

            if (title != null && author != null)
            {
                String stmt = "Delete from bookshelf where title = @title and author = @author";

                using (SqlCommand command = new SqlCommand(stmt, dBConnection.getConnection()))
                {
                    command.Parameters.AddWithValue("@title", title);
                    command.Parameters.AddWithValue("@author", author);
                    command.ExecuteNonQuery();
                    return true;
                }
            }
            else
                return false;
        }

        public bool updateTitle(String newTitle)
        {
            this.title = newTitle;

            String stmt = "Update bookshelf set title = @title";

            using (SqlCommand command = new SqlCommand(stmt, dBConnection.getConnection()))
            {
                command.Parameters.AddWithValue("@title", title);
                command.ExecuteNonQuery();
                return true;
            }
            return false;
        }

        public bool updatePrice(double newPrice)
        {
            this.price = newPrice;

            String stmt = "Update bookshelf set price = @price";

            using (SqlCommand command = new SqlCommand(stmt, dBConnection.getConnection()))
            {
                command.Parameters.AddWithValue("@price", price);
                command.ExecuteNonQuery();
                return true;
            }
            return false;
        }

        public bool updateAuthor(String newAuthor)
        {
            this.author = newAuthor;

            String stmt = "Update bookshelf set author = @author";

            using (SqlCommand command = new SqlCommand(stmt, dBConnection.getConnection()))
            {
                command.Parameters.AddWithValue("@author", author);
                command.ExecuteNonQuery();
                return true;
            }
            return false;
        }

        public bool updateGenre(String newGenre)
        {
            this.genre = newGenre;

            String stmt = "Update bookshelf set genre = @genre";

            using (SqlCommand command = new SqlCommand(stmt, dBConnection.getConnection()))
            {
                command.Parameters.AddWithValue("@genre", genre);
                command.ExecuteNonQuery();
                return true;
            }
            return false;
        }
        
    }
}
