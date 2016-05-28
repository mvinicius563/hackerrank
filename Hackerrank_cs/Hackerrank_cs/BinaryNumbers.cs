using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_cs
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
