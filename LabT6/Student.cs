using System;
using System.Collections.Generic;
using System.Text;

namespace LabT6
{
    class Student
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        private string department;

        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        private float cgpa;

        public float Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }

        public Student()
        {

        }
        public Student(string name,string id,string department)
        {
            this.name = name;
            this.id = id;
            this.department = department;
        }
        public void ShoewInfo()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Id : " + id);
            Console.WriteLine("Department : " + department);
        }





    }
}
