using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class state
    {
        public void trichy()
        {
            Console.WriteLine("It is a peacefull city");
        }
    }
    public class country : state
    {
        public void india()
        {
            Console.WriteLine("Growing Country");
        }
    }
}
