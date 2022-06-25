using System;

namespace StringManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int age = 21;
            string name = "Charles";
            string job = "Developper";
            Console.WriteLine($"Hello, my name is {name}. I am {age} years old, and I am a {job}");
            */
            //first exercise
            /*
            Console.WriteLine("Please enter your name and press enter");
            String storedString=Console.ReadLine();
            string result = String.Format("$Upper: {0}", storedString.ToUpper());
            Console.WriteLine(result);
            Console.WriteLine(storedString.ToLower());
            Console.WriteLine(storedString.Trim());
            */

            Console.WriteLine("Please enter the string here: ");
            String storedString = Console.ReadLine();
            Console.WriteLine("Please enter the character to search: ");
            char searchChar =(char) Console.Read();
            Console.WriteLine($"The character appear at {storedString.IndexOf(searchChar)} place");


        }
    }
}
