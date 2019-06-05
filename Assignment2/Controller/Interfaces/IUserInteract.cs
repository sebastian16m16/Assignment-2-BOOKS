using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment2.Model;

namespace Assignment2.Controller.Interfaces
{
    interface IUserInteract
    {
        void sellBook(Book book, int quantity);
        List<Book> searchAuthor(String author);
        List<Book> searchTitle(String title);
        List<Book> searchGenre(String genre);

        Book getBook(String title, String author);
    }
}
