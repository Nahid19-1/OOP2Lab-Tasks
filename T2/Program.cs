using System;

namespace Ltask2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n = 100;
            for (i = 1; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Even NUmbers are =" + i);
                }

            }
        }
    }
}
