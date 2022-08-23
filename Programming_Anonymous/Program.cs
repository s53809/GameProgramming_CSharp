using System;

namespace Programming_Anonymous
{
    class Calculator
    {
        public delegate void Operate(Int32 x, Int32 y);
        private Operate? _operate;
        public event Operate operate { add { _operate += value; } remove { _operate -= value; } }

        public void StartOperate()
        {
            
        }
    }


    internal class Program
    {
        delegate void Operate(Int32 x, Int32 y);
        static void Main(string[] args)
        {
            Int32 a = 2, b = 3;

            Calculator fourChikOpeartion = null;
            fourChikOpeartion.operate += (x, y) => { Console.WriteLine(x + y); };
            fourChikOpeartion.operate += (x, y) => { Console.WriteLine(x - y); };
            fourChikOpeartion.operate += (x, y) => { Console.WriteLine(x * y); };
            fourChikOpeartion.operate += (x, y) => { Console.WriteLine(x / y); };

            fourChikOpeartion(a, b);
        }
    }
}
