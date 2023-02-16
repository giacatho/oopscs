using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolD
{
    class D4
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            double g = random.NextDouble() * (n-1) +1; //Generate a random double between 1 and n

            while (!isApproximatelyEqual(n, g)) 
            {
                g = (g + n / g) / 2;
            }

            Console.WriteLine("{0:0.000}",g);
        }

        static bool isApproximatelyEqual(double n, double g)
        {
            // Result is within accuracy of 5 decimal 
            return Math.Abs(g * g - n) < 0.0000001;
        }
    }
}
