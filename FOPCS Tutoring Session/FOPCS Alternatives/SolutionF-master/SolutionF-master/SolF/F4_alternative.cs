using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolF
{
    class F4_alternative
    {
        static void Main()
        {
            Console.Write("Please enter a phrase: ");
            string phrase = Console.ReadLine();

            string[] words = phrase.Split(' ');

            string[] upperCaseFirstLetterWords = UpperCaseFirstLetter(words);

            string newPhrase = ConstructPhrase(upperCaseFirstLetterWords);

            Console.WriteLine(newPhrase);

            Console.ReadKey();
        }

        static string[] UpperCaseFirstLetter(string[] words)
        {
            string[] retWords = new string[words.Length];

            for (int i = 0; i < words.Length; i++)
            {
                // Current element is words[i]
                string word = words[i];
                retWords[i] = UpperCaseFirstLetter(word);
            }

            return retWords;

        }

        static string UpperCaseFirstLetter(string word)
        {
            string retStr = "";
            
            for (int i = 0; i < word.Length; i++)
            {
                string currentChar = word.Substring(i, 1);

                if (i == 0)
                {
                    retStr = retStr + currentChar.ToUpper();
                } else
                {
                    retStr = retStr + currentChar;
                }
            }

            return retStr;
        }

        static string ConstructPhrase(string[] words)
        {
            //now we reconstruct the phrase
            string newPhrase = "";
            for (int i = 0; i < words.Length; i++)
            {
                newPhrase = newPhrase + words[i];
                if (i != words.Length -1) //if this is not the last word, we add space to newphrase
                {
                    newPhrase = newPhrase + " ";
                }
            }

            return newPhrase;
        }
    }
}
