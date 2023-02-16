using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolE
{
   class E4_alternative
   {
      static void Main()
      {
         // Main() is for testing
         Console.WriteLine(IsPerfect(6));
         Console.WriteLine(IsPerfect(28));
         Console.WriteLine(IsPerfect(496));

         Console.WriteLine(IsPerfect(1));
         Console.WriteLine(IsPerfect(10));
         Console.WriteLine(IsPerfect(100));

      }

      static bool IsPerfect(int number)
      {
         int sum = SumOfFactors(number);

         if (sum == number)
         {
            return true;
         } 

         return false;  // Because we're using return true above, this line has the same effect with "else return false". Why?
      }

      static int SumOfFactors(int number)
      {
         int sum = 0;

         for (int i = 1; i < number; i++)
         {
            // Current number is i
            // Check if current number is the factor of the input number
            if (number % i == 0)
            {
               sum += i;
            }
         }

         return sum;
      }
   }
}
