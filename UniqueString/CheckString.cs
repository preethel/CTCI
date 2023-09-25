using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UniqueString
{
    public class CheckString
    {
        public bool check(string s)
        {
            // your code here       
            char[] cra = s.ToCharArray();
            Array.Sort(cra);
            for (int i = 0; i < cra.Length - 1; i++)
            {
                if (cra[i] != cra[i + 1])
                {
                    continue;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
    }
}
