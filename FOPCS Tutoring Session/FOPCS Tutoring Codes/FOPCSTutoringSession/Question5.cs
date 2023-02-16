using System;

namespace FOPCSTutoringSession
{
   class Question5 {
      static void Main(string[] args) {
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

         Console.WriteLine("The biggest number is {0}", biggest);

         // Test sample: 1 5 4 7 2
      }
   }
}