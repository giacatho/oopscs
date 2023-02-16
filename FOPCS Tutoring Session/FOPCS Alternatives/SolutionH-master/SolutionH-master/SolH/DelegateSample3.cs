using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolH
{
    class DelegateSample3
    {
        delegate int IntOps(int n);

        static void ApplyOperation(int[] arr, IntOps ops)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = ops(arr[i]);
            }
        }

        static int Add10(int x)
        {
            return x + 10;
        }

        static void Main()
        {
            int[] arr = new int[] { 1, 2, 3 };
            PrintArr(arr);

            IntOps myOp = Add10;
            ApplyOperation(arr, myOp);
            PrintArr(arr);

            IntOps myOp2 = delegate (int a)
            {
                return a + 20;
            };
            ApplyOperation(arr, myOp2);
            PrintArr(arr);

            Console.ReadKey();
        }

        static void PrintArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine();
        }
    }
}
