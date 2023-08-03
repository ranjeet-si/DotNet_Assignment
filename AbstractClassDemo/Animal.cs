using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    abstract internal class Animal
    {
        public Animal(string name) {
            Name = name;
        }
        public string Name { get; set; }

        abstract public string Speak();


    }

     class Dog : Animal {

        public Dog:base("amar"){

            }

        public override string Speak()
        {

        }
    }
        
}
