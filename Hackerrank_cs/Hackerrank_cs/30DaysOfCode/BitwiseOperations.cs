using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_cs._30DaysOfCode
{
    class BitwiseOperations
    {
        static int get(int n, int k)
        {
            if ((k | (k - 1)) > n)
            {
                return k - 2;
            }
            else
            {
                return k - 1;
            }
        }

        public BitwiseOperations()
        {
            int n = 8;
            int k = 5;
            Console.WriteLine(5 | 4);

            Console.WriteLine("=====" + get(n, k));
            
        }
    }
}
