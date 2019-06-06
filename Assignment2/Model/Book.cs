using Assignment2.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Assignment2.DataBase;
using Assignment2.Model.Interface;
using Assignment2.View;
using Assignment2.View.Interface;

namespace Assignment2.Model
{
    class Book : IBookModel
    {
        public int book_id { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string genre { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }

       
        private IObserver userView;

        DBConnection dBConnection = new DBConnection();
        List<IObserver> observers = new List<IObserver>();

        public Book()
        {
        }

        public Book(string title, string author, string genre, double price, int quantity, IObserver userView)
        {
            this.title = title;
            this.author = author;
            this.genre = genre;
            this.price = price;
            this.quantity = quantity;
            this.userView = userView;
            addObserver(userView);
        }

        public Book(IObserver userView)
        {
            this.userView = userView;
            addObserver(userView);
        }

        public Book(int book_id, string title, string author, string genre, double price, int quantity, IObserver userView)
        {
            this.book_id = book_id;
            this.title = title;
            this.author = author;
            this.genre = genre;
            this.price = price;
            this.quantity = quantity;
            this.userView = userView;
            addObserver(userView);
        }

       

        public void addObserver(IObserver user)
        {
            observers.Add(user);
        }

        public void removeObserver(IObserver user)
        {
            observers.Remove(user);
        }

        public void notifyAll()
        {
            foreach (IObserver view in observers)
            {
                view.update();
            }
        }

        //METHODS
        public void insertBook()
        {
            String stmt = "Insert into Bookshelf (title, author, genre, price, quantity) values (@title, @author, @genre, @price, @quantity)";


            using (SqlCommand command = new SqlCommand(stmt, dBConnection.getConnection()))
            {
                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@author", author);
                command.Parameters.AddWithValue("@genre", genre);
                command.Parameters.AddWithValue("@price", price);
                command.Parameters.AddWithValue("@quantity", quantity);
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
            this.notifyAll();
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
            this.notifyAll();
        }

        public bool deleteBook()
        {

            if (title != null && author != null)
            {
                String stmt = "Delete from bookshelf where book_id = @id";

                using (SqlCommand command = new SqlCommand(stmt, dBConnection.getConnection()))
                {
                    command.Parameters.AddWithValue("@id", book_id);
                    command.ExecuteNonQuery();

                    this.notifyAll();
                    return true;
                }
            }
            else
                return false;
        }

        public bool updateTitle(String newTitle)
        {
            this.title = newTitle;

            String stmt = "Update bookshelf set title = @title where book_id = @id";

            using (SqlCommand command = new SqlCommand(stmt, dBConnection.getConnection()))
            {
                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@id", book_id);
                command.ExecuteNonQuery();

                this.notifyAll();
                return true;
            }
            return false;
        }

        public bool updatePrice(double newPrice)
        {
            this.price = newPrice;

            String stmt = "Update bookshelf set price = @newPrice where book_id = @id";

            using (SqlCommand command = new SqlCommand(stmt, dBConnection.getConnection()))
            {
                command.Parameters.AddWithValue("@newPrice", price);
                command.Parameters.AddWithValue("@id", book_id);
                command.ExecuteNonQuery();

                this.notifyAll();
                return true;
            }
            return false;
        }

        public bool updateAuthor(String newAuthor)
        {
            this.author = newAuthor;

            String stmt = "Update bookshelf set author = @newAuthor where book_id = @id";

            using (SqlCommand command = new SqlCommand(stmt, dBConnection.getConnection()))
            {
                command.Parameters.AddWithValue("@newAuthor", author);
                command.Parameters.AddWithValue("@id", book_id);
                command.ExecuteNonQuery();

                this.notifyAll();
                return true;
            }
            return false;
        }

        public bool updateGenre(String newGenre)
        {
            this.genre = newGenre;

            String stmt = "Update bookshelf set genre = @newGenre where book_id = @id";

            using (SqlCommand command = new SqlCommand(stmt, dBConnection.getConnection()))
            {
                command.Parameters.AddWithValue("@newGenre", genre);
                command.Parameters.AddWithValue("@id", book_id);
                command.ExecuteNonQuery();

                this.notifyAll();
                return true;
            }
            return false;
        }

        public bool updateQuantity(int newQuantity)
        {
            this.quantity = newQuantity;

            String stmt = "Update bookshelf set quantity = @newQuantity where book_id = @id";

            using (SqlCommand command = new SqlCommand(stmt, dBConnection.getConnection()))
            {
                command.Parameters.AddWithValue("@newQuantity", quantity);
                command.Parameters.AddWithValue("@id", book_id);
                command.ExecuteNonQuery();

                this.notifyAll();
                return true;
            }
            return false;
        }

        public bool existsBook()
        {
            if (author != null && title != null)
            {
                String stmt = "Select * from bookshelf where author = @author and title = @title";

                using (SqlCommand command = new SqlCommand(stmt, dBConnection.getConnection()))
                {
                    command.Parameters.AddWithValue("@author", this.author);
                    command.Parameters.AddWithValue("@title", this.title);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                        return true;
                    else
                        return false;
                }
            }
            else
                return false;
        }

        public bool sellBook(int selledQuantity)
        {
            if(selledQuantity <= this.quantity)
            {
                String stmt = "Update bookshelf set quantity = quantity - @selledQuantity where author = @author and title = @title";

                using (SqlCommand command = new SqlCommand(stmt, dBConnection.getConnection()))
                {
                    command.Parameters.AddWithValue("@selledQuantity", selledQuantity);
                    command.Parameters.AddWithValue("@author", this.author);
                    command.Parameters.AddWithValue("@title", this.title);
                    command.ExecuteNonQuery();

                    this.notifyAll();
                    return true;
                }
            } else
                 return false;
        }

    }
        
}

