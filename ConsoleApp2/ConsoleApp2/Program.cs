using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            String s = "these are the words in a string you are going to reverse";
            IEnumerable<char> p = s.Reverse();

            foreach (var i in p)
                Console.Write(i);

            Console.WriteLine();
            for (int i = s.Length; i > 0; i--)
            {
                Console.Write(s[i-1]);
            }
            Console.Read();

        }
    }
}
