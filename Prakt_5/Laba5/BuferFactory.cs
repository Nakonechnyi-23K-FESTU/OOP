using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba5
{
    class BuferFactory
    {
        Dictionary<int, Bufer> Factory = new Dictionary<int, Bufer>();
        public BuferFactory()
        {
            Factory.Add(2, new Bufer2b());
            Factory.Add(4, new Bufer4b());
            Factory.Add(6, new Bufer6b());
        }
        public Bufer Get(int size)
        {
            if(Factory[size].free==false)
            {
                switch (size)
                {
                    case 2: return new Bufer2b();
                    case 4: return new Bufer4b();
                    case 6: return new Bufer6b();
                }
            }
            Factory[size].free = false;
            return Factory[size];
        }
    }
}
