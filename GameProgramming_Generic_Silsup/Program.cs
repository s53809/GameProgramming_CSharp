using System;

namespace GameProgramming_Generic_Silsup
{
    public class stack<T>
    {
        private T[] stac;
        public Int32 length { get; private set; }

        public stack(Int32 size)
        {
            stac = new T[size];
            length = 0;
        }

        public void Push(T value)
        {
            stac[length++] = value;
        }

        public T Pop()
        {
            return stac[--length];
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            stack<Int32> st = new stack<Int32>(50);

            st.Push(10);
            st.Push(20);
            st.Push(30);

            for(Int32 i = 0, st_size = st.length; i < st_size; i++)
            {
                Console.WriteLine(st.Pop());
            }

        }
    }
}
