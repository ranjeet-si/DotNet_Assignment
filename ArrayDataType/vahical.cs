using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDataType
{
    internal class vahical
    {
        static void Main2(string[] args)
        {
            Console.WriteLine("Enter the number of vahical");

            int num = Convert.ToInt32(Console.ReadLine());
            int[] vahicalReg = new int[num];
            for (int i = 0; i < vahicalReg.Length; i++)
            {
                Console.WriteLine($"Enter the Reg number {i + 1}");
                vahicalReg[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Register number for the  vahical");
            for (int i = 0; i < vahicalReg.Length; i++)
            {
                Console.WriteLine(vahicalReg[i]);
            }
        }
    }
}
