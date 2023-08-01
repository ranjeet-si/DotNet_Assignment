namespace Online_Shopping_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 3 Items price");

            double items1=Convert.ToDouble( Console.ReadLine());
            double items2 = Convert.ToDouble(Console.ReadLine());
            double items3 = Convert.ToDouble(Console.ReadLine());

            double totalItems= (double)(items1+items2+items3);
            double tax=(double) (totalItems*(0.5));


            Console.WriteLine("The total amount is:" + tax);


        }
    }
}