using System;

namespace MethodBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GreetFriend("Charles");
            Count("HeY ThErE !");
            Calculate();
        }
        public static void WriteSomething()
        {
            Console.WriteLine("WriteSomething is called");
        }
        public static void WriteSomethingSpecific(String myText)
        {
            Console.WriteLine(myText);
        }
        public static int Add(int num1,int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int num1,int num2)
        {
            return (num1 * num2);
        }
        public static void GreetFriend(String name)
        {
            Console.WriteLine($"Hi {name}, my friend");
        }
        public static string LowerUpper(String text)
        {
            return text.ToLower() + text.ToUpper();
            
        }
        public static void Count(string text)
        {
            Console.WriteLine($"The amount of letter is {text.Length}");
        }
        public static void Calculate()
        {
            int result=0;
            Console.WriteLine("please enter the first number");
            string userNum1=Console.ReadLine();
            Console.WriteLine("please enter the second number");
            string userNum2 = Console.ReadLine();
            try
            {
                result = int.Parse(userNum1) / int.Parse(userNum2);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("cannot divide by zero");
            }
            
            Console.WriteLine(result); 
        }
    }
}
