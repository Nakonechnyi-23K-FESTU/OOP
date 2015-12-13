using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba5
{
    class MessageSender
    {
        BuferFactory BF = new BuferFactory();
        private int Send(byte[] buf)
        {
            return buf.Length;
        }
        public void SendMessage(string msg)
        {
            Bufer b = BF.Get(msg.Length*sizeof(char));
            Buffer.BlockCopy(msg.ToCharArray(), 0, b.b, 0, b.b.Length);
            Console.WriteLine(Send(b.b));
        }
    }
}
