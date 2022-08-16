using System;

namespace GameProgramming_Silsup
{
    public class Animal
    {
        public Int32 age { get; protected set; }
        public String name { get; protected set; }
    }

    public class Dog : Animal
    {
        public Dog(Int32 _age, String _name)
        {
            age = _age;
            name = _name;
        }
        public void Bark()
        {
            Console.WriteLine(name + "(" + age + ")" + ": 멍멍"); 
        }
    }

    public class Cat : Animal
    {
        public Cat(Int32 _age, String _name)
        {
            age = _age;
            name = _name;
        }
        public void Meow()
        {
            Console.WriteLine(name + "(" + age + ")" + ": 야옹");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog(10, "강아지");
            Cat cat = new Cat(20, "김밥이");

            Console.WriteLine(dog.name + " " + cat.name);
            dog.Bark();
            cat.Meow();
        }
    }
}
