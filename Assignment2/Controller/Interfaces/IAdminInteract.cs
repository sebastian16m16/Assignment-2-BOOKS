using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment2.Model;
using Assignment2.View.Interface;

namespace Assignment2.Controller.Interfaces
{
    interface IAdminInteract
    {
        void insertBook(Book book);
        void deleteBook(Book book);
        void updateTitle(Book book, String newTitle);
        void updateGenre(Book book, String newGenre);
        void updateAuthor(Book book, String newAuthor);
        void updatePrice(Book book, double newPrice);
        void updateQuantity(Book book, int newQuantity);
        Book getBook(string title, string author, IObserver observer);
    }
}
