using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UniqueString
{
    public class NonRepeatedstring
    {
        public bool nonRepetitive(string S)
        {
            // Your code goes here
            char[] c = S.ToCharArray();
            List<char> al = new List<char>();
            for (int i = 0; i < c.Length; i++)
            {
                if (al.Contains(c[i]))
                {
                    return false;
                }
                if (i + 1 == c.Length) continue;
                if (c[i] == c[i + 1])
                {
                    continue;
                }
                else
                {
                    al.Add(c[i]);
                }
            }
            return true;
        }
    }
}
