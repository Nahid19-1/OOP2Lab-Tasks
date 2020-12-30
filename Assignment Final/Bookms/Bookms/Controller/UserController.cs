using Bookms.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookms.Controller
{
    class UserController
    {
        static DataBase db = new DataBase();
        public static User AuthenticateUser(string username, string password)
        {

            return db.Users.AuthhencateUser(username, password);
        }
        public static bool AddBook(dynamic book)
        {
            Book b = new Book();
            b.Name = book.Name;
            b.Author = book.Authorname;
            b.Edition = Int32.Parse( book.Edition);

            return db.Books.AddBook(b);
        }
        public static Book GetBook(string name)
        {
            return db.Books.GetBook(name);
        }

        public static ArrayList GetAllBooks()
        {
            return db.Books.GetAllBooks();
        }

    }
}
