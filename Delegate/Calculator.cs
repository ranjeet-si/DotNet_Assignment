using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Delegate
{
    internal class Calculator
    {

        public int add(int x, int y)
        {
            return x + y;
        } 

        public int sub(int x,int y) { return x - y; }  

        public int mul(int x,int y) { return x * y; }

        public int div(int x,int y) { return x / y; }

        public double addDouble(double x,double y) {  return x + y; }
        
    }
}
