using System;

namespace Isograms
{
    class Program
    {
        static void Main(string[] args)
        {
            // init our concrete strategy
            LoopStrategy1 s = new LoopStrategy1();
            LinqStrategy1 ls = new LinqStrategy1();

            // add to the solver
            IsogramSolver solver = new IsogramSolver(ls);
            Console.WriteLine(solver.Solve("new"));
            Console.WriteLine(solver.Solve("aba"));
            Console.WriteLine(solver.Solve("moOse"));
            return;
        }
    }
}
