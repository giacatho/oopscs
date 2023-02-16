using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolE
{
    class E6_alternatives
    {
        static void Main()
        {
            PrintPerfectNumbers();

        }

        static void PrintPerfectNumbers()
        {
            for (int n = 1; n < 1000; n++)
            {
                if (IsPerfect(n))
                    Console.WriteLine(n);
            }
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
