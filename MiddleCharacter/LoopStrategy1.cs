using System.Linq;
using System.Collections.Generic;

namespace MiddleCharacter
{
    public class Strategy1 : MiddleCharacterStrategy
    {
        public override string GetMiddleCharacters(string str)
        {
            int mid = (str.Count() - 1) / 2;
            char[] strlist = str.ToArray();
            if (isEven(str))
            {
                string result = new string(new char[] { strlist[mid], strlist[mid + 1] });
                return result;
            }
            else
            {
                string result = new string(new char[] { strlist[mid] });
                return result;
            }
        }

        private bool isEven(string s)
        {
            return s.Count() % 2 == 0;
        }
    }
}