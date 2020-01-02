using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallengeFib
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(fib(19));
            Console.Read();
        }

        public static int fib(int n)
        {
            if (n == 0)
                return 0;

            if (n == 1)
                return 1;

            List<int> fibSeq = new List<int>();

            fibSeq.Add(0);
            fibSeq.Add(1);
            for (int i = 2; i <= n; i++)
            {
                if (i == n)
                {
                    int num = fibSeq[n - 2] + fibSeq[n - 1];
                    return num;
                }
                else
                {
                    fibSeq.Add(fibSeq[i - 2] + fibSeq[i - 1]);
                }
            }



            return 0;
        }
    }
}
