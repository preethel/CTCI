using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueString
{
    public class PermutationString
    {
        public bool checkInclusion(string s1, string s2)
        {
            int[] p = new int[26];
            Array.Clear(p, 0, p.Length);


            

            int j = 0;

            char[] c2 = s1.ToCharArray();
            foreach (var item in c2)
            {
                int index = item;
                p[index - 97] = 1;
                Console.WriteLine(index);
            }


            //foreach (int i in p)
            //{

            //    Console.WriteLine($"{++j} - > {i}");
            //}

            return false;
        }
    }
}
