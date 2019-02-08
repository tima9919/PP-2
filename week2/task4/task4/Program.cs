using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\path";
            string path1 = @"D:\path1";
            Directory.CreateDirectory(path);
            Directory.CreateDirectory(path1);
            string file = "test.txt";
            File.Create(path + @"\" + file).Dispose();
            string com = Console.ReadLine();
            string sfile = path + @"\" + file;
            string dfile = path1 + @"\" + file;
            File.Move(sfile, dfile);
        }
    }
}