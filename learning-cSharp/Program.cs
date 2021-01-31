using System;

namespace learningcSharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            Console.WriteLine("How old are you?");
            var age = Console.ReadLine();

            Console.WriteLine("What month were you born?");
            var birthMonth = Console.ReadLine();

            Console.WriteLine("Your name: {0}", name);
            Console.WriteLine("Your age: {0}", age);
            Console.WriteLine("Your birth month: {0}", birthMonth);

            if(birthMonth == "November")
            {
                Console.WriteLine("Your zodiak sign is Scorpio.");
            } else if (birthMonth == "October")
            {
                Console.WriteLine("Your zodiak sign is Libra.");
            }
        }
    }
}
