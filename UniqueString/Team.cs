using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueString
{
    public class Team
    {
        public void Solution()
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            while (n-- > 0)
            {
                int sum = 0;
                string[] str = Console.ReadLine().Split();
                foreach (string m in str) 
                {
                    sum += int.Parse(m);
                }
                if(sum >= 2)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
