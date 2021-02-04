using System;

namespace Survey
{
    class Data
    {
        public string Name;
        public int Age;
        public string Month;

        public void Display()
        {
            Console.WriteLine("Your name: {0}", Name);
            Console.WriteLine("Your age: {0}", Age);
            Console.WriteLine("Your birth month: {0}", Month);
       
            switch (Month)
            {
                case "January":
                    Console.WriteLine("Your zodiak sign is Capricorn.");
                    break;
                case "February":
                    Console.WriteLine("Your zodiak sign is Aquarius.");
                    break;
                case "March":
                    Console.WriteLine("Your zodiak sign is Pisces.");
                    break;
                case "April":
                    Console.WriteLine("Your zodiak sign is Aries.");
                    break;
                case "May":
                    Console.WriteLine("Your zodiak sign is Taurus.");
                    break;
                case "June":
                    Console.WriteLine("Your zodiak sign is Gemini.");
                    break;
                case "July":
                    Console.WriteLine("Your zodiak sign is Cancer.");
                    break;
                case "August":
                    Console.WriteLine("Your zodiak sign is Leo.");
                    break;
                case "September":
                    Console.WriteLine("Your zodiak sign is Virgo.");
                    break;
                case "October":
                    Console.WriteLine("Your zodiak sign is Libra.");
                    break;
                case "November":
                    Console.WriteLine("Your zodiak sign is Scorpio.");
                    break;
                case "December":
                    Console.WriteLine("Your zodiak sign is Sagittarius.");
                    break;
            }
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            var data = new Data();

            Console.WriteLine("What is your name?");
            data.Name = GetUserInput();

            Console.WriteLine("How old are you?");
            data.Age = int.Parse(GetUserInput());

            Console.WriteLine("What month were you born?");
            data.Month = GetUserInput();

            data.Display();
        }

        static string GetUserInput()
        {
            var input = Console.ReadLine();

            if (input == "")
            {
                Console.WriteLine("You didn't type anything, please try again.");
                return Console.ReadLine();
            }
            return input;
        }

    }
}
