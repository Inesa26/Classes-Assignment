using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_hierarchy
{
    public class Program
    { public static void Main(string[] args) {
            Animal bird1 = new Bird("hen", 1, false);
            bird1.MakeASound();

            Mammal mammal1 = new Mammal("cat", 5, 4);
            mammal1.MakeASound("Meow");
            mammal1.Eat(quantity:3);

            object mammal2 = new Mammal();
            var mammal3 = mammal2 as Mammal;

            if (mammal3 is not null)
            {
                mammal3.Eat();
            }
        }
    }
}
