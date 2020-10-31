using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace Lab3
{
    class Student
    {
        string name;
        string id;
        string department;
        float cgpa;

        public string Name 
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Department
        {
            get
            {
                return department;
            }
            set
            {
                department = value;

            }
        }
        public float Cgpa
        {
            get
            {
                return cgpa;
            }
            set
            {
                cgpa = value;

            }
        }

            internal void Showinfo()
        {

            Console.WriteLine("Name is :  " + name);
            Console.WriteLine("Id is:  " + id);
            Console.WriteLine("Departmenrt is :  " + department);
            Console.WriteLine("Cgpa is : " + cgpa);


        }
    }
    
}
