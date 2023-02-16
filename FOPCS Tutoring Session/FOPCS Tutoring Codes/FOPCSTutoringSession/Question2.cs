using System;

namespace FOPCSTutoringSession
{
   class Question2
   { 
      static void Main(string[] args)
      {    
         Console.Write("Input number 1: ");
         int num1 = Convert.ToInt32(Console.ReadLine());

         Console.Write("Input number 2: ");
         int num2 = Convert.ToInt32(Console.ReadLine());

         if (num1 > num2)
         {
            Console.WriteLine("{0} is bigger", num1);
         }
         else if (num2 > num1)
         {
            Console.WriteLine("{0} is bigger", num2);
         }
         else
         {
            Console.WriteLine("None is bigger");
         }
      }
   }
}
