using System;
using System.Collections.Generic;
using System.Text;

namespace HackeRankPractice.Arrays
{
    class DecryptPassword
    {
        public static void Run()
        {
            //string s = "hAck3rr4nk";

            string s = "43Ah*ck0rr0nk";

            List<char> pwd = new List<char>();
            Stack<char> stk = new Stack<char>();
            int i = 0;
            for (i = 0; i < s.Length; i++)
            {
                if (char.IsNumber(s[i]))
                    stk.Push(s[i]);
                else
                    break;
            }

            for (; i < s.Length; i++)
            {
                if (i < s.Length - 2 && Char.IsUpper(s[i]) && char.IsLower(s[i + 1]) && s[i + 2] == '*')
                {
                    pwd.Add(s[i + 1]);
                    pwd.Add(s[i]);

                    i = i + 2;
                }
                else if (s[i] == '0')
                {
                    pwd.Add(stk.Pop());
                }
                else
                {
                    pwd.Add(s[i]);
                }

            }

            while (stk.Count != 0)
            {
                pwd.Add(stk.Pop());
            }

            string str = new string(pwd.ToArray());
            Console.WriteLine(str);
            Console.Read();
        }
    }
}
