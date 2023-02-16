using System;

namespace FOPCSTutoringSession
{
   class Question8
   {
      static void Main(string[] args)
      {
         string[] arr = new string[5];

         // Step 1. Store the words
         for (int i = 0; i < arr.Length; i++)
         {
            Console.Write("Input word {0}: ", i);
            string word = Console.ReadLine();
            arr[i] = word;
         }

         // Step 2: Display words
         Console.WriteLine("Words with length more than 4 " +
               "and and starts with character 'A' or 'B':");
         for (int i = 0; i < arr.Length; i++)
         {
            string word = arr[i];
            if (word.Length > 4 &&
                  (word.StartsWith("A") || word.StartsWith("B"))) 
            {
               Console.Write("{0} ", word);
            }
         }

         // Test: Hi, Best, App, Apple, Benchmark 
      }
   }
}
