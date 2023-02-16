using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolG
{
    class G3_alternative
    {
        static void Main(string[] args)
        {
            int[,] marks = new int[,]
            {
                {56,84,68,29},
                {94,73,31,96},
                {41,63,36,90},
                {99,9,18,17},
                {62,3,65,75},
                {40,96,53,23},
                {81,15,27,30},
                {21,70,100,22},
                {88,50,13,12},
                {48,54,52,78},
                {64,71,67,25},
                {16,93,46,72}
            };

            // Testing
            // Console.WriteLine("Mark 0,1 is {0}", marks[0,1]);
            // Console.WriteLine("Length 0 {0}, length 1 {1}", marks.GetLength(0), marks.GetLength(1));

            int[] totalMarksForEachStudents = ComputeTotalMarksForEachStudent(marks);
            PrintStudentMarks(totalMarksForEachStudents);

            double[] averagePerSubject = ComputeAveragePerSubject(marks);
            PrintAveragePerSubject(averagePerSubject);

            double overallAverage = ComputeOverallAverage(marks);
            Console.WriteLine("Overall average: {0}", overallAverage);

            Console.ReadKey();

        }

        static int[] ComputeTotalMarksForEachStudent(int[,] marks)
        {
            int[] totalMarks = new int[marks.GetLength(0)];

            // Loop all the students
            for (int i = 0; i < marks.GetLength(0); i++)
            {
                // We are dealing with student i

                int totalMarkOfCurrentStudent = 0;
                // Loop all the subjects of student i
                for (int j = 0; j < marks.GetLength(1); j++)
                {
                    // Get the mark of student i in subject j
                    int mark = marks[i, j]; // IMPORTANT!!!!
                    totalMarkOfCurrentStudent = totalMarkOfCurrentStudent + mark;
                }

                // Save the current total mark for student i
                totalMarks[i] = totalMarkOfCurrentStudent;
            }

            return totalMarks;
        }

        static void PrintStudentMarks(int[] totalMarksForEachStudents)
        {
            for (int i = 0; i < totalMarksForEachStudents.Length; i++)
            {
                Console.WriteLine("Total marks for student {0}: {1}", i, totalMarksForEachStudents[i]);
            }
        }

        static double[] ComputeAveragePerSubject(int[,] marks)
        {
            double[] averagePerSubject = new double[marks.GetLength(1)];

            // Loop all the subjects
            for (int i = 0; i < marks.GetLength(1); i++)
            {
                // We are dealing with subject i

                int totalMarkOfCurrentSubject = 0;

                // Loop all the student marks for the subject i
                for (int j = 0; j < marks.GetLength(0); j++)
                {
                    // Get the mark of student j for subject i
                    int mark = marks[j, i]; // IMPORTANT!!!
                    totalMarkOfCurrentSubject = totalMarkOfCurrentSubject + mark;
                }

                // Compuate and save the current average mark for subject i
                int numOfStudents = marks.GetLength(0);
                averagePerSubject[i] = (double)totalMarkOfCurrentSubject / (double)numOfStudents;
            }

            return averagePerSubject;
        }

        static void PrintAveragePerSubject(double[] averagePerSubject)
        {
            for (int i = 0; i < averagePerSubject.Length; i++)
            {
                Console.WriteLine("Avg marks for subject {0}: {1}", i, averagePerSubject[i]);
            }
        }

        static double ComputeOverallAverage(int[,] marks)
        {
            int totalMark;

            totalMark = 0;
            // Loop all the students
            for (int i = 0; i < marks.GetLength(0); i++)
            {
                // We are dealing with student i

                // Loop all the subjects of student i
                for (int j = 0; j < marks.GetLength(1); j++)
                {
                    // Get the mark of student i in subject j
                    int mark = marks[i, j];
                    totalMark = totalMark + mark;
                }
            }

            // In here, we get total mark for ALL students in ALL subjects
            int numOfMarks = marks.Length;

            return (double)totalMark / (double)numOfMarks;
        }
    }
}
