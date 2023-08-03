using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }
        public override string ToString()
        {
            return $"Id : {Id} Name : {Name} Salary : {Salary} Department : {Department}";
        }

        public override bool Equals(object? obj)
        {
            if (obj != null)
            {
                Employee other = obj as Employee;
                if (this.Id == other.Id)
                {
                    return true;
                }
            }
            return false;
        }

    }
}