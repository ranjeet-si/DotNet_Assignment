namespace Control_Structure
{
    internal class Program
    {
       static void Main1( )
    {
        const double creditLimit = 10000.0;

        Console.Write("Enter the purchase price: ");
        double purchasePrice = Convert.ToDouble(Console.ReadLine());

        if (purchasePrice > creditLimit)
        {
            Console.WriteLine("Error: Purchase price exceeds the credit limit.");
        }
        else
        {
            Console.WriteLine("Approved");
        }
    }
    }
}