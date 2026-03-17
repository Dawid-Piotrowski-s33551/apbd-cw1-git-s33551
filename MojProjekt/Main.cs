using System;

namespace MojProjekt
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter first number: ");
            var in1 = Console.ReadLine();

            Console.WriteLine("Enter second number: ");
            var in2 = Console.ReadLine();

            int num1, num2;

            num1 = int.Parse(in1);
            num2 = int.Parse(in2);
            
            int total = StatisticsHelper.Sum(num1, num2);
            Console.WriteLine($"Sum: {total}");
        }
    }
}