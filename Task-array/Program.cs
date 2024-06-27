// See https://aka.ms/new-console-template for more information
using System;

namespace FirstTasksFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Defining variables
            double doubleVariable = 1.0;
            string stringVariable = "test";
            char charVariable = 'A';
            bool boolVariable = true;
            int intVariable = 100;
            const double constVariable = 3.14;

            // Displaying variables
            Console.WriteLine("Double: " + doubleVariable);
            Console.WriteLine("String: " + stringVariable);
            Console.WriteLine("Char: " + charVariable);
            Console.WriteLine("Bool: " + boolVariable);
            Console.WriteLine("Int: " + intVariable);
            Console.WriteLine("Const: " + constVariable);

            // Defining and displaying array of cars
            string[] cars = { "Toyota", "Honda", "Ford", "BMW" };
            Console.WriteLine("Cars array length: " + cars.Length);
            Console.WriteLine("Cars in the array:");
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }

            // Reading user input for first name, last name, and year of birth
            Console.Write("Input your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Input your last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Input your year of birth: ");
            string yearOfBirth = Console.ReadLine();

            // Displaying the inputted information
            Console.WriteLine($"{firstName} {lastName} {yearOfBirth}");

            // Storing elements in an array and printing them
            int[] elements = new int[10];
            Console.WriteLine("Input 10 elements in the array:");
            for (int i = 0; i < elements.Length; i++)
            {
                Console.Write($"element - {i} : ");
                elements[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Elements in array are: ");
            foreach (int element in elements)
            {
                Console.Write(element + " ");
            }
            int[] nums = { 2, 5, 8 };
            int sum = 0;
            foreach (int digit in nums)
            {
                sum += digit;
            }
        }
    }
}
