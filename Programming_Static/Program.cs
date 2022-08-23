using System;

namespace Programming_Static
{
    static class stringUtility
    {
        public static void sayhello(this string name)
        {
            Console.WriteLine("Hello, " + name + "!");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "seungHo";
            name.sayhello();
        }
    }
}
