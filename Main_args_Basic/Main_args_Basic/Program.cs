// See https://aka.ms/new-console-template for more information
using System;

namespace Main_args_Basic // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length.Equals(0))
            {
                Console.WriteLine("please provide arguments");
                return;

            }
            if (args[0].Equals("/help"))
            {
                HelpConsole();
                return;
            }
            if (!args.Length.Equals(3))
            {
                Console.WriteLine("enter /help to view the list of command");
                return;

            }
            float result = 0;
            bool isNum1parsed = float.TryParse(args[1], out float num1);
            bool isNum2parsed = float.TryParse(args[2], out float num2);
            if (isNum1parsed && isNum2parsed)
            {
                switch (args[0])
                {
                    case "add":
                        result = num1 + num2;
                        break;
                    case "sub:":
                        result = num2 - num1;
                        break;
                    default:
                        Console.WriteLine($"The instruction {args[0]} is not found");
                        HelpConsole();
                        return;
                }

            }
            Console.WriteLine("The result is: {0}", result);
            Console.ReadLine();

        }
        static void HelpConsole()
        {
            Console.WriteLine("Here is the list of the command");
            Console.WriteLine("***************************");
            Console.WriteLine("add num1 num2: print the result of num1+num2");
            Console.WriteLine("sub num1 num2: print the result of num1-num2");
        }

    }
}








