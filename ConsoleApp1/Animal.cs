using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Animal
    {
        public void eat()
        {
            Console.WriteLine("this is eating");
        }

        public virtual void animalSound()
        {
            Console.WriteLine("this is common sound ");
        }
    }

    public class Dog : Animal
    {
        public void bark()
        {
            Console.WriteLine("barking...");
        }
        public override void animalSound() 
        {
            Console.WriteLine("barking...");
        }
    }

    public class Cat : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("meow.....");
        }

    }
}
