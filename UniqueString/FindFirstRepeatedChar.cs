using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uniquestring
{
    public class FindFirstRepeatedChar
    {
        public string firstRepChar(string s)
        {
            // code here

            s = s.ToLower();
            char[] charS = s.ToCharArray();
            List<char> list = new List<char>();
            for (int i = 0; i < charS.Length; i++)
            {
                if (list.Contains(charS[i]))
                {
                    return Convert.ToString(charS[i]);
                }
                list.Add(charS[i]);

            }

            return "-1";
        }
    }
}
