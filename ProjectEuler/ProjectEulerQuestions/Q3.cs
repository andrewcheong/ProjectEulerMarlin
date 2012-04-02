using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler.ProjectEulerQuestions
{
    class Q3 : QuestionBase
    {
        public Q3()
        {
            Description = "What is the largest prime factor of the number 600851475143?";
        }

        public override object RunSolution()
        {
            var startingNum = 600851475143;

            //if (IsPrime2(startingNum))
            //    return startingNum;

            var smallestFactor = FindSmallestFactor(startingNum);
            var largestFactor = startingNum / smallestFactor;

            for (long i = largestFactor; i > 1; i--)
            {
                if ((startingNum % i) == 0) // If is a factor, continue
                {
                    Console.WriteLine("Found factor - {0}", i);
                    if (IsPrime2(i))
                    {
                        Console.WriteLine("Found prime factor - {0}", i);
                        return i;
                    }
                    else
                    {
                        Console.WriteLine("{0} is not a prime", i);
                    }
                }
            }

            return "No answer";
        }

        private static int FindSmallestFactor(long startingNum)
        {
            for (int i = 2; i < startingNum / 2; i++)
            {
                if (startingNum % i == 0)
                    return i;
            }

            return -1;
        }

        private static bool IsPrime2(long num)
        {
            for (long i = num / 2; i > 1; i--)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private bool IsPrime(long num)
        {
            List<long> knownPrimes = new List<long>();

            foreach (var knownPrime in knownPrimes)
            {
                if (num % knownPrime == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private List<long> PrimeList(long upperLimit)
        {
            throw new NotImplementedException();
        }
    }
}
