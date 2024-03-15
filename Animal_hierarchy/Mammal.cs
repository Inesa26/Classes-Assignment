using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_hierarchy
{
    public class Mammal: Animal
    {
        public int NumLegs { get; set; }
        public Mammal(string name, int age, int numLegs) : base(name, age)
        {
            NumLegs = numLegs;
        }

        public Mammal() { }

        public override void MakeASound()
        {
            Console.WriteLine("The mammal is vocalizing.");
        }

        public void MakeASound(string sound)
        {
            Console.WriteLine($"The mammal is making a {sound} sound.");
        }
        public override void Reproduce()
        {
            Console.WriteLine("The mammal is giving birth");
        }

        public override void Eat(string food = "meat", int quantity = 1)
        {
            base.Eat(food, quantity);
        }
    }
}
