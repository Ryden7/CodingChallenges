using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] q = new int[5] { 2, 1, 5, 3, 4, };
            //int[] q = new int[5] { 2, 5, 1, 3, 4, };
            //int[] q = new int[8] { 5, 1, 2, 3, 7, 8, 6, 4, };
            int[] q = new int[8] { 1, 2, 5, 3, 7, 8, 6, 4, };
            //int[] q = new int[8] { 1, 2, 5, 3, 4, 7, 8, 6, };

            minimumBribes(q);
            Console.Read();
        }

        static void minimumBribes(int[] q)
        {
            int[] compArr = new int[q.Length];
            List<int> list = new List<int>();
            int counter = 0;
            for (int i = 0; i < q.Length; i++)
                compArr[i] = i+1;

            for (int i = 0; i < q.Length; i++)
            {
                int numtoCompare = q[i];

                int PlaceinArray = numtoCompare - 1;
                int Whereisit = i;
                int test = Math.Abs(Whereisit - PlaceinArray);
                if (Math.Abs(test) > 3)
                {
                    Console.WriteLine("Too chaotic");
                    return;
                }

                



                if(!list.Contains(numtoCompare) && !list.Contains(Whereisit))
                {
                    list.Add(numtoCompare);
                    list.Add(q[PlaceinArray]);
                    counter++;
                    

                }




            }

            Console.WriteLine(counter);
        }
    }
}
