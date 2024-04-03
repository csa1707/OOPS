using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class IplAbs
    {
        public abstract void Ipls();
    }
    class CskAbs : IplAbs
    {
         public override void Ipls()
         {
             Console.WriteLine("CSK is going to win");
         }
    }
    class RcbAbs : IplAbs
    {
        public override void Ipls()
        {
            Console.WriteLine("Rcb is going to lose");
        }
    }
}
