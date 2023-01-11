using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Kahoot.PassByValue3
{
    public class Test {
        public static void Main()
        {
            Data myData = new Data(1, 2);
            Swap(myData);
            Console.WriteLine(myData);
        }
        public static void Swap(Data myData)
        {
            int temp = myData.Data1;
            myData.Data1 = myData.Data2;
            myData.Data2 = temp;
        }
    }

    public class Data
    {
        public int Data1 { get; set; }
        public int Data2 { get; set; }

        public Data(int data1, int data2)
        {
            Data1 = data1;
            Data2 = data2;
        }

        public override string ToString()
        {
            return Data1 + ", " + Data2;
        }

    }
}
