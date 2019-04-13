
namespace Isograms
{
    public class IsogramSolver
    {
        IsogramStrategy strategy;

        public IsogramSolver(IsogramStrategy s)
        {
            strategy = s;
        }

        public bool Solve(string str)
        {
            return strategy.IsIsogram(str);
        }
    }
}