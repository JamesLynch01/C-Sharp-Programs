using System;

namespace PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            Console.WriteLine("Enter a word please: ");
            string pig = Console.ReadLine();
            int firstVowel = pig.ToLower().IndexOfAny(vowels);
            int lastVowel = pig.ToLower().IndexOfAny(vowels, pig.Length -1);
            string firstLetter = pig.ToLower().Substring(0, 1);
            string secondLetter = pig.ToLower().Substring(1, pig.Length -1);
            //bool isFirstLetterVowel = false;
            //bool isLastLetterVowel = false;
            if (lastVowel == pig.Length -1 && firstVowel == 0)
            {
                Console.WriteLine(pig + "yay");
            }
            else if (lastVowel != pig.Length -1 && firstVowel == 0)
            {
                Console.WriteLine(pig + "ay");
            }
            else if (firstVowel > 0)
            {
                Console.WriteLine(secondLetter + firstLetter + "ay");
            }
            else
            {
                Console.WriteLine(pig + "ay");
            }
            
        }
    }
}
