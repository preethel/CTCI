using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueString
{
    public class WayTooLongWords
    {
        public void Solution()
        {
            int n = int.Parse(Console.ReadLine());
            while(n-- > 0)
            {
                string[] str = Console.ReadLine().Split();
                //char[] word = str[0].ToCharArray();
                string word = str[0];
                string ans = string.Empty;
                if(word.Length > 10)
                {
                    int ln = word.Length - 2;
                    ans = $"{word[0]}{ln}{word[word.Length-1]}";
                    Console.WriteLine(ans);
                }
                else
                {
                    Console.WriteLine(word);

                }
            }
        }
    }
}
