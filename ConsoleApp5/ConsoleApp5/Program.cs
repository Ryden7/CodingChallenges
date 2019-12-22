using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[15] { 33, 47, 70, 37, 8, 53, 13, 93, 71, 72, 51, 100, 60, 87, 97};
            int[] retArr = rotLeft(input, 13);

            foreach (var item in retArr)
            {
                Console.WriteLine(item);
            }
            Console.Read();

        }

        // Complete the rotLeft function below.
        static int[] rotLeft(int[] a, int d)
        {
            int[] rotatedArray = new int[a.Length];

            List<int> list = a.ToList();

            for (int i = 0; i < list.Count; i++)
            {
                if (d + 1 <= a.Length)
                {
                    rotatedArray[i] = list[d];
                    d++;

                }
                else
                {
                    d = a.Length - d;
                    rotatedArray[i] = list[d];
                    d++;

                }

            }

            return rotatedArray;
        }
    }
}
