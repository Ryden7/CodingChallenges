using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge7
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] input = new int[7] { 1, 3, 5, 2, 4, 6, 7};

            Console.WriteLine(minimumSwaps(input));
            Console.Read();
        }

        static int minimumSwaps(int[] arr)
        {
            int count = 0;
            int[] referenceArray = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
                referenceArray[i] = i+1;

            Array.Sort(referenceArray);

            for (int i = 0; i < arr.Length; i++)
            {
                var currentElement = arr[i];
                var referenceElement = referenceArray[i];
                if (currentElement != referenceElement)
                {
                    var index = arr.ToList().IndexOf(referenceElement);
                    var holder = currentElement;

                    arr[i] = arr[index];
                    arr[index] = holder;
                    count++;

                }

            }

            return count;
            //for (int i = 0; i < arr.Length-1; i++)
            //{
            //    var currentElement = arr[i];
            //    int ElementHolder = currentElement;

            //    var referenceElement = referenceArray[i+1];

            //    var index = arr.ToList().IndexOf(referenceElement);


            //    int ElementAt = arr[index];

            //    arr[i] = ElementAt;
            //    arr[index] = ElementHolder;
            //    count++;
            //}
            //return count;
        }
    }
}
