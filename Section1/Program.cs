using System;

namespace Section1
{
    class MainClass
    {
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

            // For & While Loops
            var count = 1;
            while (count <= 5)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(i);
                }
                for (int j = 10; j > 0; j--)
                {
                    Console.WriteLine(j);
                }
                count++;
            }

            // Passcode & while loop
            var code = "";
            while (code != "secret")
            {
                Console.WriteLine("Please enter the passcode: ");
                code = Console.ReadLine();

                if (code != "secret")
                {
                    Console.WriteLine("Not Authenticated");
                }
            }

            Console.WriteLine("Authenticated");
        }
    }
}
