using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueString
{
    public class SameCharacterInTwoString
    {
        public int SameChar(string A, string B)
        {
            A = A.ToLower();
            B = B.ToLower();
            char[] charA = A.ToCharArray();
            char[] charB = B.ToCharArray();

            //for(int i = charA.Length - 1; i >= 0; i--)
            //{
            //    if (charA[i] )
            //}
            int count = 0;
            //Console.WriteLine(charA.Length - 1);
            for (int i = 0; i < charA.Length - 1; i++)
            {
                for (int j = 0; j < charB.Length - 1; j++)
                {
                    if (charA[i] == charB[j])
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
