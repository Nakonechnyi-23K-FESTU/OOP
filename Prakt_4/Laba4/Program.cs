using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    interface IReturnString
    {
        string ReturnString(string s);
    }
    class NCPrint : IReturnString
    {
        public string ReturnString(string s)
        {
            char[] letters = null;
            string n = "";
            letters = s.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                if (letters[i] == ' ')
                    letters[i] = '_';
                n += letters[i];
            }
            return n;
        }
    }
    class UCPrint : IReturnString
    {
        public string ReturnString(string s)
        {
            char[] letters = null;
            string n = "";
            letters = s.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                if (letters[i] == ' ')
                    letters[i] = '_';
                n += letters[i];
            }
            return n.ToUpper();
        }
    }
    class LCPrint : IReturnString
    {
        public string ReturnString(string s)
        {
            char[] letters = null;
            string n = "";
            letters = s.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                if (letters[i] == ' ')
                    letters[i] = '_';
                n += letters[i];
            }
            return n.ToLower();
        }
    }
    class Printer
    {
        public void Print(string s,IReturnString RS)
        {
            Console.WriteLine(RS.ReturnString(s));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string s = "The quick brown fox jumps over the lazy dog.";
            IReturnString Nc1 = new NCPrint();
            IReturnString Nc2 = new UCPrint();
            IReturnString Nc3 = new LCPrint();
            Printer p = new Printer();
            p.Print(s, new NCPrint());
            p.Print(s, Nc2);
            p.Print(s, Nc3);

            Console.WriteLine();

            Water w = new Water();
            w.Cool(); //лед
            w.Print();
            w.Heat(); //вода
            w.Print();
            w.Heat(); //пар
            w.Print();
            w.Heat(); //пар
            w.Print();
            w.Cool(); //вода
            w.Print();
            w.Cool(); //лед
            w.Print();
            w.Cool(); //лед
            w.Print();
        }


        abstract class IWaterState
        {
            protected static LiquidWater liquidwater = new LiquidWater();
            protected static GasWater gaswater = new GasWater();
            protected static SolidWater solidwater = new SolidWater();

            abstract public IWaterState Heat();
            abstract public IWaterState Cool();
            abstract public void ShowState();

            public static IWaterState Start()
            {
                return liquidwater;
            }
        }
        class LiquidWater : IWaterState
        {
            public override IWaterState Heat()
            {
                return gaswater;
            }
            public override IWaterState Cool()
            {
                return solidwater;
            }
            public override void ShowState()
            {
                Console.WriteLine("Вода");
            }
        }
        class SolidWater : IWaterState
        {
            public override IWaterState Heat()
            {
                return liquidwater;
            }
            public override IWaterState Cool()
            {
                return this;
            }
            public override void ShowState()
            {
                Console.WriteLine("Лед");
            }
        }
        class GasWater : IWaterState
        {
            public override IWaterState Heat()
            {
                return this;
            }
            public override IWaterState Cool()
            {
                return liquidwater;
            }
            public override void ShowState()
            {
                Console.WriteLine("Пар");
            }
        }
        class Water
        {
            public IWaterState currentState;

            public Water()
            {
                currentState = IWaterState.Start();
            }
            public void Heat()
            {
                currentState = currentState.Heat();
            }
            public void Cool()
            {
                currentState = currentState.Cool();
            }
            public void Print()
            {
                currentState.ShowState();
            }
        }
    }
}
