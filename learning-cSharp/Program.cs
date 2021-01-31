using System;

namespace learningcSharp
{
    class MainClass
    {

        //LinkedIn Learning C#
        public static void Main(string[] args)
        {
            //Switch statements
            Console.WriteLine("How many years of experience do you have?");

            var years = int.Parse(Console.ReadLine());

            switch (years)
            {
                case 0:
                    Console.WriteLine("Entry-Level");
                    break;
                case 1:
                    Console.WriteLine("Junior");
                    break;
                case 2:
                    Console.WriteLine("Mid-Level");
                    break;
                case 3:
                    Console.WriteLine("Senior");
                    break;
                default:
                    Console.WriteLine("Lead");
                    break;
            }

            //    //Introductory functions
            //    Console.WriteLine("What is your name?");
            //    var name = GetUserInput();

            //    Console.WriteLine("How old are you?");
            //    var age = GetUserInput();

            //    Console.WriteLine("What month were you born?");
            //    var birthMonth = GetUserInput();

            //    Console.WriteLine("Your name: {0}", name);
            //    Console.WriteLine("Your age: {0}", age);
            //    Console.WriteLine("Your birth month: {0}", birthMonth);

            //    if (birthMonth == "November")
            //    {
            //        Console.WriteLine("Your zodiak sign is Scorpio.");
            //    }
            //    else if (birthMonth == "October")
            //    {
            //        Console.WriteLine("Your zodiak sign is Libra.");
            //    }
            //}

            //static string GetUserInput()
            //{
            //    var input = Console.ReadLine();

            //    if (input == "")
            //    {
            //        Console.WriteLine("You didn't type anything, please try again.");
            //        return Console.ReadLine();
            //    }
            //    return input;
            //}

            // Arrays & Foreach loop
            //var studentGrades = new int[] { 80, 77, 45, 87, 52, 43, 67, 24, 86, 98 };
            //foreach (var grade in studentGrades)
            //{
            //    Console.WriteLine(grade);
            //}


            // For & While Loops
            //var count = 1;
            //while (count <= 5)
            //{
            //    for (int i = 1; i <= 10; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    for (int j = 10; j > 0; j--)
            //    {
            //        Console.WriteLine(j);
            //    }
            //    count++;
            //}

            // Passcode & while loop
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

            // User input & if/elseif 
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
