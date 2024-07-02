using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetDays(new DateTime(2019 , 1 , 1), new DateTime(2019, 2, 1)));


            string[] str = { "1a", "a", "2b", "b" };

            foreach (string s in NumInString(str))
            {
                Console.WriteLine($"{s}");
            }

            Console.WriteLine(reverseOdd("Bananas")); 
            Console.WriteLine(reverseOdd("One two three four")); 

            Console.WriteLine(isPandigital(98140723568910)); 
            Console.WriteLine(isPandigital(90864523148909)); 
            Console.WriteLine(isPandigital(112233445566778899)); 


            Console.ReadKey();
        }

        static string GetDays(DateTime date1, DateTime date2) {
            TimeSpan date = date2 - date1;

            string str = $"date: {date.Days}";
            return str;
        }
        static string[] NumInString(string[] s) {
            string[] str = new string[s.Length];
            int IndexCounter = 0;
            foreach (string s2 in s) {
                if (s2.Any(char.IsDigit)) {
                    str[IndexCounter] = s2;
                    IndexCounter++;
                }
                    }
            return str;
        }
        static string reverseOdd(string str)
        {
            string[] words = str.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length % 2 != 0)
                {
                    char[] charArray = words[i].ToCharArray();
                    Array.Reverse(charArray);
                    words[i] = new string(charArray);
                }
            }
            return string.Join(" ", words);
        }

    
        static bool isPandigital(long num)
        {
            string numStr = num.ToString();
            if (numStr.Length != 10)
                return false;
            
            return numStr.Distinct().Count() == 10;
        }
    }
}
