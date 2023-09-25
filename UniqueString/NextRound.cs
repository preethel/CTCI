using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueString
{
    public class NextRound
    {
        public void Solution()
        {
            string[] FirstInput = Console.ReadLine().Split();
            int len = int.Parse(FirstInput[0]);
            string[] SecInput = Console.ReadLine().Split();
            int compareValue = int.Parse(SecInput[int.Parse(FirstInput[1])-1]);
            int count = 0;
            foreach (string sec in SecInput)
            {
                if(int.Parse(sec)>=compareValue && int.Parse(sec)> 0)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
