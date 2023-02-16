using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolE
{
   class E5_alternative
   {
      static void Main()
      {
         // Main() is for testing
         PrintPrimeNumbers();
      }

      static void PrintPrimeNumbers()
      {
         for (int n = 5; n < 10000; n++)
         {
            // Current number is n
            if (IsPrime_Improved1(n)) { // Note, here we can call any version of IsPrime(int number) below
               Console.WriteLine(n);
            }
         }
      }

      static bool IsPrime_ToBeUsedToTest(int number)
      {
         // During development, you may return a dummy
         // value to test the outside method first. For example
         // always return true.

         return true;

         // Then you need to really implement this method in the later stage
      }

      static bool IsPrime(int number)
      {
         // In this method, we try to count the total divisors of the input number.
         // The we base on that to decide if the number is prime.

         // Count variables are always OUTSIDE the loop
         int divisorCount = 0;

         for (int i = 1; i <= number; i++)
         {
            // Current number is i
            if (number % i == 0)
            {
               divisorCount++;
            }
         }

         // prime number when only divide by 
         // 1 and itself, so divisor count is 2
         if (divisorCount == 2)
            return true;
         else
            return false;
      }

      static bool IsPrime_Improved1(int number)
      {
         int divisorCount = 0;

         // Here we loop but EXCLUDE 1 and number
         for (int i = 2; i <= number-1; i++)
         {
            // Current number is i
            if (number % i == 0)
            {
               divisorCount++;
            }
         }

         // prime number when only divide by 
         // 1 and itself, both of which has been exclude.
         // So divisor count is 0
         if (divisorCount == 0)
            return true;
         else
            return false;
      }

      static bool IsPrime_Improved2(int number)
      {
         int divisorCount = 0;

         for (int i = 2; i <= number - 1; i++)
         {
            // Current number is i
            if (number % i == 0)
            {
               divisorCount++;
               // Here, we don't need to check further
               // because the number is already known
               // to be not prime. So we break out of
               // the loop
               break;
            }
         }

         // prime number when only divide by 
         // 1 and itself, both of which has been exclude.
         // So divisor count is 0
         if (divisorCount == 0)
            return true;
         else
            return false;
      }

      static bool IsPrime_Improved3(int number)
      {
         // In the previous version IsPrime_Improve3, 
         // we don't really count the number of divisors
         // but break out of the loop as long as there
         // is a divisor. So we can use a bool variable
         // instead of an int variable to count

         // The variable is set to be true. If there is
         // no other divisor, it will finish the loop and still
         // be true. Otherwise, it is false when finish the
         // loop.
         bool isPrime = true;
         
         for (int i = 2; i <= number - 1; i++)
         {
            // Current number is i
            if (number % i == 0)
            {
               // There is another divisor, so set 
               // isPrime to be false
               isPrime = false;
               
               // Here, we don't need to check further
               // because the number is already known
               // to be not prime. So we break out of
               // the loop
               break;
            }
         }

         return isPrime;
      }

      static bool IsPrime_Improved4(int number)
      {
         // In the previous version IsPrime_Improve3, we
         // break out of the loop when there's another
         // divisor. In fact, we can even exit the method
         // because we know the number is not prime

         for (int i = 2; i <= number - 1; i++)
         {
            // Current number is i
            if (number % i == 0)
            {
               // Here, we don't need to check further
               // because the number is already known
               // to be not prime. We can event exit the 
               // method
               return false; // Return that number is NOT prime
            }
         }

         // There must be NO divisors to reach here, otherwise
         // has already exit the method while inside the loop.
         // It mean, the number is prime if the code can reach here
         return true;
      }

      
   }
}
