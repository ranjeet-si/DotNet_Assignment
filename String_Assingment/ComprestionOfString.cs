using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Assingment
{
    internal class ComprestionOfString
    {

        static void Main()
        {
            Console.Write("Enter the first string: ");
            string firstString = Console.ReadLine();

            Console.Write("Enter the second string: ");
            string secondString = Console.ReadLine();

            Console.Write("Enter the starting index of the substring: ");
            int startIndex = int.Parse(Console.ReadLine());

            Console.Write("Enter the length of the substring: ");
            int length = int.Parse(Console.ReadLine());

            string firstSubstring = firstString.Substring(startIndex, length);
            string secondSubstring = secondString.Substring(startIndex, length);

            bool areEqualIgnoreCase = CompareIgnoringCase(firstSubstring, secondSubstring);

      
            bool areEqualWithCase = CompareWithCase(firstSubstring, secondSubstring);

            Console.WriteLine($"Substring comparison (ignoring case): {areEqualIgnoreCase}");
            Console.WriteLine($"Substring comparison (with case sensitivity): {areEqualWithCase}");
        }

        static bool CompareIgnoringCase(string str1, string str2)
        {
            return string.Equals(str1, str2, StringComparison.OrdinalIgnoreCase);
        }

        static bool CompareWithCase(string str1, string str2)
        {
            return string.Equals(str1, str2, StringComparison.Ordinal);
        }
    }
}
