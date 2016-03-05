namespace Hackerrank_cs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class LisasWorkbook
    {
        public LisasWorkbook()
        {
            var tmp = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int n = tmp[0];
            int k = tmp[1];
            var chapters = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse).ToList();
            //int k = 3;
            //var chapters = new List<int> { 4, 2, 6, 1, 10 };
            //k = 1;
            //chapters = new List<int> { 100 };

            int specialProblems = 0;
            int currentPage = 1;
            for (var c = 0; c < chapters.Count; ++c)
            {
                int numProblems = chapters[c];
                int currentProblem = 1;
                while (currentProblem <= numProblems)
                {                    
                    if (currentProblem == currentPage)
                    {
                        specialProblems++;
                        //Console.WriteLine("found a special problem: {0} in chapter {1}. Current count is {2}", currentProblem, c+1, specialProblems);                        
                    }
                    currentProblem++;
                    if (currentProblem <= numProblems && (currentProblem % k == 1 || k == 1))
                    {
                        currentPage++;
                        //Console.WriteLine("currentProblem {0}, moving to page {1}", currentProblem, currentPage);
                    }
                }                
                currentPage++;
                //Console.WriteLine("finished chapter {0}, moving to new page {1}", c + 1, currentPage);
            }
            Console.WriteLine(specialProblems);
        }
    }
}
