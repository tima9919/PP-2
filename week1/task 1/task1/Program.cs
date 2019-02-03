using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
                
            int n = Convert.ToInt32(Console.ReadLine()); // convert int ti 32 bit
            int[] a = new int[n]; // Creating array
            string s = Console.ReadLine();// reading secong line of input
            string[] arr = s.Split();// Putting numbers into array
            int cnt = 0;//create a counter
            List<int> p = new List<int>(); //creating list
            for (int i = 0; i < n; i++) // to take every element in array
            {
                a[i] = int.Parse(arr[i]); // convert to int
                for (int j = 2; j <= a[i] / 2; j++) 
                {
                    if (a[i] % j == 0) // checking prime or not 
                    {
                        cnt++;
                    }
                }
                if (cnt == 0)
                {
                    p.Add(a[i]); // add to number of primes
                }
                cnt = 0;
            }
            for (int i = 0; i < p.Count(); i++)
            {
                if (p[i] != 1)
                    Console.Write(p[i] + " "); // final output 
            }
    }
    }
}
