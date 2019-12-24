using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> newList = new List<string>() { "b", "b", "c", "a", "a", "a", "a", "a" };
            Console.WriteLine(words(newList, 0));
            Console.Read();
            List<KeyValuePair<int, int>> asdf = new List<KeyValuePair<int, int>>();
        }

        public static int words(List<String> list, int frequency)
        {
            int i = 0; ;
            int count;
            int counter = 1;
            Dictionary<String, int> words = new Dictionary<string, int>();

            for (int j = 0; j < list.Count; j++)
            {
                if (words.ContainsKey(list[j]))
                {
                    words.TryGetValue(list[j], out count);

                    words[list[j]] = ++count;
                }
                else 
                    words.Add(list[j], counter);
            }

            var list2 = words.Keys.ToList();

            list2.Sort();

            foreach (var item in list2)
            {
                if (i == frequency)
                {
                    words.TryGetValue(item.ToString(), out count);
                    return count;

                }
                i++;
            }

            return 0;
        }
    }
}
