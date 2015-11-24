using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3
{
    class Adapter:IGreeter
    {
        Printer p = new Printer();
        public void SayHello()
        {
            p.Print("Gutten tag!");
        }
    }
}
