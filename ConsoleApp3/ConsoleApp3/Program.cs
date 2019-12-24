using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Substring("hello", "world"));
            Console.Read();
        }

        public static string Substring(string s1, string s2)
        {
            if (s1.Length > s2.Length) 
                for(int i = 0; i < s1.Length; i++)
                {
                    char check = s1[i];

                    if (s2.Contains(check))
                        return ("YES");
                }
            else
            {
                for (int i = 0; i < s2.Length; i++)
                {
                    char check = s2[i];

                    if (s1.Contains(check))
                        return ("YES");
                }
            }

            return ("NO");
        }
    }
}
