using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Assingment
{
    internal class CopyArrayElement
    {
        static void Main3(string[] args)
        {
            Console.WriteLine("Enter the Length of the Array1");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[num];
            Console.WriteLine("Enter the Number in array 1");
            for (int i = 0; i < num; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }

            int[] arr2 = new int[arr.Length];

            for (int i = 0; i < num; i++)
            {
                arr2[i] = arr[i];

            }

        }
    }
}
