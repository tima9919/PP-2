using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"D:\task2cin.txt");
            string[] arr = text.Split();
            int n = arr.Length;
            string final = "";
            int[] a = new int[n];
            bool check = false;
            Console.WriteLine(n);
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(arr[i]);
                for (int j = 2; j < a[i] / 2; j++)
                {
                    if (a[i] % j == 0)
                    {
                        check = true;
                        break;
                    }
                }
                if (check == false)
                {
                    final = final + a[i] + " ";
                }
                check = false;
            }
            System.IO.File.WriteAllText(@"D:\task2cout.txt", final);

        }
    }
}