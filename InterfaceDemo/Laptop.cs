using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal class Laptop
    {
        internal interface Interface1
        {
            void add(int x, int y)
            {

            }
        }

        internal interface Interface2:Interface1
        {
            void sub (int x, int y)
            {

            }

        }

    }

    
}
