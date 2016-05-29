using System;
using System.Linq;

namespace Hackerrank_cs._30DaysOfCode
{
    class AbsoluteDifference
    {
        private int[] elements;
        public int maximumDifference;

        public AbsoluteDifference(int[] arr)
        {
            this.elements = arr;
        }

        public void computeDifference()
        {
            Array.Sort(elements);
            maximumDifference = elements.Last() - elements.First();
        }
    }
}
