using System;

namespace task_condetional_statments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClearConsole(); // just to clear tconsole after each run

            // Existing code
            Console.WriteLine("write two integers: ");
            // int num1 = int.Parse(Console.ReadLine());
            // int num2 = int.Parse(Console.ReadLine());
            // Console.WriteLine(num1 > num2 ? num2 : num1);

            // max int
            int[] nums = { -5, 2, -6, 0, -1 };
            int max = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max) max = nums[i];
                continue;
            }
            // Console.WriteLine(max);

            //kilometers per hour to miles 
            // double kmPerHour, milesPerHour;
            // Console.Write("Input kilometers per hour: ");
            // kmPerHour = double.Parse(Console.ReadLine());

            // milesPerHour = kmPerHour * 0.621371;

            // Console.WriteLine(milesPerHour);

            // total minutes
            int hours = 5;
            int minutes = 37;
            Console.WriteLine($"total minutes: {(hours * 60) + minutes}");

            string text = "Bananas";
            for (int i = text.Length - 1; i >= 0; i--)
            {
                Console.Write(text[i]);
            }
            Console.WriteLine("\n");
        }




        static void ClearConsole()
        {
            Console.Clear();
        }
    }
}
