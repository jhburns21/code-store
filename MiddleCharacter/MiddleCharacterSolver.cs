
namespace MiddleCharacter
{
    public class MiddleCharacterSolver
    {
        MiddleCharacterStrategy strategy;

        public MiddleCharacterSolver(MiddleCharacterStrategy s)
        {
            strategy = s;
        }

        public string Solve(string str)
        {
            return strategy.GetMiddleCharacters(str);
        }
    }
}