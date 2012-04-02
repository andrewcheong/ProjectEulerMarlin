using System;
using ProjectEuler.MiscQuestions;
using ProjectEuler.ProjectEulerQuestions;

namespace ProjectEuler
{
    class Program
    {
        static void Main()
        {
            //Q1 q = new Q1();
            //PalindromeValidator q = new PalindromeValidator("tattarrattat");
            Q3 q = new Q3();
            Console.WriteLine("Running {0}...\n", q.GetType().Name);
            Console.WriteLine("Q: {0}", q.Description);
            object result = q.Run();
            Console.WriteLine("A: {0}\n", result);
            Console.WriteLine("Solution took {0}s to run\n", q.Stopwatch.Elapsed.TotalSeconds);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
