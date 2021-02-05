using Util;
using System;
using System.Collections.Generic;

namespace learningcSharp
{
    enum School
    {
        Hogwarts,
        Harvard,
        MIT
    }

    class Program
    {
        static List<Student> students = new List<Student>();

        public static void Main(string[] args)
        {
            PayRoll payroll = new PayRoll();
            payroll.PayAll();

            var adding = true;

            while (adding)
            {
                try
                {
                    var newStudent = new Student();

                    newStudent.Name = Util.Console.Ask("Student name: ");

                    newStudent.Grade = Util.Console.AskInt("Student grade: ");

                    newStudent.School = (School)Util.Console.AskInt("School (please type corresponding number) \n0: Hogwarts \n1: Harvard \n2: MIT:\n");

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

            Exports();
        }

        static void Import()
        {
            var importedStudent = new Student("Jenny", 97, "November 1, 2005", "123 Somewhere St, Anywhere US 77777", 1234567890);
            System.Console.WriteLine(importedStudent.Name);
        }

        static void Exports()
        {
            foreach (var student in students)
            {
                switch (student.School)
                {
                    case School.Hogwarts:
                        System.Console.WriteLine("Exporting to Hogwarts");
                        break;
                    case School.Harvard:
                        System.Console.WriteLine("Exporting to Harvard");
                        break;
                    case School.MIT:
                        System.Console.WriteLine("Exporting to MIT");
                        break;
                }
            }
        }
    }

} 
