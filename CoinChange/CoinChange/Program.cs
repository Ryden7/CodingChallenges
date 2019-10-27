using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinChange
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] coins = new int[3] { 1, 3, 5 };
            int amount = 11;
            Console.WriteLine(CoinChange(coins, amount));
            Console.Read();
        }

        public static int CoinChange(int[] coins, int amount)
        {

            int NumofCoins = 0;
            for (int i = coins.Length; i > 0; i--)
            {
                if (amount == 0)
                    break;

                //Console.Write(coins[i - 1]);

                NumofCoins += amount / coins[i - 1];
                if (amount > coins[i-1])
                    amount = amount - (coins[i - 1] * NumofCoins);

            }

            return NumofCoins;
        }
    }
}
