using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDataType
{
    internal class studentGrade
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of Student Name");

            int num = Convert.ToInt32(Console.ReadLine());
            int[] markList = new int[num];
            string[] studentName = new string[num];
            char[] gradeList = new char[num];
            string[] College = new string[num]
            for (int i = 0; i < markList.Length; i++)
            {
                Console.WriteLine($"Enter marks for stuent {i + 1}");
                markList[i] = Convert.ToInt32(Console.ReadLine());

                if(markList[i] > 90 )
                {
                    gradeList[i] = 'A' ;


                }
                else if (markList[i] > 80)
                {
                    gradeList[i] = 'B';
                }
                else if (markList[i] > 70)
                {
                    gradeList[i] = 'C';
                }
                else if (markList[i] > 60)
                {
                    gradeList[i] = 'D';
                }
                else if (markList[i] > 50)
                {
                    gradeList[i] = 'E';
                }
                else if (markList[i] > 40)
                {
                    gradeList[i] = 'F';
                }
                

                Console.WriteLine($"Enter names for stuent {i + 1}");
                studentName[i] = Convert.ToString(Console.ReadLine());

            }

            for (int i = 0; i < markList.Length; i++)
            {
                Console.WriteLine(studentName[i] +":"+ gradeList[i]);
            }
        }
    }
    }

