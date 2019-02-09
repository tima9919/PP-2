using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task31
{
    class Program
    {
    public static void PrintSpaces(int level)
    {
        for (int i = 0; i < level; i++)
            Console.Write("     ");
    }

    public static void Ex5(DirectoryInfo dir, int level)
    {
        foreach (FileInfo f in dir.GetFiles())
        {
            PrintSpaces(level);
            Console.WriteLine(f.Name);
        }
        foreach (DirectoryInfo d in dir.GetDirectories())
        {
            PrintSpaces(level);
            Console.WriteLine(d.Name);
            Ex5(d, level + 1);
        }
    }

    
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo("C:/Users/Tima/Desktop/pp2/PP-2");
            Ex5(dir, 0);
 Console.ReadLine();
        }
       
    }
}
