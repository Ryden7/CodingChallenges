using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AnagramTester("anagram", "marganaa"));
            Console.Read();
        }

        public static bool AnagramTester(String s, string t)
        {

            Dictionary<char, int> letterHolder = new Dictionary<char, int>();

            Dictionary<char, int> testAgainst = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (letterHolder.ContainsKey(s[i]))
                    letterHolder[s[i]]++;
                else
                    letterHolder.Add(s[i], 1);
            }

            for (int j = 0; j < t.Length; j++)
            {
                if (testAgainst.ContainsKey(t[j]))
                    testAgainst[t[j]]++;
                else
                    testAgainst.Add(t[j], 1);
            }

            int counter = 0;

            foreach(var item in testAgainst.Keys)
            {
                if (letterHolder.ContainsKey(item))
                {
                    letterHolder.TryGetValue(item, out int value);
                    testAgainst.TryGetValue(item, out int value2);

                    if (value == value2)
                        counter++;

                }

            }

            if (counter == letterHolder.Count)
                return true;

            return false;
        }
    }
}
