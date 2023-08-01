using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Assingment
{
    internal class SortString
    {
        static void Main()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            string sortedString = SortAlphabetically(input);

            Console.WriteLine("The string in alphabetical order: " + sortedString);
        }

        static string SortAlphabetically(string input)
        {
            char[] charArray = input.ToCharArray();

            for (int i = 0; i < charArray.Length - 1; i++)
            {
                for (int j = 0; j < charArray.Length - i - 1; j++)
                {
                    if (charArray[j] > charArray[j + 1])
                    {
                      
                        char temp = charArray[j];
                        charArray[j] = charArray[j + 1];
                        charArray[j + 1] = temp;
                    }
                }
            }

            return new string(charArray);
        }
    }
}
