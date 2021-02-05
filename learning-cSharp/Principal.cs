using System;
namespace learningcSharp
{
    class Principal : Member, IPayee
    {
        public void Pay()
        {
            System.Console.WriteLine("Paying Principal");
        }
    }
}
