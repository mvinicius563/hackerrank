using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_cs._30DaysOfCode
{
    class MaxRectangularAreaInHistogram
    {

        static int GetArea(Stack<int> tops, int[] arr, int i)
        {
            var top = tops.Pop();
            //Console.WriteLine($"top is {top}");
            if (tops.Any())
            {
                var stacktop = tops.Peek();
                return arr[top] * (i - stacktop - 1);
            }
            else
            {
                return arr[top] * i;
            }
        }

        public MaxRectangularAreaInHistogram()
        {
            Stack<int> tops = new Stack<int>();
            var arr = new int[] { 2, 1, 2, 3, 1 };
            var n = arr.Count();
            int max = -1;

            tops.Push(0);
            int i = 1;
            while (i < n)
            {
                if (!tops.Any())
                {
                    tops.Push(i);
                    i++;
                    continue;
                }

                var stacktop = tops.Peek();
                if (arr[i] >= arr[stacktop])
                {
                    tops.Push(i);
                    i++;
                    continue;
                }

                var area = GetArea(tops, arr, i);
                //Console.WriteLine($"got area {area}");
                max = area > max ? area : max;
            }

            while (tops.Any())
            {
                var area = GetArea(tops, arr, i);
                max = area > max ? area : max;
            }

            Console.WriteLine(max);
        }
    }
}
