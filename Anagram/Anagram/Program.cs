using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(IsAnagram("anagram", "nagaram"));
            Console.Read();
        }


        public static bool IsAnagram(string s, string t)
        {

            Dictionary<char, int> letterTracker = new Dictionary<char, int>();
            Dictionary<char, int> duplicateDict = letterTracker;



            for (int i = 0; i < s.Length; i++)
                if (letterTracker.ContainsKey(s[i]))
                    continue;
                else
                    letterTracker.Add(s[i], 1);


            foreach (var item in letterTracker.Keys)
            {
                if (t.Contains(item))
                    if (duplicateDict.ContainsKey(item))
                        continue;
                    else
                        duplicateDict.Add(item, 1);
            }


            //foreach (var item in duplicateDict.Keys)
            //    //if (letterTracker[item] != 1)
            //        return false;

            if (letterTracker.Equals(duplicateDict))
                return true;

            return false;
        }

    }
}
