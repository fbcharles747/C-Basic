using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasic
{
    internal class Members
    {
        //private field
        private string jobTitle;
        private int age;
        private int salary;
        private string name;


        //public field
        public Members()
        {
            name = "Sally";
            age = 40;
            jobTitle = "developper";
            salary = 60000;

        }
        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                sharePrivateInfo();
            }
            else
            {
                Console.WriteLine($"My name is {name}, and I am {jobTitle}.");
            }
        }

        //private method field
        private void sharePrivateInfo()
        {
            Console.WriteLine($"my salary is {salary}.");
        }

        ~Members()
        {
            Console.WriteLine("Destructor is called");
            Debug.Write("Destructor is called");
        }
    }
}
