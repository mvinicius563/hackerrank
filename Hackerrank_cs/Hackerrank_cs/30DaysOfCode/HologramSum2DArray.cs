using System;

namespace Hackerrank_cs._30DaysOfCode
{
    class MaxHologramSum2DArray
    {
        public static int [,] DefaultInput = new int[,] { { 1, 1, 1, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0 }, { 1, 1, 1, 0, 0, 0 }, { 0, 0, 2, 4, 4, 0 }, { 0, 0, 0, 2, 0, 0 },
                { 0, 0, 1, 2, 4, 0} };

        public MaxHologramSum2DArray(int[,] arr = null)
        {
            if (arr == null)
            {
                arr = DefaultInput;
            }
            //int[][] arr = new int[6][];
            //for (int arr_i = 0; arr_i < 6; arr_i++)
            //{
            //    string[] arr_temp = Console.ReadLine().Split(' ');
            //    arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
            //}


            int max = -9999999;
            for (int i = 0; i < 6 - 2; ++i)
            {
                for (int j = 0; j < 6 - 2; ++j)
                {
                    int s = HologramSum(arr, i, j);
                    max = s > max ? s : max;
                }
            }
            Console.WriteLine(max);
        }

        private static int HologramSum(int[,] arr, int i, int j)
        {
            return arr[i,j] + arr[i,j + 1] + arr[i,j + 2] +
                               arr[i + 1,j + 1] +
                   arr[i + 2,j] + arr[i + 2,j + 1] + arr[i + 2,j + 2];

        }
    }
}
