using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Assingment
{
    internal class Order
    {
        double items = 19.95;
        int orderNumber;
        string customerName;
        int quantityOrdered;
        double totalPrice;
        public double Items { get { return items; } set { items = value; } }
        public int OrderNumber { get {  return orderNumber; } set {  orderNumber = value; } }
        public string CustomerName { get {  return customerName; } set {  customerName = value; } } 
        public int QuantityOrdered { get {  return quantityOrdered; }  }   
        public double TotalPrice { get {  return totalPrice; } set {  totalPrice = value; } }   

        public Order(double items,int orderNumber,string customerName, int quantityOrdered) { 
            this.items = items;
            this.orderNumber = orderNumber;
            this.customerName = customerName;
            this.quantityOrdered = quantityOrdered;
             
        
        }

        public int totalPrices(int items, int quantityOrdered)
        {
            return items * quantityOrdered;
        }


        public override string ToString() { 
     
            return $"";
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                if(obj == null)
                {
                    Order other = obj as Order;
                    if(other == null)
                }
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
