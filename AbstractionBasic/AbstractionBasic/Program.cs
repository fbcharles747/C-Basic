using System;

namespace AbstractionBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = { new Cube(5), new Sphere(5.6) };
            foreach (Shape shape in shapes)
            {
                shape.GetInfo();
                Console.WriteLine($"The volume is {shape.Volume()}");
            }
        }
    }
}
