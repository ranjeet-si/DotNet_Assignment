using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Employee
    {
        public string eName { get; set; }
        public int id { get; set; }

        public Employee(string eName, int id)
        {
            this.eName = eName;
            this.id = id;
        }

        public override string ToString()
        {
            return $"Id: { id} Nmae:{ eName}";
        }

        public override bool Equals(object? obj)
        {
            if (obj==null)
            {
                Employee other = obj as Employee;
                if(this.id == other.id && other.eName == this.eName)
                {
                    return true ;
                }
            }
            return false ;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id,eName);
        }

    }
}
