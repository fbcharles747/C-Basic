using System;

namespace DelegateBasic// Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<string> list = new List<string> { "Aiden","Sif","Walter","Anatoli"};
            Console.WriteLine("----before----");
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("----after----");
            list.RemoveAll(Filter);
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }

        }
        static bool Filter(string s)
        {
            return s.Contains("i");
        }
    }
}