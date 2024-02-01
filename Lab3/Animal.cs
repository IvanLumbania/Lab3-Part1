using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public string color{ get; set; }
        public int age {  get; set; }
        public Animal()
        {
        }
        public abstract void Eat();


    }
}
