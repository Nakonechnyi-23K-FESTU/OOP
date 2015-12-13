using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba5
{
    class Bufer4b:Bufer
    {
        public Bufer4b()
        {
            b = new byte[4];
            free = true;
        }
    }
}
