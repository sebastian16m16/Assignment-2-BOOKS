using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment2.View;
using Assignment2.DataBase;
using Assignment2.View.Interface;

namespace Assignment2.Model.Interface
{
    interface IBookModel
    {
        int book_id { get; set; }
        string title { get; set; }
        string author { get; set; }
        string genre { get; set; }
        double price { get; set; }
        int quantity { get; set; }
      
        void addObserver(IObserver user);

        void removeObserver(IObserver user);

        //METHODS
        void insertBook();

        string bookInfo();
     
        void updateBookObject();

        bool deleteBook();

        bool updateTitle(String newTitle);

        bool updatePrice(double newPrice);

        bool updateAuthor(String newAuthor);

        bool updateGenre(String newGenre);

        bool updateQuantity(int newQuantity);

        bool sellBook(int selledQuantity);

        void notifyAll();
    }
}
