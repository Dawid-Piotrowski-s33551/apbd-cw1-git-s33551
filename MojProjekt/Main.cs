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

            try
            {
                num1 = int.Parse(in1);
                num2 = int.Parse(in2);
            }
            catch
            {
                Console.WriteLine("Error: These are not integers.");
                return;
            }

            int total = StatisticsHelper.Sum(num1, num2);
            Console.WriteLine($"Sum: {total}");

            Console.WriteLine("Enter third number: ");
            var in3 = Console.ReadLine();
            int num3;
            try
            {
                num3 = int.Parse(in3);
            }
            catch
            {
                Console.WriteLine("Error: These are not integers.");
                return;
            }

            int[] values = new int[]{num1, num2, num3};

            double average = StatisticsHelper.CalculateAverage(values);
            int min = StatisticsHelper.CalculateMin(values);
            int max = StatisticsHelper.CalculateMax(values);

            Console.WriteLine($"Average: {average}");
            Console.WriteLine($"Min: {min}");
            Console.WriteLine($"Max: {max}");
        }
    }
}