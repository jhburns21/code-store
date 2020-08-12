using System;
// https://www.codewars.com/kata/56747fd5cb988479af000028/train/csharp
namespace MiddleCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            MiddleCharacterSolver solver = new MiddleCharacterSolver(new Strategy1());
            Console.WriteLine(solver.Solve("Test"));
            Console.WriteLine(solver.Solve("Testing"));
            Console.WriteLine(solver.Solve("Middle"));
            Console.WriteLine(solver.Solve("a"));
        }
    }
}
