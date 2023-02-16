using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolH
{
    class H11
    {
        delegate double DoubleOps(double x);

        static double[] ProcessArray(double[] arr, DoubleOps ops)
        {
            double[] ret = new double[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                ret[i] = ops(arr[i]);
            }

            return ret;
        }

        static void Main()
        {
            double[] arr = { 1.5, 2.5, 1 };
            PrintArr(arr);

            DoubleOps sqrt = Sqrt;
            double[] sqrtArr = ProcessArray(arr, sqrt);
            PrintArr(sqrtArr);

            DoubleOps square = Square;
            double[] squareArr = ProcessArray(arr, square);
            PrintArr(squareArr);

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
