using System;
using System.Collections.Generic;
using System.Globalization;

public class Program
{
    public static void Main()
    {
        MyClass myClass = new MyClass();

        IntroClass intro = new IntroClass();
        intro.DisplayMessage("Scott");

        FactorialClass factorial = new FactorialClass();
        Console.WriteLine("Factorial of 5 is: " + factorial.CalculateFactorial(5));

        int[] array = { 11, -2, 4, 35, 0, 8, -9 };
        SortArrayClass sortArray = new SortArrayClass();
        sortArray.SortArray(array);

        DateTime date1 = new DateTime(1981, 11, 03);
        DateTime date2 = new DateTime(2013, 09, 04);
        DateDifferenceClass dateDiff = new DateDifferenceClass();
        dateDiff.CalculateDifference(date1, date2);

        string dateString = "12-08-2004";
        DateConversionClass dateConversion = new DateConversionClass();
        dateConversion.ConvertStringToDate(dateString);
    }
}

public class MyClass
{
    public MyClass()
    {
        Console.WriteLine("MyClass class has initialized!");
    }
}

public class IntroClass
{
    public void DisplayMessage(string name)
    {
        Console.WriteLine($"Hello All, I am {name}");
    }
}

public class FactorialClass
{
    public int CalculateFactorial(int number)
    {
        if (number <= 1) return 1;
        return number * CalculateFactorial(number - 1);
    }
}

public class SortArrayClass
{
    public void SortArray(int[] array)
    {
        Array.Sort(array);
        Console.WriteLine("Sorted array: { " + string.Join(", ", array) + " }");
    }
}

public class DateDifferenceClass
{
    public void CalculateDifference(DateTime date1, DateTime date2)
    {
        TimeSpan difference = date2 - date1;
        DateTime diffDate = new DateTime(difference.Ticks);

        int years = diffDate.Year - 1;
        int months = diffDate.Month - 1;
        int days = diffDate.Day - 1;

        Console.WriteLine($"Difference: {years} years, {months} months, {days} days");
    }
}

public class DateConversionClass
{
    public void ConvertStringToDate(string dateString)
    {
        DateTime date = DateTime.ParseExact(dateString, "dd-MM-yyyy", CultureInfo.InvariantCulture);
        Console.WriteLine("Converted Date: " + date.ToString("yyyy-MM-dd"));
    }
}
