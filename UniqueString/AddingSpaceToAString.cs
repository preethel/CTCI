using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueString
{
    public class AddingSpaceToAString
    {
        public string AddSpaces(string s, int[] spaces)
        {
            string ans = string.Empty;
            for(int i = 0, j =0; i < s.Length; i++)
            {
                if (j < spaces.Length && i == spaces[j])
                {
                    ans += " ";
                    j++;
                }
                ans += s[i];
            }
            Console.WriteLine("ans:" + ans);







            string result = string.Empty;
            int startPosition = 0;
            int endItem;
            for (int i = 0; i < spaces.Length; i++)
            {
                endItem = spaces[i] - startPosition;
                string v = s.Substring(startPosition, endItem);
                startPosition = spaces[i];
                result += v + " ";
            }
            result += s.Substring(spaces[spaces.Length - 1]);
            return result;
        }
        
    }
}
//"123456789
//"LeetcodeHelpsMeLearn"
//8,13,15