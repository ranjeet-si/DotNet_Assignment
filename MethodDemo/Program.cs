namespace MethodDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grossPay;
            double netPay = CalculateSalary(4000, 2000, out grossPay);
            Console.WriteLine($"NetPay:{netPay}, Gross Pay={grossPay}");
        }
        static double CalculateSalary(double bPay, double allowances, out double grossPay) {
            grossPay = bPay + allowances;
            double netPay = bPay - (bPay * 0.30);
            return netPay;
        }
    }
}