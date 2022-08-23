using System;

namespace Programming_Nullable_Silsup
{
    public class MyArray
    {
        private Int32[] _array;
        public Int32[] array { 
            get
            {
                if (_array == null) return null;
                return _array; 
            }
        }

        public MyArray(Int32[] element)
        {
            _array = element;
        }

        public void Print()
        {
            for (Int32 i = 0, array_length = array.Length; i < array_length; i++)
            {
                Console.Write(array[i].ToString() + " ");
            }
            Console.WriteLine();
        }

        public delegate Boolean Compare(Int32 x, Int32 y);


        public void Sort(Compare comp)
        {
            Int32 array_size = array.Length;
            for (Int32 i = 0; i < array_size - 1; i++)
            {
                for (Int32 j = i; j < array_size; j++)
                {
                    if (comp(array[i], array[j]))
                    {
                        Int32 temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
    }

    public class CompareClass
    {
        public static Boolean Upsort(Int32 x, Int32 y)
        {
            return x > y;
        }
        public static Boolean Downsort(Int32 x, Int32 y)
        {
            return x < y;
        }
    }

    internal class Program
    {


        static void Main(string[] args)
        {
            MyArray arr = new MyArray(new int[] { 6, 2, 3, 5, 7, 8 });
            arr.Print();
            arr.Sort(CompareClass.Upsort);
            arr.Print();
            arr.Sort(CompareClass.Downsort);
            arr.Print();
        }
    }
}