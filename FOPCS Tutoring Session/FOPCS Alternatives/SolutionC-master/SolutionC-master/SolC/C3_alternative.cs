using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolC
{
   class C3_alternative
   {
      public static void Main(string[] args)
      {
         Console.Write("Please enter your grade: ");
         int grade = Convert.ToInt32(Console.ReadLine());

         string alphaBetGrade = GetAlphabetGrade(grade);

         if (alphaBetGrade != "Error")
         {
            Console.WriteLine("You scored {0} marks which is {1} grade.", grade, alphaBetGrade);
         }
         else
         {
            Console.WriteLine("**Error**");
         }
      }

      static string GetAlphabetGrade(int grade)
      {
         if (grade >= 80 && grade <= 100)
         {
            return "A";
         }
         else if (grade >= 60 && grade < 80)
         {
            return "B";
         }
         else if (grade >= 40 && grade < 60)
         {
            return "C";
         }
         else if (grade >= 0 && grade < 40)
         {
            return "F";
         }
         else
         {
            return "Error";
         }
      }

   }
}
