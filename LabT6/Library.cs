using System;
using System.Collections.Generic;
using System.Text;

namespace LabT6
{
    class Library
    {
        private string libName; 

        public string LibName
        {
            get { return libName; }
            set { libName = value; }
        }
        private string libAddress;

        public string LibAddress
        {
            get { return libAddress; }
            set { libAddress = value; }
        }

        

        private Book[] listofBook;

        private int totalBook;

        public int TotalBook
        {
            get { return totalBook; }
            set { totalBook = value; }
        }

        public Library()
        {
            listofBook = new Book[500];
            totalBook = 0;
        }
        public Library(string libName, string libAddress)
        {
            this.libName = libName;
            this.libAddress = libAddress;
            listofBook = new Book[500];
            totalBook = 0;
        }

        public void ShowAllBooks()
        {
            for(int i = 0; i < totalBook; i++)
            {
                listofBook[i].ShoewInfo();
            }
        }
        public void AddNewBook(params Book[] listofBook)
        {
            foreach( var book in listofBook)
            {
                if (totalBook < 500)
                    this.listofBook[totalBook++] = book;
                else
                    Console.WriteLine("Can not add Book");
            }
        }
        public void DeleteBook( params Book[]  listofBook)
        {
            foreach(var book in listofBook)
            {
                if (totalBook == )
                    this.listofBook[totalBook--] = book;
            }
        }
        public void AddNewBookCopy(int copy, params Book[] listofBook)
        {
            foreach(var book in listofBook)
            {
                if (totalBook < 500)
                    this.listofBook[totalBook++] = book;
                else
                    Console.WriteLine("Can not add new book");
            }
        }



        public void ShoewInfo()
        {
            Console.WriteLine("Library Name : " + libName);
            Console.WriteLine("Library Address : " + libAddress);
            
        }


    }
}
