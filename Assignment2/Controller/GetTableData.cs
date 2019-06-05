using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment2.Model;
using System.Data.SqlClient;
using Assignment2.DataBase;

namespace Assignment2.Controller
{
    class GetTableData
    {
        DBConnection connection = new DBConnection();

        public List<Book> getBooks()
        {
            List<Book> books = new List<Book>();

            String stmt = "Select * from Bookshelf";

            using (SqlCommand command = new SqlCommand(stmt, connection.getConnection()))
            {
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Book book = new Book(reader.GetInt32(0), reader.GetString(1),
                        reader.GetString(2), reader.GetString(3), reader.GetDouble(4), reader.GetInt32(5));

                    books.Add(book);
                }  
            }

            return books;
        }
    }
}
