using System;
namespace learningcSharp
{
    class Teacher : Member, IPayee
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

        public void Pay()
        {
            System.Console.WriteLine("Paying Teacher");
        }
    }
}

