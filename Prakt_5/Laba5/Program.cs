using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba5
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageSender ms = new MessageSender();
            ms.SendMessage("Саш");
            ms.SendMessage("LOL");
            Console.ReadKey();
        }
    }
}
