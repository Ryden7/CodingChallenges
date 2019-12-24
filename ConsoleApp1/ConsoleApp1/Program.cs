using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> doubles = new List<double> { 2.0, 2.1, 2.2, 2.3 };
            double whatsThis = doubles.Last(val => val < 2.1);
            Console.Write(whatsThis);
            Console.Read();
        }
    }
}
