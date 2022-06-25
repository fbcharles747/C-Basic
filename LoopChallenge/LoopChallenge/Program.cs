using System;
using System.Collections;

namespace LoopChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            bool isInt;
            int score;
            int total=0;
            int students=0;
            while (true)
            {
                Console.WriteLine("Please enter the student's score");
                isInt = int.TryParse(Console.ReadLine(), out score);
                if (isInt)
                {
                    if(0 <=score&&score <= 20)
                    {
                        total+=score;
                        students++;
                    }
                    else if (score == (-1))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("score need to sit between 0 and 20");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }

            }
            float average=total/students;
            Console.WriteLine($"The average is {average}");
        }

        private static void Challenge5()
        {
            int i = (-10);

            while (true)
            {
                // TODO
                if (i == 10)
                {
                    break;
                }

                if (i % 3 == 0)
                {
                    i++;
                    continue;

                }
                Console.WriteLine(i++);

            }
        }
    }
}
