using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate string NumberFormatter(double number);
    public class NumberDisplay
    {
        
        public string FormatCurrency(double number)
        {
            return string.Format("${0.000}", number);
        }

        public string FormatPercentage(double number)
        {
            return string.Format("{0.00}%", number * 100);
        }

        public void DisplayNumbers(List<double> numbers, NumberFormatter formatter)
        {
            foreach (double number in numbers)
            {
                string formattedNumber = formatter(number);
                Console.WriteLine($"Formatted: {formattedNumber}");
            }

        }
    }
}
