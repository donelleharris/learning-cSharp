using Util;
using System;
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
                try
                {
                    var newStudent = new Student();

                    newStudent.Name = Util.Console.Ask("Student name: ");

                    newStudent.Grade = Util.Console.AskInt("Student grade: ");

                    newStudent.Birthday = Util.Console.Ask("Student birthday: ");

                    newStudent.Address = Util.Console.Ask("Student address: ");

                    newStudent.Phone = Util.Console.AskInt("Student phone number: ");

                    students.Add(newStudent);
                    Student.Count++;

                    System.Console.WriteLine("Student Count: {0}", Student.Count);

                    System.Console.WriteLine("Add another ? y/n");
                    if (System.Console.ReadLine() != "y")
                    {
                        adding = false;
                    }
                }
                catch (FormatException msg)
                {
                    System.Console.WriteLine(msg.Message);
                }
                catch (Exception)
                {
                    System.Console.WriteLine("Error adding student. Please try again.");
                }
            }

            foreach (var student in students)
            {
                System.Console.WriteLine("Name: {0}, Grade: {1}", student.Name, student.Grade);
            }
        }
        static void Import()
        {
            var importedStudent = new Student("Jenny", 97, "November 1, 2005", "123 Somewhere St, Anywhere US 77777", 1234567890);
            System.Console.WriteLine(importedStudent.Name);
        }

    }

    class Member
    {
        public string Name;
        public string Address;
        protected int phone;

        public int Phone { set { phone = value; } }
    }

    class Student : Member
    {
        static public int Count = 0;
        public int Grade;
        public string Birthday;

        public Student() { }

        public Student(string name, int grade, string birthday, string address, int phone)
        {
            Name = name;
            Grade = grade;
            Birthday = birthday;
            Address = address;
            Phone = phone;
        }
        
    }

    class Teacher : Member
    {
        public string Subject;

        public Teacher() { }

        public Teacher(string name, string address, int phone, string subject)
        {
            Name = name;
            Address = address;
            Phone = phone;
            Subject = subject;
        }
    }
} 
