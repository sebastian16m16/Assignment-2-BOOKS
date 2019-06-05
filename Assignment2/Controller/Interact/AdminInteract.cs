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
    }
}
