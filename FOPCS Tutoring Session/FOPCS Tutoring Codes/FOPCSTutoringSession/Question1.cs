using System;

namespace FOPCSTutoringSession
{
   class Question1
   {
      static void Main(string[] args)
      {
         Console.Write("Input number 1: ");
         int num1 = Convert.ToInt32(Console.ReadLine());

         Console.Write("Input number 2: ");
         int num2 = Convert.ToInt32(Console.ReadLine());

         Console.WriteLine("Total {0}", num1 + num2);
      }
   }
}
