using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalsTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 5;
            Console.WriteLine(Pascal(rows));
            Console.Read();
        }

        public static int Pascal(int n)
        {
            int first = 1;
            List<int[]> holder = new List<int[]>();
            int[] arr = new int[1] { 1 };
            int[] arr2 = new int[2] { 1, 1 };



            holder.Add(arr);
            holder.Add(arr2);

            if (n > 2)
                for(int i = 2; i < n; i++)
                {
                    int[] ArrayGoingIn = new int[holder.Count + 1];

                    for (int j = 0; j < n; j++)
                    {

                        if (j+1 < holder.Count)
                        {
                            ArrayGoingIn[0] = 1;
                            ArrayGoingIn[ArrayGoingIn.Length - 1] = 1;
                            int nextNum = holder.Last()[j] + holder.Last()[j+1];

                            ArrayGoingIn[j+1] = nextNum;
                        
                        }

                    }

                    holder.Add(ArrayGoingIn);


                }

            foreach (var item in holder)
            {
                Console.WriteLine(item);
            }

            return 0;
        }
    }
}
