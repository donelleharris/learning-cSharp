using System;
namespace learningcSharp
{
    class Student : Member
    {
        static public int Count = 0;
        public int Grade;
        public string Birthday;
        public School School;

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
}
