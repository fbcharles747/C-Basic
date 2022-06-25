using System;

namespace DelegateDemo2 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public delegate bool FilterDelegate(Person p);

        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            Person p1 = new Person() { Name = "Aiden", Age = 41 };
            Person p2 = new Person() { Name = "Sif", Age = 69 };
            Person p3 = new Person() { Name = "Walter", Age = 12 };
            Person p4 = new Person() { Name = "Anatoli", Age = 25 };
            List<Person> list = new List<Person> { p1, p2, p3, p4 };
            DisplayPeople("Kid", list, IsJunior);
            DisplayPeople("Exact 25: ", list, (p) => p.Age == 25);


        }
        static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
        {
            Console.WriteLine(title);
            foreach (Person p in people)
            {
                if (filter(p))
                {
                    Console.WriteLine($"{p.Name} {p.Age} years old.");
                }
            }
        }

        private static bool IsJunior(Person p)
        {
            return p.Age < 18;
        }
        static bool IsSenior(Person p)
        {
            return p.Age >65;
        }
        static bool IsAdult(Person p)
        {
            return p.Age > 18;
        }
    }
}