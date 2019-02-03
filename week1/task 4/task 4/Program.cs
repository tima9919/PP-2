using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()); // Converts the value of the specified single - precision floating - point number to an equivalent 32 - bit signed integer.
            for (int i = 1; i <= n; i++)  // ->
            {
                for (int j = 1; j <= i; j++) // to create 2-dimensional array
                {
                    Console.Write("[*]"); // creating part of triangle 
                }
                Console.WriteLine(); // write the argument of array
            }
        }
    }
}
