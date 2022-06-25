using System;
using System.Collections.Generic;

namespace StackBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> myStack =new Stack<int>();

            for(int i = 0; i < 5; i++)
            {
                myStack.Push(i);
                Console.WriteLine($"{i} has been added to the stack");
            }
            while(myStack.Count > 0)
            {
                Console.WriteLine(myStack.Pop());
            }
            int[] myArray = { 8, 2, 3, 4, 7, 6, 9 };
            foreach(int num in myArray)
            {
                myStack.Push(num);
            }
            while(myStack.Count > 0)
            {
                Console.Write(myStack.Pop() + " ");
            }
           
        }
    }
}
