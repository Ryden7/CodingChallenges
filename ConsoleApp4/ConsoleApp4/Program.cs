using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Program
    {

        static void Main(string[] args)
        {
            //Console.Write(AnagramTester("abba"));
            //Console.WriteLine(isAnagram("abcd"));
            substring("cdcd");
            Console.WriteLine(isAnagram("cdcd"));
            Console.Read();
        }


        private static List<String> list = new List<string>();
        private static List<String> list2 = new List<string>();
        private static int counter = 0;



        private static int isAnagram(String a)
        {
            
            for(int i = 0; i < list.Count; i++)
            {
                for (int j = i+1; j < list.Count; j++)
                {
                    var item = list[i];
                    list2.Remove(list[i]);


                    //if (i == j)
                    //    continue;
                    //list2.RemoveAt(i);
                    //if (compare(list[i], item))
                    //{
                    //    counter++;
                    //    break;
                    //}

                    if (list2.Contains(item))
                    {
                        counter++;
                        list2.Remove(item);
                    }


                }
                //builder.Append(a[i]);

            }

            return counter;
        }

        private static void substring(string n)
        {

            for (int i = 0; i < n.Length; i++)
                for (int j = 1; j <= n.Length - i; j++)
                {
                   string sorted = String.Concat(n.Substring(i, j).OrderBy(c => c));

                    list.Add(sorted);
                    list2.Add(sorted);
                }


            list.Sort();
            list2.Sort();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        private static bool compare(String a, String b)
        {

            if (a == b)
            {
                //counter++;
                return true;
            }

            return false;
        }


    }
}
