using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment2.Model;

namespace Assignment2.Controller.Interfaces
{
    interface IAdminInteract
    {
        void insertBook(Book book);
        void deleteBook(Book book);
        void updateTitle(Book book, String newTitle);
        void updateAuthor(Book book, String newAuthor);
        void updatePrice(Book book, double newPrice);
        void updateQuantity(Book book, int newQuantity);
    }
}
