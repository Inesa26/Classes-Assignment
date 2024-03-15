using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_hierarchy
{
    public abstract class Animal
    { 
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        { Name = name; 
          Age = age;
        }

        public Animal() { }

        public virtual void MakeASound() {
            Console.WriteLine("The animal makes a sound");
        }
        public virtual void Reproduce()
        {
            Console.WriteLine("The animal is reproducing.");
        }

        public virtual void Eat(string food, int quantity = 1)
        {
            Console.WriteLine($"The animal is eating {quantity} units of {food}.");
        }
    }
}
