using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()); // convert specified value to a 32-bit signed integer 
            string[] arr = Console.ReadLine().Split(); // create array and split a string into a maximum number of substrings based on the strings in an array.
            int[] a = new int[n * 2]; // repeat every element in array
            for (int i = 0; i < n; i++) // for every element
            {
                a[i * 2] = int.Parse(arr[i]); // convert strings in array  to int
                a[i * 2 + 1] = a[i * 2]; // going to next element
            }
            for (int i = 0; i < n * 2; i++) // to output every element 
            {
                Console.Write(a[i] + " ");
                }
            }
    }
}
