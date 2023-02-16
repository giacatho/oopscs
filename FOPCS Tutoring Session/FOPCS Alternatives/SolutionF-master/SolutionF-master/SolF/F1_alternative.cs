using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolF
{
    class F1_alternative
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a phrase: ");
            string phrase = Console.ReadLine();

            int countA = CountVowel(phrase, "a");
            int countE = CountVowel(phrase, "e");
            int countI = CountVowel(phrase, "i");
            int countO = CountVowel(phrase, "o");
            int countU = CountVowel(phrase, "u");

            int totalVowels = countA + countE + countI + countO + countU;

            Console.WriteLine("Total number of vowels: " + totalVowels);

            Console.WriteLine("Number of 'a' : {0}", countA);
            Console.WriteLine("Number of 'e' : {0}", countE);
            Console.WriteLine("Number of 'i' : {0}", countI);
            Console.WriteLine("Number of 'o' : {0}", countO);
            Console.WriteLine("Number of 'u' : {0}", countU);

            Console.ReadKey();
        }

        static int CountVowel(string phrase, string vowel)
        {
            int counter = 0;
            for (int i = 0; i < phrase.Length; i++)
            {
                string character = phrase.Substring(i, 1).ToLower();
                
                if (character == vowel)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
