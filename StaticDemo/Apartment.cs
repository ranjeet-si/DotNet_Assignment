using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    internal class Apartment
    {
        public int apartmentNo { get; set; }
        public string ownerName { get; set; }
        public static int noOfHousesBought { get; set; }

        public static string address { get; set; }


        public Apartment(int apartmentNo, string ownerName)
        {
            apartmentNo = apartmentNo;
            ownerName = ownerName;
            ++noOfHousesBought;
        }

        public void Dipaly()
        {
            Console.WriteLine($"Apartment No:{apartmentNo} , Owner Name: {ownerName}");
        }

        public static void DisplayApartmentAddress()
        {
            Console.WriteLine($"Apartment Address :{address}");
        }

        public static void DisplayTotalNumberOfHouseBought()
        {
            Console.WriteLine($"House Bought: {noOfHousesBought}");
        }
    }
}
