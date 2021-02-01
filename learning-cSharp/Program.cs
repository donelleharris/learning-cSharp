﻿using System;
using System.Collections.Generic;

namespace learningcSharp
{
    class Program
    {
        //LinkedIn Learning C# Section 2: OOP
        public static void Main(string[] args)
        {
            var students = new List<Student>();
            
            var adding = true;

            while (adding)
            {
                var newStudent = new Student();
                Console.WriteLine("Student name: ");
                newStudent.Name = Console.ReadLine();

                Console.WriteLine("Student grade:");
                newStudent.Grade = int.Parse(Console.ReadLine());

                Console.WriteLine("Student birthday: ");
                newStudent.Birthday = Console.ReadLine();
                students.Add(newStudent);

                Console.WriteLine("Student address: ");
                newStudent.Address = Console.ReadLine();

                Console.WriteLine("Student phone number:");
                newStudent.setPhone(int.Parse(Console.ReadLine()));

                Console.WriteLine("Add another ? y/n");
                if (Console.ReadLine() != "y")
                {
                    adding = false;
                }
            }

            foreach (var student in students)
            {
                Console.WriteLine("Name: {0}, Grade: {1}", student.Name, student.Grade);
            }
        }
        class Student
        {
            public string Name;
            public int Grade;
            public string Birthday;
            public string Address;
            private int Phone;

            public void setPhone(int number){ }
        }
    }
} 
