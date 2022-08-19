using System;
using System.Collections.Generic;

namespace GameProgramming_Student_Find
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String, Int32> dic = new Dictionary<String, Int32>();

            while (true)
            {
                Console.Write("원하는 작업을 선택해주세요.(1. 명렬표에 등록, 2. 학생 찾기, 3. 조작 종료 : ");
                Int32 input = Convert.ToInt32(Console.ReadLine()); //Convert.ToInt32(String)는 괄호 안에 있는 String 값을 Int값으로 변환해주는 함수이다.

                if(input == 1)
                {
                    Console.Write("학생 번호와 이름을 입력해주세요: ");
                    String[] str = Console.ReadLine().Split(' '); //string.Split(String)은 string을 String을 기준으로 배열로 나누겠다는 것을 의미한다.
                    //만약 내가 2404 김민서 를 입력했다면 str[0]에는 2404가 str[1]에는 김민서가 들어온다.
                    if (dic.ContainsValue(Convert.ToInt32(str[0])))
                    {
                        Console.WriteLine("잘못된 정보입니다!");
                    }
                    else
                    {
                        //Console.Write(Convert.ToInt32(str[0]));
                        dic.Add(str[1], Convert.ToInt32(str[0]));
                    }
                }
                else if(input == 2)
                {
                    Console.Write("찾고싶은 학생의 이름을 입력하세요: ");
                    String name = Console.ReadLine();

                    if (dic.ContainsKey(name))
                    {
                        Console.WriteLine(dic[name] + " " + name);
                    }
                    else
                    {
                        Console.WriteLine("우리학교 학생이 아닙니다!");
                    }
                }
                else if(input == 3)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("올바르지 않은 명령");
                }

            }
        }
    }
}
