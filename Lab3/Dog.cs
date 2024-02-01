using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Dog eats meat");
        }
    }
}
