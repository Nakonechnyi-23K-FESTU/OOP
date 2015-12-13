using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba5
{
    class Bufer2b:Bufer
    {
        public Bufer2b()
        {
            b = new byte[2];
            free = true;
        }
    }
}
