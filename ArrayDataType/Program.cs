namespace ArrayDataType
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Enter the total number of student");

            int num = Convert.ToInt32(Console.ReadLine());
            int[] markList = new int[num];
            for(int i = 0; i < markList.Length; i++)
            {
                Console.WriteLine($"Enter marks for stuent {i + 1}");
                markList[i]= Convert.ToInt32(Console.ReadLine()); 
            }
            for(int i=0; i< markList.Length; i++)
            {
                Console.WriteLine(markList[i]);           }
        }
    }
}