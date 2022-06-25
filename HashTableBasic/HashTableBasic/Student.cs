using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableBasic
{
    internal class Student
    {
        private int id;
        private string name;
        private float gpa;
        public int Id { get { return this.id; } }
        public string Name { get { return this.name; } }
        public float Gpa { get { return this.gpa; } }

        public Student(int id, string name, float gpa)
        {
            this.id = id;
            this.name = name;
            this.gpa = gpa;
        }
    }
}
