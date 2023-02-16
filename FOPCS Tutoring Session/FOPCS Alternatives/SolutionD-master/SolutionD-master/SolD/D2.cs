using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolD
{
    class D2
    {
        static void Main()
        {
            Console.Write("Enter A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int big = Math.Max(a, b);
            int small = Math.Min(a, b);

            while (big != small)
            {
                Console.WriteLine("Big = {0}, small {1}", big, small);
                big = big - small;
                
                if (big > small)
                {
                    continue;
                } else if (big == small)
                {
                    break; // Done
                } else if (big < small)
                {
                    // Now the big number becomes the small and
                    // vice versus, so we switch the two number using the following
                    // code
                    int temp = big;
                    big = small;
                    small = temp;
                }
            }

            Console.WriteLine("The HCF is {0}", big);
            Console.ReadKey();
        }
    }
}
