using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolH
{
    class H11_no_delegate
    {
        static double[] SqrtAllArray(double[] arr)
        {
            double[] ret = new double[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                ret[i] = Sqrt(arr[i]); // KEY: only difference here
            }

            return ret;
        }

        /**
         * KEY: Here, I need to rewrite the whole method but only 1 difference
         * in the operator.
         */ 
        static double[] SquareAllArray(double[] arr)
        {
            double[] ret = new double[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                ret[i] = Square(arr[i]); // KEY: only difference here
            }

            return ret;
        }

        static void Main()
        {
            double[] arr = { 1.5, 2.5, 1 };
            PrintArr(arr);

            double[] sqrtArr = SqrtAllArray(arr);
            PrintArr(sqrtArr);

            double[] squareArr = SquareAllArray(arr);
            PrintArr(squareArr);

            // What to do if I need to return the cube of all the array 

            Console.ReadKey();
        }

        static double Sqrt(double x)
        {
            return Math.Sqrt(x);
        }

        static double Square(double x)
        {
            return x * x;
        }

        static void PrintArr(double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine();
        }
    }
}
