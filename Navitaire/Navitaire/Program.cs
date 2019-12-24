using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navitaire
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(solution(2, "1A 2F 1C"));
            Console.Read();
        }

        public static int solution(int N, string S)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            bool[,] seating = new bool[N, 10];
            int counter = 0;

            if (S != "")
            {
                string[] reservations = S.Split(' ');

                foreach (string word in reservations)
                {
                    // Console.WriteLine(word[1]);
                    char rowchar = word[0];
                    int row = rowchar - '0';


                    int column = 0;
                    if (word != "")
                    {
                        switch (word[1])
                        {
                            case 'A':
                                column = 0;
                                break;
                            case 'B':
                                column = 1;
                                break;

                            case 'C':
                                column = 2;
                                break;

                            case 'D':
                                column = 3;
                                break;

                            case 'E':
                                column = 4;
                                break;

                            case 'F':
                                column = 5;
                                break;

                            case 'G':
                                column = 6;
                                break;

                            case 'H':
                                column = 7;
                                break;

                            case 'J':
                                column = 8;
                                break;

                            case 'K':
                                column = 9;
                                break;

                        }
                        row -= 1;
                        Console.WriteLine(row);
                        Console.WriteLine(column);

                        seating[row, column] = true;

                    }

                }

                for (int j = 0; j < N; j++)
                    {
                        if (seating[j, 0] == false && seating[j, 1] == false && seating[j, 2] == false)
                            counter++;

                        if (seating[j, 3] == false && seating[j, 4] == false && seating[j, 5] == false ||
                                seating[j, 4] == false && seating[j, 5] == false && seating[j, 6] == false)
                            counter++;

                        if (seating[j, 7] == false && seating[j, 8] == false && seating[j, 9] == false)
                            counter++;
                    }

            }

            return counter;

        }

    }
}
