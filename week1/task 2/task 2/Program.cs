using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class Student
    {
        public string name;
        public string id;
        public int year;

        public Student()
        {
            name = Console.ReadLine();
            id = Console.ReadLine();
            year = Convert.ToInt16(Console.ReadLine());

        }
    }
    class Program
    { 
        static void Main(string[] args)
        {
            Student s = new Student();
            Console.WriteLine(s);
        }
    }

}