using System;
using System.Security.Cryptography;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student
            Student s1 = new Student();
            s1.Name = "Nahid";
            s1.Id = "19-39998-1";
            s1.Department = "CSCE";
            s1.Cgpa = 3.00f;
            s1.Showinfo();

            //Triangle
            Triangle t1 = new Triangle();
            t1.X = 5;
            t1.Y = 5;
            t1.Z = 5;
            
            t1.Showinfo();
            t1.TestTriangle();

            //Course
            Course c1 = new Course();
            c1.CourseName = "OOP2";
            c1.CourseCode = "007";
            c1.CourseCredit = 3;

            c1.Showinfo();


        }
    }
}
