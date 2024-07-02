using System;

namespace Function_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinutesToSeconds(5));
            Console.WriteLine(Increment(5));
            Console.WriteLine(GetFirstElement(new int[] { 1, 2, 3 }));
            Console.WriteLine(CalculateTriangleArea(5, 10));
            int[] nums = { 5, 2, 2, 1, 8, 66, 55, 77, 34, 9, 55, 1 };
            evenNumberEvenIndex(nums);
            var nums2 = new int[] { 44, 5, 4, 3, 2, 10 };
            var result = powerElementIndex(nums2);
            Console.WriteLine($"[{string.Join(", ", result)}]");
            Console.WriteLine(multiplication2(5, 4));
            Console.WriteLine(multiplication2(2, 8));
            Console.WriteLine(multiplication2(7, 6));
            Console.WriteLine(muti2(4, 5));
            Console.WriteLine(muti2(3, 6));
            var nums3 = new int[] { 1, 2, 3, 8, 9 };
            Console.WriteLine(aveArray(nums3));
            var nums4 = new int[] { 1, 2, 3, 8, 9, 77 };
            Console.WriteLine(aveArray(nums4));

            Console.ReadKey();
        }

        static int MinutesToSeconds(int minutes)
        {
            return minutes * 60;
        }

        static int Increment(int number)
        {
            return number + 1;
        }

        static int GetFirstElement(int[] numbers)
        {
            return numbers[0];
        }

        static double CalculateTriangleArea(double _base, double height)
        {
            return 0.5 * _base * height;
        }

        static void evenNumberEvenIndex(int[] nums)
        {
            string str = "";
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0 && i % 2 == 0) str += $" {nums[i]}";
            }
            Console.WriteLine($"[{str}]");
        }

        static int[] powerElementIndex(int[] nums)
        {
            int[] result = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = (int)Math.Pow(nums[i], i);
            }
            return result;
        }

        static int multiplication2(int a, int b)
        {
            int result = 0;
            for (int i = 0; i < b; i++)
            {
                result += a;
            }
            return result;
        }

        static int muti2(int start, int end)
        {
            int result = 1;
            for (int i = start; i <= end; i++)
            {
                result *= i;
            }
            return result;
        }

        static double aveArray(int[] nums)
        {
            double sum = 0;
            foreach (int num in nums)
            {
                sum += num;
            }
            return sum / nums.Length;
        }
    }
}
 