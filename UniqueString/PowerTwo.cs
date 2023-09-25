namespace UniqueString
{
    public class PowerTwo{
        public bool IsPowerTwo( long n)
        {
            long res = powerTwo(n);
            if (res == 1) return true;
            if(res > 1) return false;
            return false;
        }

        private long powerTwo(long p)
        {
            if (p == 1)
            {
                return p;
            }
            else if (p % 2 == 0)
            {
                return powerTwo(p / 2); 
            }
            else
            {
                return -1; 
            }
        }
    }
}