using System;

namespace Cohort1_2020
{
    public class Program
    {
        static void Main(string[] args)
        {
            Hello();
            Addition();
            Catdog();
            Oddevent();
            Inches();
            Echo();
            Killgrams();
            Date();
            Age();
            Guess();
        }

        public static void Hello()
        {
            Console.WriteLine("What is your name?");
            string answer = Console.ReadLine();
            Console.WriteLine("Goodbye" + " " + answer + "!");
        }

        public static void Addition()
        {
            Console.WriteLine("Enter your first number: ");
            int FirstNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number: ");
            int SecondNumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine(FirstNumber + SecondNumber);
            
        }

        public static void Catdog()
        {
            Console.WriteLine("cat or dog?");
            string answer = Console.ReadLine();
            if (answer == "cat")
            {
                Console.WriteLine("Meow!");
            } 
            else 
            { 
                Console.WriteLine("Bark!"); 
            }
           

        }

        public static void Oddevent()
        {
            int i;
            Console.WriteLine("Enter your number: ");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.Write("The number is even.");
            }
            else 
            {
                Console.Write("The number is odd.");
            }
            

        }

        public static void Inches()
        {
            Console.WriteLine("Please input your height in feet");
            string str_feed = Console.ReadLine();

            int feet = Int32.Parse(str_feed);
            Console.WriteLine(feet * 12 + " inches");
        }

        public static void Echo()
        {
            Console.WriteLine("Please input a word.");
            string Answer = Console.ReadLine();
            Console.WriteLine(Answer.ToUpper());
            Console.WriteLine(Answer.ToLower());
            Console.WriteLine(Answer.ToLower());
            
        }

        public static void Killgrams()
        {
            Console.WriteLine("Input your weight in pounds");
            int Pounds = Int32.Parse(Console.ReadLine());
            Console.WriteLine(Pounds / 2 + " kilograms");
        }

        // This should tell the time
        public static void Date()
        {
            Console.WriteLine(DateTime.Now);
        }

        public static void Age()
        {
            Console.WriteLine("Input your birth year: ");
            int BirthYear = Int32.Parse(Console.ReadLine());
            Console.WriteLine(DateTime.Now.Year - BirthYear + " years old");
        }

        public static void Guess()
        {
            Console.WriteLine("Guess");
            if (Console.ReadLine() == "chsarp")
            {
                Console.WriteLine("CORRECT!");
            }
            else
            {
                Console.WriteLine("WRONG!");
            }
        }
    }

        
}
