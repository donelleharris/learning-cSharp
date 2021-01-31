using System;

namespace learningcSharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //LinkedIn Learning C# For & While Loops

            var count = 1;
            while (count <= 5)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(i);
                }
                for(int j = 10; j > 0; j--)
                {
                    Console.WriteLine(j);
                }
                count++;
            }

            //LinkedIn Learning C# Passcode & while loop
            //var code = "";
            //while (code != "secret")
            //{
            //    Console.WriteLine("Please enter the passcode: ");
            //    code = Console.ReadLine();

            //    if(code != "secret"){
            //        Console.WriteLine("Not Authenticated");
            //    }
            //}

            //Console.WriteLine("Authenticated");

            // LinkedIn Learning C# 
            //Console.WriteLine("What is your name?");
            //var name = Console.ReadLine();

            //Console.WriteLine("How old are you?");
            //var age = Console.ReadLine();

            //Console.WriteLine("What month were you born?");
            //var birthMonth = Console.ReadLine();

            //Console.WriteLine("Your name: {0}", name);
            //Console.WriteLine("Your age: {0}", age);
            //Console.WriteLine("Your birth month: {0}", birthMonth);

            //if(birthMonth == "November")
            //{
            //    Console.WriteLine("Your zodiak sign is Scorpio.");
            //} else if (birthMonth == "October")
            //{
            //    Console.WriteLine("Your zodiak sign is Libra.");
            //}
        }
    }
}
