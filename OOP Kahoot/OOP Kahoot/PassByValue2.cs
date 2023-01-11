using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Kahoot.PassByValue2
{
    class Test
    {
        public static void Main()
        {
            int[] arr = { 1, 2 };
            Swap(arr);

            Console.WriteLine("{0}, {1}", arr[0], arr[1]);
        }

        public static void Swap(int[] arr)
        {
            int tmp = arr[0];
            arr[0] = arr[1];
            arr[1] = tmp;

            Console.WriteLine("{0}, {1}", arr[0], arr[1]);
        }
    }
}
