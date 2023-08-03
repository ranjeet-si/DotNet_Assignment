using System.Collections.Generic;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList list = new ArrayList();


            //list.Add("Ranjeet");
            //list.Add("Sagar");
            //list.Add("Amarjit");
            //list.Add("47.99");
            //list.Add(new Employee());
            //list.Add(new int[4]);

            //list

            /* List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4); */

            //List<double> list = new List<double>();

            //list.Add(54.33);
            //list.Add(5.76);
            //list.Add(42.98);
            //list.Add(23.98);

            List<int> list = new List<int>() { 3, 5, 89, 9, };

            Console.WriteLine("Count:"+list.Count);
            Console.WriteLine("Capacity:"+list.Capacity);

            foreach (double s in list)
            {

                Console.WriteLine(s);

            }

            Console.WriteLine("Remove element:"+ list.Remove(89));
            Console.WriteLine("9 is there:" + list.Contains(9));

            foreach (double s in list) {
            
             Console.WriteLine(s);
             
            }
            Console.ReadKey();


        }


    }

    public class Employee
    {

    }
}