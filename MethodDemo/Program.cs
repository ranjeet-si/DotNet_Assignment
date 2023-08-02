using System;

namespace MethodDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double grossPay;
            //double netPay = CalculateSalary(4000, 2000, out grossPay);
            //Console.WriteLine($"NetPay:{netPay}, Gross Pay={grossPay}");
           
           
            

            MarksSum(56.34,23.45,65.45,98.45);
        }

        public static void Display( string name, double sum,int age=10)
        {
            Console.WriteLine($" Name of the Student{name}  and All subject sum {sum}");

        }

        public static void MarksSum(  params double[] studentMarks ) {
            double sum = 0;

            for (int i = 0; i < studentMarks.Length; i++)
            {
                sum += studentMarks[i];
            }

            Display("Ranjeet",sum );

        }

        static double CalculateSalary(double bPay, double allowances, out double grossPay) {
            grossPay = bPay + allowances;
            double netPay = bPay - (bPay * 0.30);
            return netPay;
        }
    }
}