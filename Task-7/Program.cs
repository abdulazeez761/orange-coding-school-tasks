using System;
using System.IO;

namespace Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "D:\\orange-coding-school-tasks\\Task-7\\TextFile1.txt";

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Name: Abdulaziz Faisal Al Hariri");
                writer.WriteLine("Specialization: Full-Stack Web Developer");
                writer.WriteLine("Age: 21");
                writer.WriteLine("Description: Self-taught programmer with experience in full-stack web development. Skilled in HTML, CSS, JavaScript, React.js, Node.js, Express, Nestjs, Git, GitHub, API development, JWT, Redux.js, Redux Toolkit, TailwindCSS, Discord.js, webhooks, NoSQL (MongoDB), SQL (MySQL, SQLite), Redis, TypeScript, C++, and Python.");
            }

            int totalCharacters = 0;
            int totalWords = 0;

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    totalCharacters += line.Replace(" ", "").Length;

                    string[] words = line.Split(' ');
                    totalWords += words.Length;
                }
            }

            // Printing the results
            Console.WriteLine("Total number of characters (disregarding spaces): " + totalCharacters);
            Console.WriteLine("Total number of words (disregarding spaces): " + totalWords);
            Console.ReadKey();
        }
    }
}
