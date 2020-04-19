using System;
using System.Collections.Generic;
using System.Linq;

namespace gradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = string.Empty;
            string student_grades = string.Empty;
            Dictionary<string, string> gradeBook = new Dictionary<string, string>();

            do
            {
                Console.WriteLine("Please enter a student name. When done enter 'quit' in names slot");
                name = Console.ReadLine().ToLower();
                if (name.Equals("quit"))
                    break;

                Console.WriteLine("Enter the grades for your student in one line with spaces.");
                student_grades = Console.ReadLine();

                gradeBook.Add(name, student_grades);

                

            } while (true);

            int bestGrade = 0;
            int worstGrade = 0;
            double averageGrade = 0.0;


            foreach (var item in gradeBook)
            {
                int[] grades = Array.ConvertAll<string, int>(gradeBook[item.Key].Split(), Convert.ToInt32);

                bestGrade = grades.Max();
                worstGrade = grades.Min();
                averageGrade = grades.Average();
                Console.WriteLine($"{item.Key}\n");
                Console.WriteLine($"Highest Grades = {bestGrade} lowest Grades = {worstGrade} Average = {averageGrade}");
            }
            
        }
    }
}
