using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IAnimal
    {
        void Dogs();
    }

    public class Pigs : IAnimal
    {
        public void Dogs()
        {
            Console.WriteLine("Dog is Barking");
        }
    }

}
