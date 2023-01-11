using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Kahoot.PassByValue1
{
    class Test
    {
        public static void Main()
        {
            int[] arr = { 1, 2 };
            Swap(arr[0], arr[1]);

            Console.WriteLine("{0}, {1}", arr[0], arr[1]);
        }

        public static void Swap(int n1, int n2)
        {
            int tmp = n1;
            n1 = n2;
            n2 = tmp;

            Console.WriteLine("{0}, {1}", n1, n2);
        }
    }
}
