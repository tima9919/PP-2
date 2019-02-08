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
            bool check = false;
            string text = System.IO.File.ReadAllText(@"D:\text.txt");
            for (int i = 0, j = text.Length - 1; i < text.Length / 2; i++, j--)
            {
                if (text[i] != text[j])
                {
                    check = true;
                    break;
              
                }
                if (check == true)
                {
                    Console.WriteLine("No");

                }
                else
                {
                    Console.WriteLine("Yes");
                }
            }
        }
    }
}
