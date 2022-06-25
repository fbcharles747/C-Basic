using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\camel\C#WorkSpace\C#basic\Assignment 3\input2.txt";
            
            string input=File.ReadAllText(path);

            string pattern = @"\d{2,4}";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
            int detectedInt;
            foreach (Match match in matches)
            {
                int.TryParse(match.Value, out detectedInt);
                Console.WriteLine(detectedInt);
            }
        }
    }
}
