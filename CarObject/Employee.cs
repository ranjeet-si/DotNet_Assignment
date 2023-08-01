using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarObject
{
    internal class Employee
    {
        int id;
        string name;
        double bPay;
        double salary;

        public int Id
        {
            get { return id; } set {  id = value; }
        }
        public string Name
        {
            get { return name; }   set { name = value; }
        }
        public double BPay
        {
            get { return bPay; } 
            set { 
               if(value < 1000)
                {
                    bPay = 1000;
                }
            }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }

        }
        public Employee() { }

        public void CalculatesSalary( double bPay, double deduction )
        {
            this.salary = bPay - deduction;
        }

        public void Display()
        {
            Console.WriteLine($"Your salary is:{salary}");
        }


    }
}
