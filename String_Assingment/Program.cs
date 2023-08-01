namespace String_Assingment
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            Console.Write("Enter a line of text: ");
            string line = Console.ReadLine();

            Console.Write("Enter the character to count: ");
            char charToCount = Console.ReadKey().KeyChar;
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == charToCount)
                {
                    count++;
                }
            }

            Console.WriteLine($"The character '{charToCount}' occurs {count} times in the given line of text.");
        }
    }
}