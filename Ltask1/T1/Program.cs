using System;
using System.ComponentModel;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int m = 5;
            int sum = n + m;
            int divide = n / m;
            Console.WriteLine("Question 1 ");
            Console.WriteLine("Hello ");
            Console.WriteLine("S. M. NAHID ");
            Console.WriteLine("Question 2 ");
            Console.WriteLine("Sum of two numbers : " + sum);
            Console.WriteLine("Question 3 ");
            Console.WriteLine("Divided two numbers :" + divide);

            int a = -5;
            int b = 8;
            int c = 6;
            int multi = b * c;
            int add = a + multi;
            Console.WriteLine("Question 4 ");
            Console.WriteLine("Data a = " + add);

            int aa = 55;
            int bb = 9;
            // int cc = 9;
            int dd = aa + bb;
            int db = dd % 9;
            Console.WriteLine("Data b = " + db);

            Console.WriteLine("#################### ");

            int w, x, y, z;
            Console.Write("Enter 20,3,5,and 8 number: ");
            w = int.Parse(Console.ReadLine());
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            z = int.Parse(Console.ReadLine());
            int dc = w + (-x * y) / z;
            Console.Write("Data c =" + dc);

            Console.WriteLine("#################### ");

            int p, q;
            Console.Write("Enter 2 number: ");
            p = int.Parse(Console.ReadLine());
            q = int.Parse(Console.ReadLine());

            int addition = p + q;
            int multiply = p * q;
            int subtract = p - q;
            int devide = p / q;
            int remainder = a % b;
            Console.WriteLine("Addition : " + addition);
            Console.WriteLine("Multiplycation = " + multiply);
            Console.WriteLine("Subtract = " + subtract);
            Console.WriteLine("Divide = " + devide);
            Console.WriteLine("Remainder = " + remainder);


            Console.WriteLine("Question 6 ");
            float xx = 25.5f;
            float yy = 3.5f;
            float zz = 40.5f;
            float ww = 4.5f;

            float ans = ((xx * yy - yy * yy) / (zz - ww));
            Console.WriteLine("Answere of Qurstion 6 is =" + ans);

            Console.WriteLine("Question 7 ");
            float width = 5.5f;
            float height = 8.5f;
            float area = width * height;
            Console.WriteLine("Area : " + area);
            float perimeter = 2 * area;
            Console.WriteLine("Perimeter is =" + perimeter);

        }
    }
}
