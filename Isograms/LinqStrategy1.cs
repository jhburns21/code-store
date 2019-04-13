using System.Linq;

namespace Isograms
{
    class LinqStrategy1 : IsogramStrategy
    {
        public override bool IsIsogram(string str)
        {
            return str.ToLower().Distinct().Count() == str.Length;
        }
    }
}