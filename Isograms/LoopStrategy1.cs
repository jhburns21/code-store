using System.Collections.Generic;

namespace Isograms
{
    class LoopStrategy1 : IsogramStrategy
    {
        public override bool IsIsogram(string str)
        {
            if (str == "")
            {
                return true;
            }

            char[] letters = str.ToLower().ToCharArray();
            List<char> letterList = new List<char>(letters);

            for (int i = 0; i < letters.Length; i++)
            {
                char c = letters[i];
                letterList.RemoveAt(0);
                if (letterList.Contains(c))
                    return false;
            }

            return true;
        }
    }
}