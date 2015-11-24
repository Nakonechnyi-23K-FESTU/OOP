using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Адаптер
            IGreeter IG = new RUGreeter();
            IG.SayHello();
            IGreeter IG2 = new Adapter();
            IG2.SayHello();
            //Прокси
            INumPrint np = new Proxy(11);
            int[] result = np.GetNumbers();
            foreach (int s in result)
                Console.WriteLine(s);
        } 
    }
}