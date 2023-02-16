using System;

namespace FOPCSTutoringSession
{
   class Question3a
   {
      static void Main(string[] args)
      {
         for (int i = 100; i <= 1000; i++)
         {
            // The current number is i
            if (i % 3 == 0 && i % 4 == 0)
            {
               Console.Write("{0} ", i);
            }

            if (i != 100 && i % 100 == 0)
            {
               Console.WriteLine();
            }
         }
      }
   }
}
