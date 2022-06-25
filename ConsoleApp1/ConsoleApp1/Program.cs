using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static int[][] jaggedArray = new int[][]
        {
            new int [] { 1, 2, 3 },
            new int []{2,67,8}
        };
        static void Main(string[] args)
        {
            /*
           for(int i = 0; i < jaggedArray.Length; i++)
            {
                for(var j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(" {0}", jaggedArray[i][j]);
                }
            }
            */
            /*
            int[] hapiness = {1,2, 3,6,9};
            AddingTwo(hapiness);
            foreach(int num in hapiness)
            {
                Console.WriteLine(num);
            }
            */
            /*
            ParamsMethod1("this is", "just a long sentence.", "no idea where it is going to end ...");
            ParamsMethod2(5.32,3.14f,'@',"hobby");
            */
            int mini=MinV2(45, 23, 89, 405, 89, 98, 12, 3);
            Console.WriteLine($"The minimun value is: {mini}");
        }

        public static int MinV2(params int[] integerlist)
        {
            int min=int.MaxValue;
            foreach (int integer in integerlist)
            {
                if(integer < min)
                {
                    min=integer;
                }
            }
            return min;
        }

        private static void ParamsMethod2(params object[] listofobj)
        {
            foreach (object obj in listofobj)
            {
                Console.Write(obj +  " ");
            }
        }
       

        private static void ParamsMethod1(params string[] sentence)
        {
            foreach( string tmp in sentence)
            {
                Console.Write(tmp+' ');
            }
            Console.WriteLine();
        }

        private static void AddingTwo(int[]givenArray)
        {
            for(int i=0;i<givenArray.Length;i++)
            {
                givenArray[i] += 2;
            }

        }
    }
}
