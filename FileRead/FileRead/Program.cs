using System;
using System.IO;
namespace FileRead
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string path = "C:\\files\\file1.txt";
            string txt = "Hello";
            File.WriteAllText(path, txt);*/
            string path = "C:\\files\\file1.txt";
            string txt = File.ReadAllText(path);
            Console.WriteLine(txt);
        }
    }
}
