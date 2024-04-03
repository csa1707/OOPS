using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface ILaptop
    {
        void laptopOS();

        
    }

    public class HP : ILaptop
    {
        public void laptopOS()
        {
            Console.WriteLine("windows 11 HP laptop");
        }
    }
}
