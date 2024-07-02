using System;

public class Program
{
    static void Main()
    {
        double sum;
        double average;

        // GetSumAndAverage(out sum, out average);
        // Console.WriteLine("The sum of 10 numbers is: " + sum);
        // Console.WriteLine("The average is: " + average);

        Console.WriteLine(Cube(2));

        int[] years = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };
        int[] filteredYears = GetYears(years);

        int ageInYears = int.Parse(Console.ReadLine());
        int ageInDays = AgeInDays(ageInYears);

        Console.WriteLine($"Age in days: {ageInDays}");

        Console.WriteLine("Enter a number to check if it is prime:");
        int number = int.Parse(Console.ReadLine());

        bool isPrime = IsPrime(number);
        Console.WriteLine($"{number} is a prime number: {isPrime}");

        Console.WriteLine("Enter a sentence:");
        string sentence = Console.ReadLine();

        int wordCount = CountWords(sentence);
        Console.WriteLine($"Number of words: {wordCount}");
    }
    static void GetSumAndAverage(out double sum, out double average)
    {
        sum = 0;

        Console.WriteLine("Input the 10 numbers:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Number-{i + 1} : ");
            sum += double.Parse(Console.ReadLine());
        }

        average = sum / 10;
    }

    static int Cube(int number)
    {
        return number * number * number;
    }

    static int[] GetYears(int[] years)
    {
        // First, count the number of years greater than 1950
        int count = 0;
        foreach (var year in years)
        {
            if (year > 1950)
            {
                count++;
            }
        }

        // Create an array of the appropriate size
        int[] result = new int[count];
        int index = 0;

        // Fill the array with years greater than 1950
        foreach (var year in years)
        {
            if (year > 1950)
            {
                result[index++] = year;
            }
        }

        return result;
    }

    static int AgeInDays(int years)
    {
        return years * 365;
    }


    static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        for (int i = 3; i <= Math.Sqrt(number); i += 2)
        {
            if (number % i == 0) return false;
        }

        return true;
    }



    static int CountWords(string sentence)
    {
        if (string.IsNullOrWhiteSpace(sentence)) return 0;

        int wordCount = 0;

        foreach (char c in sentence)
        {
            if (char.IsWhiteSpace(c))
            {

                wordCount++;

            }

        }

        return wordCount;
    }






}
