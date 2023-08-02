using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Students
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public void DisplayStudentDetails()
        {
            Console.WriteLine($"Id: \t {Id}\t Name: {Name}\t Department: {Department}");
        }
    }

    //Child class Student
    class DayScholar : Students { 
     public int BusRoute { get; set; }

        public void DisplayStudentDetails()
        {
            Console.WriteLine($"Id: \t {Id}\t Name: {Name}\t Department: {Department}\t BusRute:{BusRoute}");
        }
    }

    class Hostellar : Students { 
       public double HostelFee { get; set; }


        public void DisplayStudentDetails()
        {
            Console.WriteLine($"Id: \t {Id}\t Name: {Name}\t Department: {Department}\t HostelFee:{HostelFee}");
        }
    }
}
