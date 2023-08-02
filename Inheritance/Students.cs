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

        protected double collegeFee { get; set; }
        public virtual void DisplayStudentDetails()
        {
            Console.WriteLine($"Id: \t {Id}\t Name: {Name}\t Department: {Department}");
        }

        public void actualCollegeFee(double collegeFee)
        {

        }
    }

    //Child class Student
    class DayScholar : Students { 
     public int BusRoute { get; set; }
     public double busFee { get; set; }
     
        public  new void DisplayStudentDetails()
        {
            Console.WriteLine($"Id: \t {Id}\t Name: {Name}\t Department: {Department}\t BusRute:{BusRoute}");
        }

        public double actualCollegeFee(double collegeFee)
        {
            collegeFee = busFee + BusRoute;
            return collegeFee;
        }
    }

    class Hostellar : Students { 
       public double HostelFee { get; set; }
       public double RoomFees { get; set; }
       public double messFees { get; set; }

        public  new void DisplayStudentDetails()
        {
            Console.WriteLine($"Id: \t {Id}\t Name: {Name}\t Department: {Department}\t HostelFee:{HostelFee}");
        }

        public double actualCollegeFee(double collegeFee)
        {
            collegeFee = HostelFee + RoomFees+messFees;
            return collegeFee;
        }
    }
}
