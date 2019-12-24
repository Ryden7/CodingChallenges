using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the hourglassSum function below.
    public static int hourglassSum(int[][] arr)
    {
        List<int> list = new List<int>();
        for (int i = 0; i < arr.Length; i++)
        {
            

            for (int j = 0; j < arr.Length; j++)
            {
                int total = 0;
                int toprow = 0;
                int midrow = 0;
                int botrow = 0;

                if ((j + 1) < arr.Length && (j+2) < arr.Length)
                {
                    toprow = arr[i][j] + arr[i][j + 1] + arr[i][j + 2];
                }

                if (i+1 < arr.Length && j+1 < arr.Length)
                {
                    int mid = j;
                    midrow = arr[i + 1][mid + 1];
                }

                if (i+2 < arr.Length && j+2 < arr.Length)
                {
                    botrow = arr[i+2][j] + arr[i+2][j + 1] + arr[i+2][j + 2];
                }

                total = toprow + midrow + botrow;
                list.Add(total);

            }

        }

        return list.Max();
    }

    public static void Main(string[] args)
    {

        int[][] arr = new int[6][];

        arr[0] = new int[6] {1, 1, 1, 0, 0, 0 };
        arr[1] = new int[6] {0, 1, 0, 0, 0, 0 };
        arr[2] = new int[6] { 1, 1, 1, 0, 0, 0 };
        arr[3] = new int[6] { 0, 0, 2, 4, 4, 0 };
        arr[4] = new int[6] { 0, 0, 0, 2, 0, 0 };
        arr[5] = new int[6] { 0, 0, 1, 2, 4, 0 };

        int result = hourglassSum(arr);
        Console.WriteLine(result);
        Console.Read();


    }
}
