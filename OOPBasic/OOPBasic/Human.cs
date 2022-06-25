using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasic
{
    
    internal class Human
    {
        private string firstName;
        private string lastName;
        string eyeColor;
        int age;

        public Human(string firstName, string lastName,String eyeColor,int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }
        public void IntroduceSelf()
        {
            Console.WriteLine($"Hello, my name is {firstName} {lastName}. I am {age} years old, and my eye color is {eyeColor}.");
        }
    }
}
