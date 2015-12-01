using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3
{
    class Proxy : INumPrint
    {
        NumPrinter p = null;
        int k;
        int[] mass;
        public Proxy(int n)
        {
            k = n+1;
            p = new NumPrinter(k);
            mass = p.GetNumbers();
        }
        public int[] GetNumbers()
        {
            int[] mas = new int [k/2];
            Console.WriteLine("Делаем все быстро!");
            int h = 0;
            for (int i = 0; i < k; i++)
            {
                if (i % 2 == 1)
                {
                    mas[h] = mass[i];
                    h++;
                }
            }
            return mas;
        }
    }
}