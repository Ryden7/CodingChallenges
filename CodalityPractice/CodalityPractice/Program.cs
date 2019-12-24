using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodalityPractice
{
    class Program
    {
        static void Main(string[] args)
        {


        }

        // you can also use other imports, for example:
        // using System.Collections.Generic;

        // you can write to stdout for debugging purposes, e.g.
        // Console.WriteLine("this is a debug message");

        class Solution
        {
            public int solution(int[] A)
            {
                // write your code in C# 6.0 with .NET 4.5 (Mono)
                int SmallestInt = 1;
                Array.Sort(A);

                foreach (var item in A)
                {
                    if (item > SmallestInt)
                        SmallestInt = item;
                }

                SmallestInt += 1;
                var OtherTest = helper(A);

                if (SmallestInt != OtherTest)
                    SmallestInt = OtherTest;


                return SmallestInt;
            }

            private int helper(int[] A)
            {
                int Other = 1;

                for (int i = 1; i <= A.Length; i++)
                {
                    if (A.Contains(i))
                    {
                        Other += 1;
                    }
                    else
                        return Other;
                }

                return Other;
            }
        }


    }
}
