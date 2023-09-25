using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueString
{
    public class ReplaceWord
    {
        public string ReplaceWords(IList<string> dictionary, string sentence)
        {
            StringBuilder s = new StringBuilder();
            char[] c = sentence.ToCharArray();
            foreach (var item in c)
            {
                //if(dictionary.Contains())
                s.Append(item.ToString());
            }

            return "a";
        }
    }
}
