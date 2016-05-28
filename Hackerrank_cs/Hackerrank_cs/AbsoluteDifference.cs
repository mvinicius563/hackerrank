using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_cs
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
