using System;

namespace FOPCSTutoringSession
{
   class Question9
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

         // Step 2: Create the new array
         string[] upperCaseArr = new string[arr.Length];
         for (int i = 0; i < arr.Length; i++)
         {
            string word = arr[i];
            string upperCaseWord = word.ToUpper();
            upperCaseArr[i] = upperCaseWord;
         }

         // Step 3: Display elements of the new array
         for (int i = 0; i < upperCaseArr.Length; i++)
         {
            Console.WriteLine(upperCaseArr[i]);
         }

         // Test: hi, DipSA, class, happy, Learning 
      }
   }
}
