using System;

namespace FOPCSTutoringSession
{
   class Question10
   {
      static void Main(string[] args)
      {
         // 1. Obtain a sentence from users
         Console.Write("Input a sentence: ");
         string sentence = Console.ReadLine();

         // 2. Count the number of character a
         int countA = 0;
         for (int i = 0; i < sentence.Length; i++) {
            char curChar = sentence[i];
            if (curChar == 'a') {
               countA++;
            }
         }

         // 3. Count the number of character b
         int countE = 0;
         for (int i = 0; i < sentence.Length; i++)
         {
            char curChar = sentence[i];
            if (curChar == 'e')
            {
               countE++;
            }
         }

         Console.WriteLine("Number of character a is {0} and e is {1}", countA, countE);
      }
   }
}
