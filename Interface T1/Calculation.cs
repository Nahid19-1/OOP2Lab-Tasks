using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_T1
{
    class Calculation : Calculator, IBasicCalculator, IScientificCalculator
    {
        public Calculation()
        {

        }

        public Calculation(string name,string taskType) : base(name, taskType)
        {

        }
        public void Devision(int x, int y)
        {
            int div = x / y;
            Console.WriteLine("The devision is : "+div );
        }

        public void Multiplication(int x, int y)
        {
            int mul = x * y;
            Console.WriteLine("The Multiplication is : "+ mul);
        }

        public void Sub(int x, int y)
        {
            int sub = x - y;
            Console.WriteLine("The Sub is : "+sub);
        }

        public void Sum(int x, int y)
        {
            int sum = x + y;
            Console.WriteLine("The Sum is : "+sum);
        }

        public void XtoY(int x, int y)
        {
            int xtoy = x *y;
            Console.WriteLine("The XtoY is  : "+xtoy);
        }
    }
}
