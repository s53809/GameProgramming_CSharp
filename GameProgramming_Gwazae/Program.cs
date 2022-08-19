using System;

namespace GameProgramming_Gwazae
{
    public class Human
    {
        public Int32 age { get; protected set; }
        public String name { get; protected set; }

        public void Talk(String message)
        {
            Console.WriteLine(name + "(" + age + "): " + message);
        }

        protected void Game()
        {
            Console.WriteLine("민서가 게임을 한다");
        }
    }

    public class Minseo : Human
    {
        public Int32 intelligence { get; protected set; }

        public Minseo(Int32 _age, String _name, Int32 _intelligence)
        {
            age = _age;
            name = _name;
            intelligence = _intelligence;
        }

        public void playKaisa()
        {
            Game();
            Console.WriteLine("카이사를 픽했다!");
        }
    }

    public class Minsung : Human
    {
        public Int32 Sily { get; protected set; }

        public Minsung(Int32 _age, String _name, Int32 _Sily)
        {
            age = _age;
            name = _name;
            Sily = _Sily;
        }

        public void playSamira()
        {
            Game();
            Console.WriteLine("사미라를 픽했다!");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Minseo minseo = new Minseo(18, "민서", 100);
            Minsung minsung = new Minsung(18, "민성", 100);

            minseo.Talk("안녕");
            minsung.Talk("헤헤");

            minseo.playKaisa();
            minsung.playSamira();
        }
    }
}
