namespace UniqueString
{
    public class Theatre
    {
        public void Solution()
        {

            string[] firstInput = Console.ReadLine().Split();
            int m = int.Parse(firstInput[0]);
            int n = int.Parse(firstInput[1]);
            int a = int.Parse(firstInput[2]);
            
            if(0 < m && 0 < n && 0 < a) 
            {
                Console.WriteLine((long)Math.Ceiling((double)m/a) * (long)Math.Ceiling((double)n / a));
            }

        }
    }
}
