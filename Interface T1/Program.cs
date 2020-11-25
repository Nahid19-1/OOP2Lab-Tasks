using System;

namespace Interface_T1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation c1 = new Calculation("Math", "Easy");
            c1.Sum(5,5);
            c1.ShowInfo();
            Calculation c2 = new Calculation("Physics", "Hard");
            c2.Devision(2, 2);
            c1.ShowInfo();

            c1.XtoY(3, 3);
            c1.ShowInfo();

        }
    }
}
