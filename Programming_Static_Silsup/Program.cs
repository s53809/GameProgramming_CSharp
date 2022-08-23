using System;
using System.Collections.Generic;

namespace Programming_Static_Silsup
{
    public static class stringUtility
    {
        public static Boolean isPalindrome(this String str)
        {
            Int32 str_length = str.Length;
            Int32 isHol = str_length % 2;
            Stack<Char> st = new Stack<Char>();
            for(Int32 i = 0; i < str_length / 2; i++)
            {
                st.Push(str[i]);
            }
            for(Int32 i = str_length / 2 + isHol; i < str_length; i++)
            {
                if(st.Peek() != str[i])
                {
                    return false;
                }
                st.Pop();
            }
            return true;
        }

        public static Boolean isBracket(this String str)
        {
            Int32 str_length = str.Length;          
            Stack<Char> st = new Stack<Char>();

            bool isNot = false;

            for(Int32 i = 0; i < str_length; i++)
            {
                if(str[i] == '(')
                {
                    st.Push('(');
                }
                if (str[i] == ')')
                {
                    if(st.Count != 0)
                    {
                        st.Pop();
                    }
                    else
                    {
                        isNot = true;
                        break;
                    }
                }
            }
            if (isNot)
            {
                return false;
            }
            else if(st.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            String str = "AbcbA";
            if (str.isPalindrome())
            {
                Console.WriteLine("Yeah");
            }
            else
            {
                Console.WriteLine("Nope");
            }

            if (str.isBracket())
            {
                Console.WriteLine("YEAH");
            }
            else
            {
                Console.WriteLine("NOPE");
            }

            String gwalho = "((()))()()(()())";
            if (gwalho.isBracket())
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("NO");
            }
            if (gwalho.isPalindrome())
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("NO");
            }

            gwalho = "((()))()()()())";
            if (gwalho.isBracket())
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
