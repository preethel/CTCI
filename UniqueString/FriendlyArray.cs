using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueString
{
    public class FriendlyArray
    {
        public void Solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                string[] nm = Console.ReadLine().Split();
                int n = int.Parse(nm[0]);
                int m = int.Parse(nm[1]);

                int x;
                int firstAns = 0, secondAns = 0;
                int temp = 0;
                List<int> x1 = new List<int>();

                string[] nValues = Console.ReadLine().Split();
                for (int i = 0; i < n; i++)
                {
                    x = int.Parse(nValues[i]);
                    x1.Add(x);
                }

                string[] mValues = Console.ReadLine().Split();
                for (int i = 0; i < m; i++)
                {
                    x = int.Parse(mValues[i]);
                    temp |= x;
                }

                foreach (int val in x1)
                {
                    firstAns ^= (val | temp);
                    secondAns ^= val;
                }

                Console.WriteLine(Math.Min(firstAns, secondAns) + " " + Math.Max(firstAns, secondAns));
            }

        }
    }
}
