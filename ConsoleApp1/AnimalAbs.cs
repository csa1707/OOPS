using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class AnimalAbs
    {
        public abstract void animalSound();
    }

    class DogAbs : AnimalAbs
    {
        public override void animalSound()
        {
            Console.WriteLine("dog barking");
        }

    }

    class CatAbs : AnimalAbs
    {
        public override void animalSound()
        {
            Console.WriteLine("cat meow");
        }

    }
}
