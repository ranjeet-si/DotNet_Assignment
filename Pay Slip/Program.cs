namespace Pay_Slip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of hours worked:");
            int hr = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter hourly rate:");
            int rate = Convert.ToInt32(Console.ReadLine());

            int grossPay= hr*rate;
            int nInsur = Convert.ToInt32(grossPay - grossPay * (0.05));
            int incomeT = Convert.ToInt32(nInsur * (0.2));

            Console.WriteLine("Hr Worked:"+hr);
            Console.WriteLine(" Rate:"+rate);
            Console.WriteLine(" Gross Rate:"+ grossPay);
            Console.WriteLine(" National Insurance:"+nInsur);
            Console.WriteLine(" Income Tax:"+incomeT);


        }
    }
}