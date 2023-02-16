using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolG
{
    class G2_alternative
    {
        public static void Main()
        {
            int[] arr = new int[] { 86, 35, 41, 49, 89, 51, 11, 71, 50, 75, 25, 58, 40, 14, 44, 3, 63, 81, 93, 79 };

            Console.WriteLine("Before sorting");
            PrintArray(arr);

            Sorting(arr);

            Console.WriteLine("After sorting");
            PrintArray(arr);

            Console.ReadKey();
        }

        public static void PrintArray(int [] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        public static void Sorting(int[] arr)
        {
            // Loop through the array
            for (int i = 0; i < arr.Length - 1; i++)
            {
                // i is target position to swap

                // Loop through the OTHER elements
                for (int j = i + 1; j < arr.Length; j++)
                {
                    // If value in index j is less than in i, swap them
                    if (arr[j] < arr[i])
                    {
                        // Remeber these 3 lines, which are used for swapping arr[i] and arr[i]
                        var temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }

                    PrintArray(arr);
                }
            }
        }
    }
}
