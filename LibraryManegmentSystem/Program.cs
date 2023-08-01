namespace LibraryManegmentSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            libray l1 = new libray();

            l1.AddBookInLibray();


            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{l1}");
            }

         

          


            
    }
    }
}