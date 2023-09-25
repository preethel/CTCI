using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UniqueString
{
    public class TheNonRepetitiveString
    {
        public bool nonRepetitive(string S)
        {

            char[] c = S.ToCharArray();

            for(int i = 0; i < c.Length - 1; i++)
            {
                if (c[i] == c[i + 1])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
