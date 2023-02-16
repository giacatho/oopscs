using System;

namespace FOPCSTutoringSession
{
   class Question4a
   {
      static void Main(string[] args)
      {
         Console.Write("Input number 1: ");
         int num1 = Convert.ToInt32(Console.ReadLine());

         Console.Write("Input number 2: ");
         int num2 = Convert.ToInt32(Console.ReadLine());

         Console.Write("Input number 3: ");
         int num3 = Convert.ToInt32(Console.ReadLine());

         Console.Write("Input number 4: ");
         int num4 = Convert.ToInt32(Console.ReadLine());

         Console.Write("Input number 5: ");
         int num5 = Convert.ToInt32(Console.ReadLine());

         int sum = num1 + num2 + num3 + num4 + num5;
         Console.WriteLine("Sum is {0}", sum);

         if (sum % num1 == 0) {
            Console.WriteLine(num1);
         }

         if (sum % num2 == 0)
         {
            Console.WriteLine(num2);
         }

         if (sum % num3 == 0)
         {
            Console.WriteLine(num3);
         }

         if (sum % num4 == 0)
         {
            Console.WriteLine(num4);
         }

         if (sum % num5 == 0)
         {
            Console.WriteLine(num5);
         }

         // Test sample: 1 2 3 1 2
      }
      
   }
}
