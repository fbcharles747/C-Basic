using System;
using System.Collections;
using System.Collections.Generic;

namespace HashTableBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Hashtable studentTable=new Hashtable();
            Student student1 = new Student(1, "Maria", 98);
            Student student2 = new Student(2, "Jason", 55);
            Student student3 = new Student(3, "Clara", 43);
            Student student4 = new Student(4, "Steve", 76);

            studentTable.Add(student1.Id, student1);
            studentTable.Add(student2.Id, student2);
            studentTable.Add(student3.Id, student3);
            studentTable.Add(student4.Id, student4);

            foreach(Student tmp in studentTable.Values)
            {
                Console.WriteLine($"Student ID: {tmp.Id}");
                Console.WriteLine($"Student name: {tmp.Name}");
                Console.WriteLine($"Student GPA: {tmp.Gpa}");
            }
            */
            Student[] students=new Student[5];
            students[0] = new Student(1, "Denis", 88);
            students[1] = new Student(2, "Olaf", 97);
            students[2] = new Student(6, "Ragner", 65);
            students[3] = new Student(1, "Luise", 73);
            students[4] = new Student(4, "Levi", 58);
            Hashtable studentTable = new Hashtable();
            foreach (Student student in students)
            {
                if (!studentTable.ContainsKey(student.Id))
                {
                    studentTable.Add(student.Id, student);
                    Console.WriteLine($"student with ID {student.Id} has been added");
                }
                else
                {
                    Console.WriteLine($"Student with the same ID {student.Id} already in the list");
                }
            }
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.con
        }
    }
}
