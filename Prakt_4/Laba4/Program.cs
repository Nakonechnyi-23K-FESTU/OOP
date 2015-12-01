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
    class NCPrint:IReturnString
    {
        public string ReturnString(string s)
        {
            char[] letters = null;
            string n = "";
            letters = s.ToCharArray();
            for(int i=0; i<s.Length;i++)
            {
                if (letters[i] == ' ')
                    letters[i] = '_';
                n += letters[i];
            }
            return n;
        }
    }
    class UCPrint:IReturnString
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


    class Program
    {
        static void Main(string[] args)
        {
            IReturnString Nc1 = new NCPrint();
            Console.WriteLine(Nc1.ReturnString("The quick brown fox jumps over the lazy dog."));
            IReturnString Nc2 = new UCPrint();
            Console.WriteLine(Nc2.ReturnString("The quick brown fox jumps over the lazy dog."));
            IReturnString Nc3 = new LCPrint();
            Console.WriteLine(Nc3.ReturnString("The quick brown fox jumps over the lazy dog."));

            Console.WriteLine();

            Water w = new Water();
            w.Cool(); //лед
            w.Heat(); //вода
            w.Heat(); //пар
            w.Heat(); //пар
            w.Cool(); //вода
            w.Cool(); //лед
            w.Cool(); //лед
        }
    }


    interface IWaterState
    {
        void Heat();
        void Cool();
    }
    class LiquidWater:IWaterState
    {
        readonly Water water;
        public LiquidWater(Water w)
        {
            water = w;
        }
        public void Heat()
        {
            Console.WriteLine("Вода>Пар");
            water.currentState = water.gaswater; 
        }
        public void Cool()
        {
            Console.WriteLine("Вода>Лед");
            water.currentState = water.solidwater;
        }
    }
    class SolidWater : IWaterState
    {
        readonly Water water;
        public SolidWater(Water w)
        {
            water = w;
        }
        public void Heat()
        {
            Console.WriteLine("Лед>Вода");
            water.currentState = water.liquidwater;
        }
        public void Cool()
        {
            Console.WriteLine("Некуда охлаждать лед.");
        }
    }
    class GasWater : IWaterState
    {
        readonly Water water;
        public GasWater(Water w)
        {
            water = w;
        }
        public void Heat()
        {
            Console.WriteLine("Некуда нагревать пар!");
        }
        public void Cool()
        {
            Console.WriteLine("Пар>Вода");
            water.currentState = water.liquidwater;
        }
    }
    class Water
    {
        public IWaterState currentState;

        public SolidWater solidwater { get; private set; }
        public LiquidWater liquidwater { get; private set; }
        public GasWater gaswater { get; private set; }

        public Water()
        {
            solidwater = new SolidWater(this);
            liquidwater = new LiquidWater(this);
            gaswater = new GasWater(this);
            currentState = liquidwater;
            Console.WriteLine("Вода");
        }
        public void Heat()
        {
            currentState.Heat();
        }
        public void Cool()
        {
            currentState.Cool();
        }
    }
}
