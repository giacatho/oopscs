using System;

namespace FOPCSTutoringSession
{
   class Question6
   {
      static void Main(string[] args)
      {
         int[] arr = new int[5];

         // Step 1. Store the numbers
         for (int i = 0; i < arr.Length; i++)
         {
            Console.Write("Input number {0}: ", i);
            int num = Convert.ToInt32(Console.ReadLine());
            arr[i] = num;
         }

         // Key: now, we have all numbers STORED in our program

         // Step 2. Find the biggest
         // Note: you can find the biggest when we store the numbers, too
         int biggest = int.MinValue;
         for (int i = 0; i < arr.Length; i++)
         {
            int num = arr[i];
            if (num > biggest)
            {
               biggest = num;
            }
         }

         // Step 3. Compute the occurrence of the biggest
         int occurrences = 0;
         for (int i = 0; i < arr.Length; i++)
         {
            int num = arr[i];
            if (num == biggest)
            {
               occurrences++;
            }
         }

         Console.WriteLine("The biggest number is {0}, " +
               "and its times of occurrence is {1}",
            biggest, occurrences);

         // Test sample: 1 4 2 4 3
      }
   }
}
