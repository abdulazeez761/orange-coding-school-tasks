using System;

class Program
{
    static void Main()
    {
        Console.Clear();

        int[] ARR = { 1, 7, 9, 45 };
        string[] arr2 = { "Str", "alex", "moh" };
        string[] arr3 = { "the", "fox", "over", "lazy", "dog" };

        string[] fruits = { "Tomato", "Banana", "Watermelon" };
        int indexOfBanana = Array.IndexOf(fruits, "Banana");
        int indexOfTomato = Array.IndexOf(fruits, "Tomato");

        Console.WriteLine("Index of Banana: " + indexOfBanana);
        Console.WriteLine("Index of Tomato: " + indexOfTomato);

        string[] favoriteFoods = { "Pizza", "Sushi", "Burger", "Pasta", "Tacos" };
        string[] favoriteSports = { "Soccer", "Basketball", "Tennis" };
        string[] favoriteMovies = { "Inception", "The Matrix", "Interstellar", "Avengers" };

        Console.WriteLine("Favorite Foods:");
        foreach (var food in favoriteFoods)
        {
            Console.WriteLine(food);
        }

        Console.WriteLine("\nFavorite Sports:");
        foreach (var sport in favoriteSports)
        {
            Console.WriteLine(sport);
        }

        Console.WriteLine("\nFavorite Movies:");
        foreach (var movie in favoriteMovies)
        {
            Console.WriteLine(movie);
        }
        Console.WriteLine("Input three numbers separated by comma: ");
        string input = Console.ReadLine();
        string[] numbers = input.Split(',');

        if (numbers.Length != 3)
        {
            Console.WriteLine("Invalid input. Please enter exactly three numbers separated by comma.");
            return;
        }

        int num1 = int.Parse(numbers[0].Trim());
        int num2 = int.Parse(numbers[1].Trim());
        int num3 = int.Parse(numbers[2].Trim());

        int sum = num1 + num2 + num3;
        string sumString = "The sum of three numbers: {0}";
        Console.WriteLine(string.Format(sumString, sum));

        for (int i = 0; i < 9; i++)
        {

            for (int j = 0; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.Write("\n");
        }
        int count = 1;
        for (int i = 0; i < 4; i++)
        {

            for (int j = 0; j <= i; j++)
            {
                Console.Write(count);
                count++;
            }
            Console.Write("\n");
        }
    }
}
