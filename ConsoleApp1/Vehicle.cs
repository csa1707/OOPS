using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Vehicle
    {
        public void brake()
        {
            Console.WriteLine("It is in good condition");
        }
    }
    public class honda : Vehicle
    {
        public void wire() 
        {
            Console.WriteLine("need to sort");
        }
    }
}
