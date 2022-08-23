using System;

namespace Programming_Interface
{
    interface ICryable
    {
        public void Cry();
    }

    class Dog : ICryable
    {
        public void Cry()
        {
            Console.WriteLine("멍멍");
        }
    }

    class Cat : ICryable
    {
        public void Cry()
        {
            Console.WriteLine("야옹");
        }
    }

    class Minsung : ICryable
    {
        public void Cry()
        {
            Console.WriteLine("으앙");
        }
    }
    internal class Program
    {
        static void CryFunction(ICryable[] arr)
        {
            for(Int32 i = 0,arr_size = arr.Length; i < arr_size; i++)
            {
                arr[i].Cry();
            }
        }

        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();
            Minsung min = new Minsung();

            ICryable[] arr = new ICryable[] { dog, cat, min };
            CryFunction(arr);
        }
    }
}
