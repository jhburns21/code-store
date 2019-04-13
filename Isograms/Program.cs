using System;

namespace Isograms
{
    class Program
    {
        static void Main(string[] args)
        {
            // init our concrete strategy
            LoopStrategy1 s = new LoopStrategy1();

            // add to the solver
            IsogramSolver solver = new IsogramSolver(s);
            Console.WriteLine(solver.Solve("new"));

            return;
        }
    }
}
