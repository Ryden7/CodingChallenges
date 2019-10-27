using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(IsValid("()"));
            Console.Read();
        }

        public static bool IsValid(string s)
        {

            Stack st = new Stack();

            for (int i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case '(':
                        st.Push('(');
                        break;
                    case '{':
                        st.Push('{');
                        break;
                    case '[':
                        st.Push('[');
                        break;
                    case ')':
                        if ((char)st.Peek() == '(')
                            st.Pop();
                        else
                            return false;
                        break;
                    case '}':
                        if ((char)st.Peek() == '{')
                            st.Pop();
                        else
                            return false;
                        break;
                    case ']':
                        if ((char)st.Peek() == '[')
                            st.Pop();
                        else
                            return false;
                        break;


                }
            }

            return true;
        }

    }
}
