using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolD
{
   class D4_alternative
   {
      static void Main()
      {
         // Main() is for testing

         Console.WriteLine("{0:0.000}", ComputeSquareRoot(0));
         Console.WriteLine("{0:0.000}", ComputeSquareRoot(25));
         Console.WriteLine("{0:0.000}", ComputeSquareRoot(3));
      }

      static double ComputeSquareRoot(int number)
      {
         double g = GenerateRandomFromOneTo(number);

         while (!isApproximatelyEqual(number, g))
         {
            g = (g + number / g) / 2;
         }

         return g;
      }

      static double GenerateRandomFromOneTo(int toNumber)
      {
         Random random = new Random();
         return random.NextDouble() * (toNumber - 1) + 1;
      }

      static bool isApproximatelyEqual(double n, double g)
      {
         // Result is within accuracy of 5 decimal 
         return Math.Abs(g * g - n) < 0.0000001;
      }
   }
}
