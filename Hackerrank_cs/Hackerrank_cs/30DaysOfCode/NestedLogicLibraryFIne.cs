using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_cs._30DaysOfCode
{
    class NestedLogicLibraryFine
    {
        private int GetFine(DateTime actual, DateTime expected)
        {
            if (actual <= expected)
            {
                return 0;
            }
            if (actual.Year == expected.Year)
            {
                if (actual.Month == expected.Month)
                {
                    return 15 * (actual.Day - expected.Day);
                }
                else
                {
                    return 500 * (actual.Month - expected.Month);
                }
            }

            return 10000;
        }

        public NestedLogicLibraryFine()
        {
            var tmp = Console.ReadLine().Split(' ');
            var da = int.Parse(tmp[0]);
            var ma = int.Parse(tmp[1]);
            var ya = int.Parse(tmp[2]);
            
            tmp = Console.ReadLine().Split(' ');
            var de = int.Parse(tmp[0]);
            var me = int.Parse(tmp[1]);
            var ye = int.Parse(tmp[2]);

            var dt_actual = new DateTime(ya, ma, da);
            var dt_expected = new DateTime(ye, me, de);

            Console.WriteLine(GetFine(dt_actual, dt_expected));
        }
    }
}
