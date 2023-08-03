using System.Collections;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();


            list.Add("Ranjeet");
            list.Add("Sagar");
            list.Add("Amarjit");
            list.Add("47.99");
            list.Add(new Employee());
            list.Add(new int[4]);

            foreach (Object s in list) {
            
             Console.WriteLine(s);
             
            }
            Console.ReadKey();
        }


    }

    public class Employee
    {

    }
}