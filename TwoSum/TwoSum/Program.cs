using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[4] { 2, 7, 11, 15 };
           var asdf = TwoSum(nums, 13);
            Console.WriteLine(asdf[0]);
            Console.WriteLine(asdf[1]);


            Console.Read();
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            int[] a = { };
            for (int i = 0; i < nums.Length; i++)
                for (int j = 0; j < nums.Length; j++)
                    if (nums[i] + nums[j] == target)
                    {
                        int[] intArray = new int[2] { i, j };
                        return intArray;

                    }
            int[] intArray2 = new int[2] { 0, 0 };
            return intArray2;
        }
    }
}
