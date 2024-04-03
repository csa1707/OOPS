using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Ipl
    {
        public virtual void Winners()
        {
            Console.WriteLine("Final Match");
        }
    }
    public class Csk : Ipl
    {
        public override void Winners()
        {
            Console.WriteLine("CSK is going to win");
        }
    }
    public class Rcb :Ipl
    {
        public override void Winners()
        {
            Console.WriteLine("Rcb is going to lose");
        }
    }
}
