using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_cs
{
    class BeautifulPairs
    {

        public BeautifulPairs()
        {
            //int n = Convert.ToInt32(Console.ReadLine());
            var a = new List<int>() { 1 };
            var b = new List<int>() { 1 };
            //var a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToList();
            //var b = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToList();


            //var pairs = GetBeautifulPairs(a, b);
            //Console.WriteLine(string.Join(" ", pairs));

            var mapA = new Dictionary<int, int>();
            var mapB = new Dictionary<int, int>();
            foreach (var i in a)
            {
                if (mapA.ContainsKey(i))
                {
                    ++mapA[i];
                }
                else
                {
                    mapA[i] = 1;
                }
            }
            foreach (var i in b)
            {
                if (mapB.ContainsKey(i))
                {
                    ++mapB[i];
                }
                else
                {
                    mapB[i] = 1;
                }
            }

            //Console.WriteLine(string.Join(";", mapA));
            //Console.WriteLine(string.Join(";", mapB));
            int aHasTheMost = mapA.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;

            //Console.WriteLine(aHasTheMost);
            int max = 0;
            int key = 0;
            foreach (var i in mapA)
            {
                if (mapB.ContainsKey(i.Key))
                {
                    var potential = mapA[i.Key] * mapB[i.Key];
                    if (potential > max)
                    {
                        key = i.Key;
                        max = potential;
                    }
                }
            }
            Console.WriteLine("key {0} and max {1}", key, max);
            int keyToRemove = FindKeyToRemove(mapA, mapB);
            if (keyToRemove < 0)
            {
                throw new Exception("to hell with this");
            }
            Console.WriteLine("remove {0}", keyToRemove);

            Console.WriteLine(string.Join(";", mapB));
            mapB[keyToRemove]--;
            if (key != keyToRemove)
            {
                if (mapB.ContainsKey(key))
                {
                    mapB[key]++;
                }
                else
                {
                    mapB.Add(key, 1);
                }
            }

            Console.WriteLine(string.Join(";", mapB));

            int res = 0;
            foreach (var i in mapA)
            {
                var mapBCount = mapB.ContainsKey(i.Key) ? mapB[i.Key] : 0;
                while (mapBCount > 0)
                {
                    ++res;
                    mapBCount--;
                }
            }

            //return res;         
            Console.WriteLine("answer: {0}", res);
        }
        public struct Pair
        {
            public int i;
            public int j;

            public Pair(int i, int j)
            {
                this.i = i;
                this.j = j;
            }

            public override string ToString()
            {
                return string.Format("({0},{1})", i, j);
            }
        }
        public static List<Pair> GetBeautifulPairs(List<int> a, List<int> b)
        {
            var res = new List<Pair>();
            for (int i = 0; i < a.Count; ++i)
            {
                for (int j = 0; j < b.Count; ++j)
                {
                    if (a[i] == b[j])
                    {
                        res.Add(new Pair(i, j));
                    }
                }
            }

            return res;
        }

        public static int FindKeyToRemove(Dictionary<int, int> mapA, Dictionary<int, int> mapB)
        {
            foreach (var i in mapB)
            {
                if (!mapA.ContainsKey(i.Key))
                {
                    return i.Key;
                }
                int min = 1;
                while (min < 10000)
                {
                    var candidate = mapA.Where(x => x.Value == min);
                    if (candidate.Any())
                    {
                        return candidate.First().Key;
                    }
                    min++;
                }
                //todo: find smallest value in A
            }
            return -1;
        }
    }
}
