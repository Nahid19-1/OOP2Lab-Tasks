using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    class Course
    {
        string courseName;
        string courseCode;
        int courseCradit;

        public string CourseName
        {
            get
            {
                return courseName;
            }
            set
            {
                courseName = value;

            }
        }
        public string CourseCode
        {
            get
            {
                return courseCode;
            }
            set
            {
                courseCode = value;

            }
        }
        public int CourseCredit
        {
            get
            {
                return courseCradit;
            }
            set
            {
                courseCradit = value;

            }
        }


            internal void Showinfo()
        {

            Console.WriteLine("Course Name is :  " + courseName);
            Console.WriteLine("Course Code is :  " + courseCode);
            Console.WriteLine("Course Credit :  " + courseCradit);
           


        }
    }
    
}
