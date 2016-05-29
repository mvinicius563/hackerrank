namespace Hackerrank_cs._30DaysOfCode
{
    using System;
    using Utils;
    class Sorting
    {
        public static int BubbleSort(int[] a)
        {
            int totalSwaps = 0;
            int n = a.Length;
            for (int i = 0; i < n; i++)
            {
                int numberOfSwaps = 0;

                for (int j = 0; j < n - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        Utils.Swap(ref a[j], ref a[j + 1]);
                        numberOfSwaps++;
                    }
                }

                totalSwaps += numberOfSwaps;

                if (numberOfSwaps == 0)
                {
                    break;
                }
            }

            return totalSwaps;
        }

        public Sorting()
        {
            int[] a = { 1, 3, 5, 2, 4 };
            //Console.WriteLine(string.Join(" ", a));
            int totalSwaps = BubbleSort(a);
            //Console.WriteLine(string.Join(" ", a));

            Console.WriteLine("Array is sorted in {0} swaps.", totalSwaps);
            Console.WriteLine("First Element: {0}", a[0]);
            Console.WriteLine("Last Element: {0}", a[a.Length-1]);
        }
    }
}
