using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolC
{
   class C5_alternative
   {
      static void Main()
      {
         // Main() is for testing
         Console.WriteLine(IsAmstrong(100));
         Console.WriteLine(IsAmstrong(370));
         Console.WriteLine(IsAmstrong(371));
         Console.WriteLine(IsAmstrong(372));
      }

      static bool IsAmstrong(int number)
      {
         int digit1 = number / 100;
         int digit2 = number % 100 / 10;
         int digit3 = number % 10;
         int sum = (int)Math.Round(Math.Pow(digit1, 3) + Math.Pow(digit2, 3) + Math.Pow(digit3, 3));

         if (sum == number)
         {
            return true;
         }
         else
         {
            return false;
         }
      }

   }
}
