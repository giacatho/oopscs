using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolH
{
    class H3
    {
        public static bool InString(string s1, string s2)
        {
            s1 = s1.ToUpper();
            s2 = s2.ToUpper();
            Console.WriteLine(s1.Length);
            if (s2.Length > s1.Length) return false;

            if (s2.Length == s1.Length) return s1 == s2; //compare with the two string, if same, return true, otherwise return false

            for (int i = 0; i < s1.Length; i++)
            {
                if (i + s2.Length > s1.Length)
                {
                    Console.WriteLine(s1[i]);
                    return false;
                }

                if (s1[i] == s2[0])
                {
                    bool isSame = true;
                    //initiate comparison
                    for (int j = 1; j < s2.Length; j++)
                    {
                        if (s1[i + j] != s2[j])
                        {
                            //not the same
                            isSame = false;
                            break;
                        }
                    }
                    if (isSame) return true;
                }
            }
            return false; //if go through s1, s2 doesn't occur in s1, return false
        }

        static void Main()
        {
            Console.WriteLine(InString("The brown fox", "O"));
            Console.WriteLine(InString("The brown fox", "FOX"));
            Console.WriteLine(InString("The brown fox", "bRO"));
            Console.WriteLine(InString("T", "bRO"));
            Console.WriteLine(InString("The bras basah complex", "bRO"));
        }
    }
}
