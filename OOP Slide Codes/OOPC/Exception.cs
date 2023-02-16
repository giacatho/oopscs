using System;
using System.Collections.Generic;
using System.Text;

namespace OOPC
{
   class ExceptionTest
   {
      public static void Main() {
         //Divide();
         //Divide2();
         //Divide3();
         //Divide4();
         Divide5();
         //AccessInvalidElement();
         //TestFinally3();
         //TestThrowException();
         //TestCustomException();

         Console.ReadKey();
      }

      public static void Divide() {
         Console.WriteLine("Please enter a divisor");

         string input = Console.ReadLine();
         int divisor = int.Parse(input);

         int quotient = 10 / divisor;
         Console.WriteLine(quotient);
      }

      public static void Divide2() {
         Console.WriteLine("Please enter a divisor");

         try
         {
            string input = Console.ReadLine();
            int divisor = int.Parse(input);

            int quotient = 10 / divisor;
            Console.WriteLine(quotient);
         } catch (DivideByZeroException e) {
            Console.WriteLine("Error");
         }
      }

      public static void AccessInvalidElement()
      {
         try
         {
            int[] myNumbers = { 1, 2, 3 };
            int number = myNumbers[10];
            Console.WriteLine(number);
         }
         catch (IndexOutOfRangeException e)
         {
            Console.WriteLine(e.Message);
         }
      }

      public static void Divide3()
      {
         Console.WriteLine("Please enter a divisor");

         try
         {
            string input = Console.ReadLine();
            int divisor = int.Parse(input);

            int quotient = 10 / divisor;
            Console.WriteLine(quotient);
         }
         catch (FormatException e) {
            Console.WriteLine("Sorry, your input is not in a correct format");
            Console.WriteLine(e);
         }
         catch (DivideByZeroException e)
         {
            Console.WriteLine("Sorry, unable to divide by 0");
         }

         Console.WriteLine("End of program");

      }

      public static void Divide4()
      {
         Console.WriteLine("Please enter a divisor");

         try
         {
            string input = Console.ReadLine();
            int divisor = int.Parse(input);

            int quotient = 10 / divisor;
            Console.WriteLine(quotient);
         }
         catch (FormatException e)
         {
            Console.WriteLine("Sorry, your input is not in a correct format");
            Console.WriteLine(e);
         }
         catch (IndexOutOfRangeException e)
         {
            Console.WriteLine("Sorry, unable to divide by 0");
         }

         Console.WriteLine("End of program");
      }

      public static void Divide5()
      {
         Console.WriteLine("Please enter a divisor");

         try
         {
            string input = Console.ReadLine();
            int divisor = int.Parse(input);

            int quotient = 10 / divisor;
            Console.WriteLine(quotient);
         }
         catch (DivideByZeroException e)
         {
            Console.WriteLine(e.Message);
         }
         finally
         {
            Console.WriteLine("Doing clean up");
         }

         Console.WriteLine("End of program");
      }

      public static void TestFinally1() {
         int[] arr = new int[3];

         try
         {
            Console.WriteLine("Enter try block.");
            for (int i = 0; i < arr.Length; i++)
            {
               arr[i] = i;
               Console.WriteLine(arr[i]);
            }
            Console.WriteLine("Exit try block.");
         }
         catch (IndexOutOfRangeException e)
         {
            Console.WriteLine("Exception caught.");
         }
         finally
         {
            Console.WriteLine("CleanUp. ");
         }
         Console.WriteLine("End of method. ");
      }

      public static void TestFinally2()
      {
         int[] arr = new int[3];

         try
         {
            Console.WriteLine("Enter try block.");
            for (int i = 0; i < 5; i++)
            {
               arr[i] = i;
               Console.WriteLine(arr[i]);
            }
            Console.WriteLine("Exit try block.");
         }
         catch (IndexOutOfRangeException e)
         {
            Console.WriteLine("Exception caught.");
         }
         finally
         {
            Console.WriteLine("CleanUp. ");
         }
         Console.WriteLine("End of method. ");
      }

      public static void TestFinally3()
      {
         int[] arr = new int[3];

         try
         {
            Console.WriteLine("Enter try block.");
            for (int i = 0; i < 5; i++)
            {
               arr[i] = i;
               Console.WriteLine(arr[i]);
            }
            Console.WriteLine("Exit try block.");
         }
         catch (DivideByZeroException e)
         {
            Console.WriteLine("Exception caught.");
         }
         finally
         {
            Console.WriteLine("CleanUp. ");
         }
         Console.WriteLine("End of method. ");
      }

      public static void TestThrowException() {
         try
         {
            Console.WriteLine("Please enter a divisor");

            string input = Console.ReadLine();
            int divisor = int.Parse(input);

            if (divisor == 0) {
               throw new DivideByZeroException("You ask for an invalid division");
            }

            int quotient = 10 / divisor;
            Console.WriteLine(quotient);
         }
         catch (DivideByZeroException e)
         {
            Console.WriteLine("Exception");
            Console.WriteLine(e.Message);
         }
      }

      public static void TestCustomException() {
         try
         {
            Console.WriteLine("Please enter a non negative number");

            string input = Console.ReadLine();
            double number = double.Parse(input);

            if (number < 0)
            {
               throw new NegativeNumberException(number);
            }
            Console.WriteLine("Your input number is: " + number);
         }
         catch (NegativeNumberException e)
         {
            Console.WriteLine(e.Message + ". Negative number: " + e.GetNumber());
         }
      }


   }

   class TestPropagation {
      public static void Main()
      {
         Console.WriteLine("Enter Main.");
         ExcPropagation mc = new ExcPropagation();
         try
         {
            mc.M1();
         }
         catch (Exception e)
         {
            Console.WriteLine("Enter catch block of Main.");
            Console.WriteLine("Exception from: {0}",
                     e.TargetSite);
            Console.WriteLine("Exit catch block of Main.");
         }
         Console.WriteLine("Exit Main.");
      }
   }

   public class ExcPropagation
   {
      public void M1()
      {
         try
         {
            Console.WriteLine("Enter try block of M1.");
            M2();
            Console.WriteLine("Exit try block of M1.");
         }
         catch (DivideByZeroException e)
         {
            Console.WriteLine("Enter catch block of M1.");
            Console.WriteLine("Exception from: {0}", e.TargetSite);
            Console.WriteLine("Exit catch block of M1.");
         }
         Console.WriteLine("Exit M1.");
      }

      public void M2()
      {
         Console.WriteLine("Enter M2.");
         int y = 0;
         int x = 10 / y; // Exception!!!
         Console.WriteLine("Exit M2.");
      }

   }

   public class MyException : Exception
   {
      public MyException() : base()
      {
         // empty body
      }

      public MyException(string message) : base(message)
      {
         // empty body
      }

      public MyException(string message, Exception innerExc)
      : base(message, innerExc)
      {
         // empty body
      }
   }

   public class NegativeNumberException : Exception
   {
      private double negativeNumber;

      public NegativeNumberException(double negativeNumber) :
            base("Negative number exception") {
         this.negativeNumber = negativeNumber;
      }

      public double GetNumber() {
         return negativeNumber;
      }
   }

   public class ExceptionProgagation {
public static void Main()
{
   try
   {
      Method1();
   } catch (Exception e)
   {
      Console.WriteLine(e.Message);
   }
}

static void Method1()
{
   Method2();
}

static void Method2()
{
   throw new Exception("Exception thrown in Method2()");
}
   }

}