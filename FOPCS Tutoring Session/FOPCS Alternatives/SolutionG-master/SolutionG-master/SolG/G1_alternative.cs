using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolG
{
    class G1_alternative
    {
        static void Main(string[] args)
        {
            int[] sales = new int[12];
            for (int month = 0; month < 12; month++)
            {
                Console.Write("Enter sales for month {0}:", month + 1);
                sales[month] = Convert.ToInt32(Console.ReadLine());
            }

            int maxIndex = GetMaxSaleIndex(sales);
            int minIndex = GetMinSaleIndex(sales);
            int sum = CalculateSum(sales);

            Console.WriteLine("Maximum Sales: {0} at month {1}", sales[maxIndex], maxIndex + 1);
            Console.WriteLine("Minimum Sales: {0} at month {1}", sales[minIndex], minIndex + 1);
            Console.WriteLine("Average Sales: " + sum / 12.0);

            Console.ReadKey();
        }

        static int GetMaxSaleIndex(int[] sales)
        {

            int maxIndex = 0;
            for (int i = 1; i < 12; i++)
            {
                if (sales[i] > sales[maxIndex])
                {
                    maxIndex = i;
                }
            }

            return maxIndex;
        }

        static int GetMinSaleIndex(int[] sales)
        {
            int minIndex = 0;
            for (int i = 1; i < 12; i++)
            {
                if (sales[i] < sales[minIndex])
                {
                    minIndex = i;
                }
            }

            return minIndex;
        }

        static int CalculateSum(int[] sales)
        {
            int sum = 0;
            for (int i = 0; i < 12; i++)
            {
                sum = sum + sales[i]; 
            }

            return sum;
        }
    }
}
