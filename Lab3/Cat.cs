using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Cat : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Cat eats mice");
        }
    }
}
