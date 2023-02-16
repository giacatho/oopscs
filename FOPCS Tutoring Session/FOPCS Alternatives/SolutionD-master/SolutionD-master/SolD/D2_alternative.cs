using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolD
{
   class D2_alternative
   {
      static void Main()
      {
         // Main() is for testing
         int HCF;
         int LCM;

         HCF = ComputeHCF(8, 4);
         LCM = ComputeLCM(8, 4, HCF);
         Console.WriteLine("A={0}, B={1}, then HCF={2}, LCM={3}", 
            8, 4, HCF, LCM);

         HCF = ComputeHCF(120, 2000);
         LCM = ComputeLCM(120, 2000, HCF);
         Console.WriteLine("A={0}, B={1}, then HCF={2}, LCM={3}",
            120, 2000, HCF, LCM);
      }

      static int ComputeHCF(int number1, int number2)
      {
         int big = Math.Max(number1, number2);
         int small = Math.Min(number1, number2);

         while (big != small)
         {
            // Console.WriteLine("Big = {0}, small {1}", big, small);
            big = big - small;

            if (big > small)
            {
               continue;
            }
            else if (big == small)
            {
               break; // Done
            }
            else if (big < small)
            {
               // Now the big number becomes the small and
               // vice versus, so we switch the two number using the following
               // code
               int temp = big;
               big = small;
               small = temp;
            }
         }

         // After the loop, big or small are both HCF
         return big;
      }

      static int ComputeLCM(int number1, int number2, int HCF)
      {
         return number1 * number2 / HCF;
      }
   }
}
