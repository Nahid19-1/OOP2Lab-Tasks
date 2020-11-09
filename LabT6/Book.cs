using System;
using System.Collections.Generic;
using System.Text;

namespace LabT6
{
    class Book
    {
       
        private string bookName;

        public string BookName
        {
            get { return bookName; }
            set { bookName = value; }
        }
        private string bookAuthor;

        public string BookAuthor
        {
            get { return bookAuthor; }
            set { bookAuthor = value; }
        }
        private string bookId;

        public string BookId
        {
            get { return bookId; }
            set { bookId = value; }
        }
        private string bookType;

        public string BookType
        {
            get { return bookType; }
            set { bookType = value; }
        }
        private int bookCopy;

        public int BookCopy
        {
            get { return bookCopy; }
            set { bookCopy = value; }
        }

        private int totalBook;

        public int TotalBook
        {
            get { return totalBook; }
            set { totalBook = value; }
        }


        public Book() { }
        public Book(string bookName,string bookId,string bookType, int bookCopy)

        {
            this.bookName = bookName;
            this.bookId = bookId;
            this.bookType = bookType;
            this.bookCopy = bookCopy;

        }



        public void ShoewInfo()
        {
            Console.WriteLine("Book Name : " + bookName);
            Console.WriteLine("Book Id : " + bookId);
            Console.WriteLine("Book Type : " + bookType);
            Console.WriteLine("Book Copy : " + bookCopy);
        }
        public void AddBookCopy(int x,int bookCopy)
        {
            
            this.bookCopy = bookCopy;
            
        }






    }
}
