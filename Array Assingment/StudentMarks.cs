using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Assingment
{
    internal class StudentMarks
    {
        static void Main()
        {
            int numStudents = 10;
            int[] marks = new int[numStudents];

           
            for (int i = 0; i < numStudents; i++)
            {
                Console.Write($"Enter the marks of student {i + 1}: ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }

            int sum = 0;
            foreach (int mark in marks)
            {
                sum += mark;
            }
            double averageMarks = (double)sum / numStudents;


            int highestMark = marks[0];
            for (int i = 1; i < numStudents; i++)
            {
                if (marks[i] > highestMark)
                {
                    highestMark = marks[i];
                }
            }

            Console.WriteLine($"Average marks of all students: {averageMarks:F2}");
            Console.WriteLine($"Highest mark obtained: {highestMark}");
        }
    }
}
