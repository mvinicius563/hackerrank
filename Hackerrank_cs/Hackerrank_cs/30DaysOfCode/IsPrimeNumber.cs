using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hackerrank_cs._30DaysOfCode
{
    class IsPrimeNumber
    {
        private static void printStats(int count, int n, bool isPrime)
        {
            StackTrace st = new StackTrace();
            string caller = st.GetFrame(1).GetMethod().Name;
            Console.WriteLine("{0} performed {1} checks, determined {2} {3} prime",
                caller, count, n, isPrime ? "is" : "is not");
        }

        /**
    *   Worst: O(n) algorithm
    *     Checks if n is divisible by any number from 4 to n.
    *
    *   @param n An integer to be checked for primality.
    *   @return true if n is prime, false if n is not prime.
    **/
        public static bool isPrimeWorst(int n)
        {
            int count = 0;
            // 1 is not prime
            if (n == 1)
            {
                printStats(++count, n, false);
                return false;
            }

            // return false n is divisible by any i from 2 to n
            for (int i = 2; i < n-1; i++)
            {
                count++;
                if (n % i == 0)
                {
                    printStats(++count, n, false);
                    return false;
                }
            }

            // n is prime
            printStats(++count, n, true);
            return true;
        }

        /**
        *   Better: O(n) algorithm
        *    Checks if n is divisible by any number from 2 to n/2,
        *    but is asymptotically the same as isPrimeWorst
        *
        *   @param n An integer to be checked for primality.
        *   @return true if n is prime, false if n is not prime.
        **/
        public static bool isPrimeLessWorst(int n)
        {
            int count = 0;
            // 1 is not prime
            if (n == 1)
            {
                printStats(++count, n, false);
                return false;
            }

            // return false n is divisible by any i from 2 to n
            for (int i = 2; i <= n/2; i++)
            {
                count++;
                if (n % i == 0)
                {
                    printStats(++count, n, false);
                    return false;
                }
            }

            // n is prime
            printStats(++count, n, true);
            return true;
        }

        /**
        *   O(n^(1/2)) Algorithm
        *    Checks if n is divisible by any number from 2 to sqrt(n).
        *
        *   @param n An integer to be checked for primality.
        *   @return true if n is prime, false if n is not prime.
        **/
        public static bool isPrimeGood(int n)
        {
            int count = 0;
            // 1 is not prime
            if (n == 1)
            {
                printStats(++count, n, false);
                return false;
            }
            else if (n == 2)
            {
                printStats(++count, n, true);
                return true;
            }

            // return false n is divisible by any i from 2 to n
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                count++;
                if (n % i == 0)
                {
                    printStats(++count, n, false);
                    return false;
                }
            }

            // n is prime
            printStats(++count, n, true);
            return true;
        }

        /**
        *   Improved O( n^(1/2)) ) Algorithm
        *    Checks if n is divisible by 2 or any odd number from 3 to sqrt(n).
        *    The only way to improve on this is to check if n is divisible by 
        *   all KNOWN PRIMES from 2 to sqrt(n).
        *
        *   @param n An integer to be checked for primality.
        *   @return true if n is prime, false if n is not prime.
        **/
        public static bool isPrimeBest(int n)
        {
            int count = 0;
            // check lower boundaries on primality
            if (n == 2)
            {
                printStats(++count, n, true);
                return true;
            } // 1 is not prime, even numbers > 2 are not prime
            else if (n == 1 || (n & 1) == 0)
            {
                printStats(++count, n, false);
                return false;
            }

            // Check for primality using odd numbers from 3 to sqrt(n)
            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                count++;
                // n is not prime if it is evenly divisible by some 'i' in this range
                if (n % i == 0)
                {
                    printStats(++count, n, false);
                    return false;
                }
            }
            // n is prime
            printStats(++count, n, true);
            return true;
        }

        public IsPrimeNumber()
        {
            int n = 0;
            while (int.TryParse(Console.ReadLine(), out n))
            {
                isPrimeWorst(n);
                isPrimeLessWorst(n);
                isPrimeGood(n);
                isPrimeBest(n);
                Console.WriteLine();
            }    
        }
    }
}
