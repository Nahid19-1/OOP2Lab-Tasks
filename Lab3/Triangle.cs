using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    class Triangle
    {
        int x;
        int y;
        int z;

        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        public int Z
        {
            get
            {
                return z;
            }
            set
            {
                z = value;
            }
        }


            internal void Showinfo()
        {

            Console.WriteLine("Value of x is :  " + x);
            Console.WriteLine("Value of Y is :  " + y);
            Console.WriteLine("Value of Z is :  " + z);
            


        }

        internal void TestTriangle()
        {
            if (x == y && y == z)
            {
                Console.Write("Equilateral triangle.\n");
            }
            else if (x == y || x == z || y == z)
            {
                Console.Write("Isosceles triangle.\n");
            }
            else
            {
                Console.Write("Scalene triangle.\n");
            }
        }

    }
    
}
