using System;
using System.Linq;

namespace Hackerrank_cs._30DaysOfCode
{
    class BinaryNumbers
    {
        public BinaryNumbers()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Convert.ToString(n, 2).Split('0').Select(x => x.Length).Max());
        }
    }
}
