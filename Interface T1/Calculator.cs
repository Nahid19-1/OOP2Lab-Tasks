using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_T1
{
    class Calculator
    {
        public string Name { get; set; }
        public string TaskType { get; set; }
        public Calculator()
        {

        }
        public Calculator(string name,string taskType)
        {
            this.Name = name;
            this.TaskType = taskType;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Name :" + Name);
            Console.WriteLine("Task Type :" + TaskType);
            Console.WriteLine("---------------------" );
        }
    }
}
