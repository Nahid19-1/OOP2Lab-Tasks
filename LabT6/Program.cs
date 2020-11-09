using System;

namespace LabT6
{
    class Program
    {
        static void Main(string[] args)
        {
            Library l = new Library("National","Dhaka");
            Student s1 = new Student("Nahid","2020","CSE");
            

            l.ShoewInfo();
            Console.WriteLine();
            
            s1.ShoewInfo();
            Console.WriteLine();
            Book b1 = new Book("Bon", "007", "Action", 10);
            Book b2 = new Book("Rom", "123", "Action", 20);

            l.AddNewBook(b1,b2);

            l.ShowAllBooks();

        }
    }
}
