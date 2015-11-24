using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Laba3
{
    class NumPrinter: INumPrint
    {
        private int n;
        public NumPrinter(int n)
        {
            this.n = n+1;
        }
        public int[] GetNumbers()
        {
            int[] imas = new int[n];
            Console.WriteLine("Ждите, сейчас все будет.. Может быть..");
            Thread.Sleep(10000);
            for(int i = 0; i<n;i++)
                imas[i]=i;
            Console.WriteLine("Я сделяль!");
            return imas;
        }
    }
}
