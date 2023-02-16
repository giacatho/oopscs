using System;

namespace FOPCSTutoringSession
{
   class Question7
   {
      static void Main(string[] args)
      {
         Console.Write("Please enter a word: ");
         string word = Console.ReadLine();
         int length = word.Length;
         char lastChar = word[length-1];

         Console.WriteLine("The word is {0}, its length is {1}, its last character is {2}",
            word, length, lastChar);
      }
   }
}
