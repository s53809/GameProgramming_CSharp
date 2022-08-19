using System;
using System.Collections.Generic;

namespace GameProgramming_Generic_Collection_Dictionary_Silsup
{
    public class PokemonDogam
    {
        private Dictionary<Int32, String> dic;

        public PokemonDogam()
        {
            dic = new Dictionary<Int32, String>();
            
        }

        private void InsertPokemon(Int32 id, String name)
        {
            if (dic.ContainsKey(id))
            {
                Console.WriteLine("잘못된 정보입니다.");
            }
            else
            {
                dic.Add(id, name);
            }
        }

        private void FindPokemon(Int32 id)
        {
            if (dic.ContainsKey(id))
            {
                Console.WriteLine(dic[id]);
            }
            else
            {
                Console.WriteLine("도감에 등록되지 않은 포켓몬입니다!");
            }
        }

        public void Input_1()
        {
            Console.Write("아이디와 이름을 입력해주세요: ");
            String[] input = Console.ReadLine().Split(' ');

            InsertPokemon(Convert.ToInt32(input[0]), input[1]);
        }

        public void Input_2()
        {
            Console.Write("아이디를 입력해주세요: ");
            String ID = Console.ReadLine();

            FindPokemon(Convert.ToInt32(ID));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            PokemonDogam dogam = new PokemonDogam();

            while (true)
            {
                Int32 input;
                String Input;

                Console.Write("포켓몬도감 접속을 환영합니다. 원하시는 작업을 입력해주세요: ");

                Input = Console.ReadLine();
                input = Convert.ToInt32(Input);

                if (input == 1)
                {
                    dogam.Input_1();
                }
                else if (input == 2)
                {
                    dogam.Input_2();
                }
                else
                {
                    Console.WriteLine("종료합니다.");
                    break;
                }
            }
        }
    }
}
