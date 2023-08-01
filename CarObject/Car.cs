using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace CarObject
{
    internal class Car
    {
         string carName;
         string color;
         int speed;

        public string CarName
        {
            get { return carName; }
            set { carName = value; }
        }

        public string Color
        {
            get => color; 
            set { color = value; }
        }

        public int Speed
        {
            get { return speed; }
            set
            {
                if (value < 0)
                {
                    speed = 0;
                }
                else if (value > 1)
                {
                    speed += value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public Car()
        {

        }

        public Car(string carName, string color, int speed)
        {
            this.carName = carName;
            this.color = color;
            this.speed = speed;

        }
        public Car(string name,string color) {
            this.carName = name;
            this.color = color;
          
        }


        //public void Speed(int dx)
        //{
        //    speed += dx;
        //}
        public void Display()
        {
            WriteLine($" {carName} is {color} and running at a speed of {speed} km/hr");
        }


    }
}
