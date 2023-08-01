namespace Array_Assingment
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Enter the Length of the Array");
            int num= Convert.ToInt32(Console.ReadLine());
            int[ ] arr = new int[num];
            Console.WriteLine("Enter the Number");
            for (int i = 0; i < num; i++)
            {
                arr[i]= Convert.ToInt32(Console.ReadLine());
  
            }

            Console.WriteLine("Array in reserse ordered");
            for (int i = num-1; i >=0; i--)
            {
                Console.WriteLine(arr[i]);

            }

        }
    }
}