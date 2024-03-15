using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_hierarchy
{
    internal class Bird: Animal
    {   
        public bool CanFly { get; set; }
        public Bird(string name, int age, bool canFly): base(name, age) {
            CanFly = canFly;
        }

        public override void MakeASound()
        {
            Console.WriteLine("The bird is chirping.");
        }

        public override void Reproduce()
        {
            Console.WriteLine("The bird is laying eggs");
        }
    }
}
