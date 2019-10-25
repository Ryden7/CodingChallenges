using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[6] { 6, 7, 1, 23, 6, 59};
            Console.Write(ContainsDuplicate(numbers));
            Console.Read();
        }


    public static bool ContainsDuplicate(int[] nums)
            {
                for (int i = 0; i < nums.Length; i++)
                    for (int j = 0; j < nums.Length; j++)
                        if (nums[i] == nums[j])
                            return true;

                return false;
            }
    }
}
