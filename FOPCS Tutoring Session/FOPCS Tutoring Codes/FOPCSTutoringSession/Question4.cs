using System;

namespace FOPCSTutoringSession
{
   class Question4
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

         Console.WriteLine("Sum is {0}", num1 + num2 + num3 + num4 + num5);
      }
      
   }
}
