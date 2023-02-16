using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolF
{
    class F3_alternative
    {
        static void Main()
        {
            Console.Write("Please enter a phrase: ");
            string phrase = Console.ReadLine();

            phrase = phrase.ToLower();
            string newPhrase = RemovePunctuations(phrase);

            string reversePhrase = GetReverse(phrase);
            Console.WriteLine("Reversed phrase: {0}", reversePhrase);

            if (newPhrase == reversePhrase)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }

            Console.ReadKey();
        }

        static string RemovePunctuations(string phrase)
        {
            string listOfPunctuations = ".;!?, ";

            string newphrase = "";
            //Remove all the punctuations
            for (int i = 0; i < phrase.Length; i++)
            {
                char ch = phrase[i];
                if (listOfPunctuations.Contains(ch) == false)
                    newphrase = newphrase + ch;
            }

            return newphrase;
        }

        static string GetReverse(string phrase)
        {
            string reversePhrase = "";

            //Generate reverse phrase
            for (int i = phrase.Length - 1; i>= 0; i--)
            {
                reversePhrase = reversePhrase + phrase[i];
            }

            return reversePhrase;
        }
    }
}
