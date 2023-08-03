using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class UserInterface
    {
        public int GetId()
        {
            Console.WriteLine("Enter Id");
            int id = Int32.Parse(Console.ReadLine());
            return id;

        }
        public string GetName()
        {
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            return name;

        }

        public string GetDepartment()
        {
            Console.WriteLine("Enter Department");
            string department = Console.ReadLine();
            return department;
        }
        public double GetSalary()
        {
            Console.WriteLine("Enter Salary");
            double salary = Double.Parse(Console.ReadLine());
            return salary;

        }


    }
}