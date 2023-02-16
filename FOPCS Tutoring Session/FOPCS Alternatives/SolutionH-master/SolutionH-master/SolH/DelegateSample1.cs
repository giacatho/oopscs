using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate int NumberChanged(int n);

namespace SolH
{
    class DelegateSample1
    {
        static int num = 10;

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }

        public static int getNum()
        {
            return num;
        }

        static void Main()
        {
            // Create delegate instance
            NumberChanged nc1 = new NumberChanged(AddNum);
            NumberChanged nc2 = new NumberChanged(MultNum);

            // Caling the method using the delegate objects
            nc1(25);
            Console.WriteLine("Value of Num: {0}", getNum());

            nc2(5);
            Console.WriteLine("Value of Num: {0}", getNum());

            Console.ReadKey();
        }
    }
}
