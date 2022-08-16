using System;
using System.Collections.Generic;

namespace GameProgramming_Generic_Collection_Silsup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<Int32> st = new Stack<Int32>();
            Queue<Int32> qu = new Queue<Int32>();

            for(Int32 i = 1; i <= 5; i++)
            {
                st.Push(i);
                qu.Enqueue(i);
            }

            for(Int32 i = 0,st_size = st.Count; i < st_size; i++)
            {
                Console.WriteLine(st.Pop().ToString() + " " + qu.Dequeue().ToString());
            }
        }
    }
}
