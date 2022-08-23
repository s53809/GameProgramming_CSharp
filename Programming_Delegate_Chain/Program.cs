using System;

namespace Programming_Delegate_Chain
{
    internal class Program
    {
        delegate Int32 Operate(Int32 x, Int32 y);
        static Int32 Plus(Int32 x,Int32 y) { return x + y; }
        static Int32 Minus(Int32 x,Int32 y) { return x - y; }
        static Int32 Multiple(Int32 x,Int32 y) { return x * y; }
        static void Main(string[] args)
        {
            Int32 a = 3, b = 2;
            Operate m = null;
            m += Plus;
            m += Minus;
            m += Multiple;

            var arr = m.GetInvocationList();

            foreach(Operate now in arr)
            {
                Console.WriteLine(now(a, b));   
            }

            m(a, b);
        }
    }
}
