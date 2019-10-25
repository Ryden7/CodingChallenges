using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BuyandSellStock
    {
        static void Main(string[] args)
        {
            int[] prices = new int[6] { 7, 1, 5, 3, 6, 4 };
            MaxProfit(prices);
            Console.Read();
        }

        //Best time to Buy and Sell Stock
        public static int MaxProfit(int[] prices)
        {
            int min = 10;
            int max = 0;
            int current = 0;
            int supermax = 0;

            for (int i = 0; i < prices.Length; i++)
                for (int j = i; j < prices.Length; j++)
                {
                    min = prices[i];
                    if (prices[j] > min)
                    {
                        max = prices[j];
                        current = max - min;
                        if (current > supermax)
                            supermax = current;
                    }



                }

            Console.Write(supermax);
            return supermax;


        }
    }

}
