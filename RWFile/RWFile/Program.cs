using System;
using System.IO;

namespace RWFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] lines = { "first line", "second line", "third line" };
            File.WriteAllLines(@"C:\Users\camel\C#WorkSpace\C#basic\RWFile\RWFile\bin\Debug\net5.0\hey.txt", lines);

            /*
            string text = System.IO.File.ReadAllText("hello.txt");
            Console.WriteLine(text);
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\camel\C#WorkSpace\C#basic\RWFile\hello.txt");
            foreach(string line in lines)
            {
                Console.WriteLine("\t" +line);
            }
            */

        }
    }
}
