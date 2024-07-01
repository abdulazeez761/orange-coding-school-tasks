// See https://aka.ms/new-console-template for more information
using System;
using model.HrClassLib;
namespace HrConsoleApp
{
    public class Program
    {
        static void Main()
        {
            Console.Clear();
            // !invalid assigned data
            var employee = new Employee();

            // after the encapsolation it should not be allowed

            try
            {
                employee.BasicSalary = -5000;
                employee.SetName("Abdulaziz", "");
                employee.TaxPercentage = 140;
                employee.SetBirthDate(new DateOnly(2000, 4, 25));
                Console.WriteLine(employee.BasicSalary);
                Console.WriteLine(employee.FirstName);
                Console.WriteLine(employee.LastName);
                Console.WriteLine(employee.TaxPercentage);
                Console.WriteLine(employee.BirthDate);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (WrongName ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}