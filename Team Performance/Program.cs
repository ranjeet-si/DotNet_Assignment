namespace Team_Performance
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Enter the no of win games, no of loss games, on of drawn games");

            int won= Convert.ToInt32(Console.ReadLine());
            
            int drawn = Convert.ToInt32(Console.ReadLine());
            int loss = Convert.ToInt32(Console.ReadLine());

            int totalPont = 3 * (won) + 1 * (drawn);

            Console.WriteLine("Teams Total point:" + totalPont);
        }
    }
}