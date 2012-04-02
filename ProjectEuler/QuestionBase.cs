using System.Diagnostics;

namespace ProjectEuler
{
    abstract class QuestionBase
    {
        public string Description { get; protected set; }
        public Stopwatch Stopwatch { get; private set; }

        public object Run()
        {
            Stopwatch = Stopwatch.StartNew();
            object result = RunSolution();
            Stopwatch.Stop();
            return result;
        }

        public abstract object RunSolution();
    }
}
